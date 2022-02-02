using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gitplayapi.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            throw new NotImplementedException();
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult Add()
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public IActionResult Update()
        {
            throw new NotImplementedException();
        }
    }
}
