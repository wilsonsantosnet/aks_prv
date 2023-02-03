using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sample_api_users.Model;
using System.Collections.Generic;
using System.Linq;

namespace Sample.Controllers
{


    public class identitie
    {

        public string issuer { get; set; }

    }

    public class ModelB2C
    {
        public string email { get; set; }

        public IEnumerable<identitie> identities { get; set; }

    }

    [ApiController]
    [Route("[controller]")]
    public class RolesController : ControllerBase
    {


        private readonly ILogger<RolesController> _logger;

        public RolesController(ILogger<RolesController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Return B2C Sample Json 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(ModelB2C model)
        {

            //if (model.identities.Where(_ => _.issuer == "6c53a6a6-6d07-4631-9573-965d4be679eb").Any())
            //{
            //    return Ok(new
            //    {
            //        version = "1.0.0",
            //        action = "Continue",
            //        extension_roles = "Read"
            //    });

            //}

            //if (model.identities.Where(_ => _.issuer == "university.soucheff.com.br").Any())
            //{
            //    return Ok(new
            //    {
            //        version = "1.0.0",
            //        action = "Continue",
            //        extension_roles = "Read"
            //    });

            //}

            //if (!model.email.Contains("university.soucheff.com.br"))
            //{
            //    return Ok(new
            //    {
            //        version = "1.0.0",
            //        action = "Continue",
            //        extension_roles = "Read"
            //    });

            //}soucheff.com.br
            return Ok(new
            {
                version = "1.0.0",
                action = "Continue",
                extension_roles = "Read"
            });

            //return Ok(new
            //{
            //    version = "1.0.0",
            //    action = "ShowBlockPage",
            //    userMessage = "There was a problem with your request. You are not able to sign up at this time."
            //});


        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {

                Roles = new string[] { "Read", "Write" }
            });
        }
    }
}