using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UtilityLibraries;

namespace MyApp.Namespace

{
    [Route("[controller]/[action]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly CalLibrary calLibrary;

        public CalculatorController()
        {
            calLibrary = new CalLibrary();
        }

        [Route("{x}/{y}")]
        public decimal Add(decimal x, decimal y)
        {
            return calLibrary.Add(x, y);
        }

        public decimal Subtract(decimal x, decimal y)
        {
            return calLibrary.Subtract(x, y);
        }

        public decimal Multiply(decimal x, decimal y)
        {
            return calLibrary.Multiply(x, y);
        }

        public decimal Divide(decimal x, decimal y)
        {
            return calLibrary.Divide(x, y);
        }

        public decimal Modulo(decimal x, decimal y)
        {
            return calLibrary.Modulo(x, y);
        }
    }
}
