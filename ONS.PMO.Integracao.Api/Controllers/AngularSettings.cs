using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ONS.PMO.Integracao.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AngularSettingsController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public AngularSettingsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(IActionResult), StatusCodes.Status200OK)]
        public Task<IActionResult> Get()
        {
            var settings = new
            {
                federationUrl = _configuration.GetValue<string>("ONSPopAuthTokenURL:PMOIntegracaoPopAuthTokenURL"),
                //conectionStringDev = _configuration.GetValue<string>("ConnectionStrings:PMOIntegracaoConnectionString"),
                endointOpentelemtry = _configuration.GetValue<string>("OpenTelemetry:Otlp:Endpoint"),
                //testConfigValue = _configuration.GetValue<string>("TestConfigValue") 
            };
            return Task.FromResult<IActionResult>(Ok(settings));
        }
    }
}
