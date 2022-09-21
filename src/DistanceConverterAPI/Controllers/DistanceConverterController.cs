using Microsoft.AspNetCore.Mvc;

namespace DistanceConverterAPI.Controllers
{
    [ApiController]
    [Route("distance-converter")]
    public class DistanceConverterController : ControllerBase
    {
       private readonly ILogger<DistanceConverterController> _logger;

        public DistanceConverterController(ILogger<DistanceConverterController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("to-kilometer")]
        public string ConvertToKilometer(double miles)
        {
            var kilometer = DistanceConverter.ToKilometers(miles);
            return $"{kilometer} km";
        }

        [HttpGet]
        [Route ("to-miles")]
        public string ConvertToMiles(double kilometer)
        {
            var miles = DistanceConverter.ToMiles(kilometer);
            return $"{miles} mile(s)";
        }
    }
}