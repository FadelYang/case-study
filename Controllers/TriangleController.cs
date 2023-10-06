using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace case_study.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class TriangleController : ControllerBase
    {
        private readonly ITriangleService _triangleService;

        public TriangleController(ITriangleService triangleService)
        {
            _triangleService = triangleService;
        }

        // Equilateral Triangle, has 3 equals side
        // Isoceles Triangle, has 2 equals side
        // Scalene Triangle, has no equals side
        [HttpGet("typeOfTriangle")]
        public ActionResult<string> TypeOfTriangle(double firstSide, double secondSide, double thirdSide)
        {
            string triangleType = _triangleService.DetermineTypeOfTriangle(firstSide, secondSide, thirdSide);

            return $"It's {triangleType} triangle";
        }
    }
}