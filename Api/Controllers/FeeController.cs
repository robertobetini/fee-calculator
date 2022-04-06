using Core.Services.Interfaces;
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
        public readonly IFeeService _feeService;
        private readonly double _fee = 0.01;

        public FeeController(IFeeService feeService)
        {
            _feeService = feeService;
        }

        [HttpGet("/taxa")]
        public IActionResult GetFee()
        {
            return Ok(_fee);
        }

        [HttpGet("/calculajuros")]
        public IActionResult CalculateFee([FromQuery] decimal valorInicial, [FromQuery] int meses)
        {
            try
            {
                return Ok(_feeService.Calculate(valorInicial, _fee, meses));
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        [HttpGet("/showmethecode")]
        public IActionResult GetRepositoryUrl()
        {
            return Ok("https://github.com/robertobetini/fee-calculator");
        }
    }
}
