using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EntryFlowEvents.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Exemplo de Get";
        }

        [HttpPost]
        public string post()
        {
            return "Exemplo de post";
        }

        [HttpPut]
        public string Put()
        {
            return "Exemplo de Put";
        }

        [HttpDelete]
        public string Delete()
        {
            return "Exemplo de Delete";
        }
    }
}
