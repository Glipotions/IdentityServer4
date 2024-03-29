﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HalkBankApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class HalkBankController : ControllerBase
    {
        [HttpGet("{musteriID}")]
        public double Bakiye(int musteriId)
        {
            //....
            return 500.15;
        }
        [HttpGet("{musteriID}")]
        public List<string> TumHesaplar(int musteriId)
        {
            //....
            return new()
            {
                "135792468",
                "019283745",
                "085261060"
            };
        }
    }
}
