using Microsoft.AspNetCore.Mvc;
using Net8DataAnnotations.Models;
using static Net8DataAnnotations.Models.AlertDiendModel;

namespace DeniedValuesExample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlertsController : ControllerBase
    {
        [HttpPost]
        [Route("create")]
        public IActionResult CreateAlert([FromBody] AlertDiendModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Logic to handle the alert value
            return Ok($"Alert value '{model.AlertValue}' is accepted.");
        }


        [HttpPost]
        [Route("createAllowed")]
        public IActionResult  AllowedAlert([FromBody] AlertAllowedModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Logic to handle the alert value
            return Ok($"Alert value '{model.AlertValue}' is accepted.");
        }
    }
}
