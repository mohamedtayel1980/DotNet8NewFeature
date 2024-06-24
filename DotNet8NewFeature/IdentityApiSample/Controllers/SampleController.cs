using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityApiSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SampleController : ControllerBase
    {
        [HttpGet("secure-data")]
        public IActionResult GetSecureData()
        {
            return Ok(new { data = "This is secure data." });
        }
    }
}
