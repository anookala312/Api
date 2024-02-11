using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [Route("{x}/{y}")]

        public decimal Add( decimal x, decimal y){   
                decimal sum = x+y;
                return sum;
        }
        
        public decimal Subtract( decimal x, decimal y){   
                decimal sub = x-y;
                return sub;
        }
        
        public decimal Multiply( decimal x, decimal y){   
                decimal multiply = x*y;
                return multiply;
        }
        public decimal Divide( decimal x, decimal y){   
                decimal divisor = x/y;
                return divisor;
        }
        public decimal Modulo( decimal x, decimal y){   
                decimal reminder = x%y;
                return reminder;
        }

    }
}
