using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        public string Test(string param){
            return String.Concat("Hello ", param);
        }
        public string Get(){
            return "Get Method";
        }

    }
}
