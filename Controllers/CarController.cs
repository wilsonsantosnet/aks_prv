using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Sample_api_users.Controllers
{

    public class ModelCar {

        [Required]
        [JsonProperty(PropertyName = "Id")]
        public int Id { get; set; }
        public string Marca { get; set; }

    }

    /// <summary>
    /// Devolve informações do Dispositivo
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {

        [HttpGet]
        public IActionResult Index([FromQueryAttribute] ModelCar model)
        {
            return Ok(model);
        }

    }
}
