using ONS.PMO.Integracao.Application;
using ONS.PMO.Integracao.Infraestructure;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
using Microsoft.EntityFrameworkCore;
using OpenTelemetry.Resources;
using OpenTelemetry.Logs;
using OpenTelemetry.Metrics;
using OpenTelemetry.Trace;
using System.Diagnostics;

namespace ONS.PMO.Integracao.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var env = builder.Environment;

            ILogger<Program> logger = LoggerFactory.Create(logging =>
            {
                logging.AddConsole();
            }).CreateLogger<Program>();

            builder.Services.AddRazorPages();
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            string testConfigValue = string.Empty;

            if (env.IsDevelopment())
            {
                builder.Services.RegisterApplication(builder.Configuration)
                                .RegisterRepository(builder.Configuration.GetConnectionString("PMOIntegracaoConnectionStringDev"));
            }
            else
            {
                var environmentVariables = Environment.GetEnvironmentVariables();

                builder.Configuration.AddConfigITConfiguration(options =>
                {
                    options["-amb"] = environmentVariables["ConfigITamb"]?.ToString();
                    options["-user"] = environmentVariables["ConfigITuser"]?.ToString();
                    options["-password"] = environmentVariables["ConfigITpwd"]?.ToString();
                    options["-r"] = environmentVariables["ConfigITr"]?.ToString();
                });

                var connectionString = builder.Configuration.GetConnectionString("PMOIntegracaoConnectionString");
                builder.Configuration["TestConfigValue"] = connectionString;
                builder.Services.RegisterApplication(builder.Configuration)
                    .RegisterRepository(connectionString);
            }

            var supportedCultures = new[]
            {
                new CultureInfo("en-US"),
                new CultureInfo("pt-BR"),
            };

            builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

            var resourceBuild = ResourceBuilder.CreateDefault()
                .AddService(serviceName: "ONS.PMO.Integracao.Api", serviceVersion: "1.0.4")
                .AddTelemetrySdk();

           
            builder.Services.AddOpenTelemetry()
                .WithMetrics(builder =>
                {
                    builder.AddMeter("ONS.PMO.Integracao.Api")
                        .SetResourceBuilder(resourceBuild)
                        .AddHttpClientInstrumentation()
                        .AddAspNetCoreInstrumentation()
                        .AddConsoleExporter()
                        .AddOtlpExporter(exporter => { exporter.Protocol = OpenTelemetry.Exporter.OtlpExportProtocol.Grpc; });
                })
                .WithTracing(builder =>
                {
                    builder.AddSource("ONS.PMO.Integracao.Api")
                        .SetResourceBuilder(resourceBuild)
                        .AddHttpClientInstrumentation(options => options.RecordException = true)
                        .AddAspNetCoreInstrumentation(options => options.RecordException = true)
                        .SetErrorStatusOnException()
                        .AddConsoleExporter()
                        .AddOtlpExporter(exporter =>
                        {
                            exporter.Protocol = OpenTelemetry.Exporter.OtlpExportProtocol.Grpc;
                        });
                });

           
            builder.Logging.ClearProviders();
            builder.Logging.AddOpenTelemetry(loggerOptions =>
            {
                loggerOptions
                    .SetResourceBuilder(resourceBuild)
                    .AddConsoleExporter()
                    .AddOtlpExporter(exporter =>
                    {
                        exporter.Protocol = OpenTelemetry.Exporter.OtlpExportProtocol.Grpc;
                    });

                loggerOptions.IncludeFormattedMessage = true;
                loggerOptions.IncludeScopes = true;
                loggerOptions.ParseStateValues = true;
            });

            
            builder.Logging.AddFilter("Microsoft.EntityFrameworkCore.Database.Command", LogLevel.Information);

            var app = builder.Build();

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("en-US"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });

            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();

            app.UseRouting();

            
            app.Use(async (context, next) =>
            {
                var activity = Activity.Current;
                if (activity != null && activity.IsAllDataRequested)
                {
                    activity.SetTag("http.method", context.Request.Method);
                    activity.SetTag("http.url", $"{context.Request.Scheme}://{context.Request.Host}{context.Request.Path}{context.Request.QueryString}");
                }

                await next();
            });

            app.UseCors("CorsPolicy");

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllers();
            app.MapRazorPages();

            app.Run();
        }
    }
}
