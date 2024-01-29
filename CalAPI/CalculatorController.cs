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

        public int Addition( int x, int y){   
                int sum = x+y;
                return sum;
        }
        
        public int Substraction( int x, int y){   
                int sub = x-y;
                return sub;
        }
        
        public int Muntiplication( int x, int y){   
                int multiply = x*y;
                return multiply;
        }

    }
}
