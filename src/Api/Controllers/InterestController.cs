using Core.Services.Interfaces;
using Core.Settings.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FeeCalculator.Controllers
{
    [ApiController]
    public class InterestController : ControllerBase
    {
        public readonly IInterestService _interestService;
        private readonly double _interestValue;

        public InterestController(IInterestService feeService, IEnvironmentSettings settings)
        {
            _interestService = feeService;
            _interestValue = settings.Interest;
        }

        [HttpGet("/taxa")]
        public IActionResult GetInterestValue()
        {
            return Ok(_interestValue);
        }

        [HttpGet("/calculajuros")]
        public IActionResult CalculateAmount([FromQuery] decimal valorInicial, [FromQuery] int meses)
        {
            try
            {
                return Ok(_interestService.Calculate(valorInicial, _interestValue, meses));
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
