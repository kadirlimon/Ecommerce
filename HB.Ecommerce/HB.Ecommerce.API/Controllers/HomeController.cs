using HB.Ecommerce.Domain.SeedWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using UdemyApiWithToken.Domain.Response;

namespace HB.Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

       
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "HB Api Started...";
        }

        [HttpPost("increasetime/{hour}")]
        public BaseResponse<DateTime> IncreaseTime(int hour)
        {
            SystemTime.IncreaseTime(hour);
            return new BaseResponse<DateTime> { Data = SystemTime.Now, Success = true };
        }

    }
}
