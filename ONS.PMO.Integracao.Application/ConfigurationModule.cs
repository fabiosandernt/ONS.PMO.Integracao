﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using ONS.PMO.Integracao.Application.Service.Implementation;
using ONS.PMO.Integracao.Application.Service.Interfaces;
using ONS.PMO.Integracao.Domain.Interfaces.Repository.PMO;
using System.Text;

namespace ONS.PMO.Integracao.Application
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterApplication(
            this IServiceCollection services,
            IConfiguration configuration
        )
        {
            services.AddAutoMapper(typeof(Application.ConfigurationModule).Assembly);

            services.AddScoped<IPmoServices, PmoServices>(); 
            services.AddScoped<IInsumoService, InsumoService>();
            services.AddScoped<IPmoServices, PmoServices>();
            services.AddScoped<IInsumoService, InsumoService>();
            services.AddScoped<IParametroService, ParametroService>();
            services.AddScoped<INotificacaoService, NotificacaoService>();
            services.AddScoped<IColetaInsumoService, ColetaInsumoService>();
            services.AddScoped<ISharePointService, SharePointService>();
            services.AddScoped<IHistoricoService, HistoricoService>();
            services.AddScoped<ISemanaOperativaService, SemanaOperativaService>();


            services.AddHttpClient();

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                );
            });

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(configuration["JwtSecurity:PMOIntegracaoJwtSecurity"])),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true
                };
            });

            var info = new OpenApiInfo();
            info.Version = "V1";
            info.Title = "API ";

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", info);
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "Insira o token JWT desta maneira : Bearer {seu token}",
                    Name = "Authorization",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"

                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In= ParameterLocation.Header,

                        },
                        new List<string>()
                    }
                });
            });

            return services;

        }
    }
}
