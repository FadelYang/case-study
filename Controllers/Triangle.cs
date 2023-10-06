using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace case_study.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TriangleController : ControllerBase
    {
        [HttpGet]
        public string GetHelloTriangle()
        {
            return $"Hello Triangle";
        }
    }
}