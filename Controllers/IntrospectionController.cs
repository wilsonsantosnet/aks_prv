﻿
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Sample.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class IntrospectionController : Controller
    {

        private readonly ILogger<IntrospectionController> _logger;

        public IntrospectionController(ILogger<IntrospectionController> logger)
        {
            _logger = logger;
        }

       
        [HttpPost]
        public IActionResult Post()
        {

            return Ok(new
            {
                tokenGuid = Guid.NewGuid().ToString(),
                attr = new
                {
                    value = "teste json object"
                }
            });

        }
    }
}
