using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController : ControllerBase
    {

        public IActionResult Index()
        {
            return Content("Hello To Create File page"); ;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Content("Methode get");
        }

        [HttpGet("{id}")]
        public IActionResult Upload(IFormFile file)
        {
            return Content("Upload file "+ file.FileName); 
        }
    }
}
