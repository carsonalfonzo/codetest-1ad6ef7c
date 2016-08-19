using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ImagineX.TenSubstring;

namespace ImagineX.TenSubstring.MVC.Controllers
{
    /// <summary>
    /// TenSubstringGeneratorController: WebApi controller for generating 10-Substrings
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class TenSubstringGeneratorController : ApiController
    {
        // GET: api/TenSubstringGenerator/5
        /// <summary>
        /// Gets all 10 substring friendly numbers for the given number
        /// </summary>
        /// <param name="inputNumber">User provided number</param>
        /// <returns></returns>
        [HttpGet]
        public IList<int> GetNumbers(int inputNumber)
        {

            TenSubstringCalculator calculator = new TenSubstringCalculator();
            calculator.InputNumber = inputNumber;
            return calculator.Generate(); 
        }

       
    }
}
