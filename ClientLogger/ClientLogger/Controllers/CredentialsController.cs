using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace ClientLogger.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CredentialsController : Controller
    {
        
        [HttpGet]
        public Task<IActionResult> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
