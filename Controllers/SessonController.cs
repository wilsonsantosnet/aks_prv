using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample_api_users.Controllers
{
    /// <summary>
    /// Horario do Servidor
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class SessionsController : ControllerBase
    {

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(new
            {
                DateTime.Now,
                nowddMMyyyyHHmmss = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),
                nowddMMyyyyHHmmssTZ = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time")).ToString("dd/MM/yyyy HH:mm:ss")
            }); 
        }
    }
}
