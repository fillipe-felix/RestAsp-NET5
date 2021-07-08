using System;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestAspNET5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if (isNumeric(firstNumber) && isNumeric(secondNumber))
            {
                var sum = ConevertToDecimal(firstNumber) + ConevertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            
            return BadRequest("Invalid input");
        }
        
        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult Subtraction(string firstNumber, string secondNumber)
        {
            if (isNumeric(firstNumber) && isNumeric(secondNumber))
            {
                var subtraction = ConevertToDecimal(firstNumber) - ConevertToDecimal(secondNumber);
                return Ok(subtraction.ToString());
            }
            
            return BadRequest("Invalid input");
        }

        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(string firstNumber, string secondNumber)
        {
            if (isNumeric(firstNumber) && isNumeric(secondNumber))
            {
                var multiplication = ConevertToDecimal(firstNumber) * ConevertToDecimal(secondNumber);
                return Ok(multiplication.ToString());
            }
            
            return BadRequest("Invalid input");
        }
        
        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult Division(string firstNumber, string secondNumber)
        {
            if (isNumeric(firstNumber) && isNumeric(secondNumber))
            {
                var sum = ConevertToDecimal(firstNumber) / ConevertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            
            return BadRequest("Invalid input");
        }
        
        [HttpGet("mean/{firstNumber}/{secondNumber}")]
        public IActionResult Mean(string firstNumber, string secondNumber)
        {
            if (isNumeric(firstNumber) && isNumeric(secondNumber))
            {
                var mean = (ConevertToDecimal(firstNumber) + ConevertToDecimal(secondNumber)) / 2;
                return Ok(mean.ToString());
            }
            
            return BadRequest("Invalid input");
        }
        
        [HttpGet("square-root/{firstNumber}")]
        public IActionResult SquareRoot(string firstNumber)
        {
            if (isNumeric(firstNumber))
            {
                var squareRoot = Math.Sqrt((double)ConevertToDecimal(firstNumber));
                return Ok(squareRoot.ToString());
            }
            
            return BadRequest("Invalid input");
        }

        private bool isNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(strNumber, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out number);
            return isNumber;
        }
        
        private decimal ConevertToDecimal(string strNumber)
        {
            decimal decimalValue;

            if (decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }

        
    }
}