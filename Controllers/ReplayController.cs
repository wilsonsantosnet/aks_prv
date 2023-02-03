
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Sample.Controllers
{

    public class Model
    {

        public class DataModel
        {

            public string Type { get; set; }
            public string Operation { get; set; }
            public List<RevocationUser> RevocationUsers { get; set; }


        }

        public class RevocationUser
        {

            public string ActionDateTime { get; set; }
            public int Identification { get; set; }
            public string Name { get; set; }

        }

        public DataModel Data { get; set; }

    }


    [ApiController]
    [Route("[controller]")]
    public class ReplayController : Controller
    {

        private readonly ILogger<ReplayController> _logger;

        public ReplayController(ILogger<ReplayController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(Model model)
        {


            var dic = new Dictionary<string, string>();
            var problem = false;
            var bracklist = new string[] { "drop" };
            foreach (string name in dic.Keys)
            {
                foreach (var item in bracklist)
                {
                    if (dic[name].ToLower().Contains(item))
                    {
                        problem = true;
                        break;
                    }
                }
                
            }
                    





            return Ok(model);

        }
    }
}
