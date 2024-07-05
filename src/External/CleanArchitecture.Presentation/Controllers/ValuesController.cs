using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public sealed class ValuesController: ControllerBase
    {
        [HttpGet]
        public IActionResult Get() 
        {
            return Ok("Deneme api işlemi başarılı!");
        }

    }
}
