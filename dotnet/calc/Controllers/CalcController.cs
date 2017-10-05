using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace calc.Controllers
{
    [Produces("application/json")]
    [Route("api/calc")]
    public class CalcController : Controller
    {
        // GET api/calc/Add
        [Route("Add")]
        [HttpGet]
        public double Add([FromQueryAttribute] double a, [FromQueryAttribute] double b)
        {
            return a + b;
        }

        // GET api/calc/Subtract
        [Route("Subtract")]
        [HttpGet]
        public double Subtract([FromQueryAttribute] double a, [FromQueryAttribute] double b)
        {
            return a - b;
        }

        // GET api/calc/Multiply
        [Route("Multiply")]
        [HttpGet]
        public double Multiply([FromQueryAttribute] double a, [FromQueryAttribute] double b)
        {
            return a * b;
        }

        // GET api/calc/Divide
        [Route("Divide")]
        [HttpGet]
        public double Divide([FromQueryAttribute] double a, [FromQueryAttribute] double b)
        {
            return a / b;
        }
    }
}
