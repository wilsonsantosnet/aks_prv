using Microsoft.AspNetCore.Mvc;

namespace Sample_api_users.Controllers
{
    /// <summary>
    /// Devolve informações do Dispositivo
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {

        [HttpPost]
        public IActionResult Post()
        {

            var ua = Request.Headers["User-Agent"].ToString();
            var isM = Utils.IsMobile(ua);

            return Ok(new
            {
                User = User.Identity.Name,
                ua = ua,
                IsMobile = isM
            });
        }

        [HttpGet]
        public IActionResult Index()
        {

            var ua = Request.Headers["User-Agent"].ToString();
            var isM = Utils.IsMobile(ua);

            return Ok(new
            {
                User = User.Identity.Name,
                ua = ua,
                IsMobile = isM
            });
        }

    }
}
