using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace case_study.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class TriangleController : ControllerBase
    {
        [HttpGet("helloTriangle")]
        public string GetHelloTriangle()
        {
            return $"Hello Triangle";
        }

        // Equilateral Triangle, has 3 equals side
        // Isoceles Triangle, has 2 equals side
        // Scalene Triangle, has no equals side
        [HttpGet("typeOfTriangle")]
        public ActionResult<string> TypeOfTriangle(double firstSide, double secondSide, double thirdSide)
        {
            if ((firstSide == secondSide) && (firstSide == thirdSide))
            {
                return $"It's equilateral triangle";
            }
            else if ((firstSide == secondSide) || (firstSide == thirdSide) || (secondSide == thirdSide))
            {
                return $"It's isoceles triangle";
            }
            else
            {
                return $"It's scalene triangle";
            }
        }
    }
}