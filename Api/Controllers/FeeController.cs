using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeeCalculator.Controllers
{
    [ApiController]
    public class FeeController : ControllerBase
    {
        [HttpGet("/taxa")]
        public double GetFee()
        {
            return 0.1;
        }

        [HttpGet("/calculajuros")]
        public double CalculateFee()
        {
            return 0.1;
        }

        [HttpGet("/showmethecode")]
        public string GetRepositoryUrl()
        {
            return "https://github.com/robertobetini/fee-calculator";
        }
    }
}
