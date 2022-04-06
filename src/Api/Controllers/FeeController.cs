using Core.Services.Interfaces;
using Core.Settings.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FeeCalculator.Controllers
{
    [ApiController]
    public class FeeController : ControllerBase
    {
        public readonly IFeeService _feeService;
        private readonly double _feeValue;

        public FeeController(IFeeService feeService, IEnvironmentSettings settings)
        {
            _feeService = feeService;
            _feeValue = settings.Fee;
        }

        [HttpGet("/taxa")]
        public IActionResult GetFee()
        {
            return Ok(_feeValue);
        }

        [HttpGet("/calculajuros")]
        public IActionResult CalculateFee([FromQuery] decimal valorInicial, [FromQuery] int meses)
        {
            try
            {
                return Ok(_feeService.Calculate(valorInicial, _feeValue, meses));
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
