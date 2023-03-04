using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GarantiApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class GarantiBankController : ControllerBase
    {
        [HttpGet("{musteriId}")]
        public double Bakiye(int musteriId)
        {
            //....
            return 1000;
        }
        [HttpGet("{musteriId}")]
        public List<string> TumHesaplar(int musteriId)
        {
            //....
            return new()
        {
            "123456789",
            "987654321",
            "564738291"
        };
        }
    }
}
