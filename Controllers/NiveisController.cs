using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Sample_api_users.Controllers
{
    /// <summary>
    /// Devolve informações do Dispositivo
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class NiveisController : ControllerBase
    {

        [HttpGet]
        public IActionResult Index()
        {


            return Ok(
                new List<dynamic> {

                    new {id= 1,dataAtualizacao = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss"), href="https://backend-ws.azurewebsites.net/api/person/10"},
                    new {id= 2,dataAtualizacao = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss"), href="https://backend-ws.azurewebsites.net/api/person/11"},
                    new {id= 3,dataAtualizacao = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss"), href="https://backend-ws.azurewebsites.net/api/person/12"},
                }
            );
        }

    }
}
