using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ImagineX.TenSubstring;

namespace ImagineX.TenSubstring.MVC.Controllers
{
    public class TenSubstringGeneratorController : ApiController
    {
        // GET: api/TenSubstringGenerator/5
        [HttpGet]
        public IList<int> GetNumbers(int inputNumber)
        {

            TenSubstringCalculator calculator = new TenSubstringCalculator();
            calculator.InputNumber = inputNumber;
            return calculator.Generate(); //.ToArray().ToString();
        }

       
    }
}
