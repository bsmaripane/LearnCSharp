using Microsoft.AspNetCore.Mvc;

namespace CarSalesStore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Car API is working!");
        }
    }
}