using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BenDan.Api.Cozntrollers
{
    [Route("api/values")]
    public class ValuesController:Controller
    {
        public IActionResult Get()
        {
            return Ok("Hello,Word!");
        }
    }
}
