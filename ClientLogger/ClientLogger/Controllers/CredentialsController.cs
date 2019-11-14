using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientLogger.Implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace ClientLogger.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CredentialsController : Controller
    {
        public IClientLoggerBLC blc { get; set; }
        public CredentialsController(IClientLoggerBLC blc)
        {
            this.blc = blc;
        }
        
        [HttpPost]
        public async Task<IActionResult> Get([FromBody] ClientInfo credential)
        {
            return Ok(await blc.LogInformation(new ClientInfo()));
        }
    }
}
