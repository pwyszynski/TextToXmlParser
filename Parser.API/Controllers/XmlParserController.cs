using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Parser.Utils;

namespace Parser.API.Controllers
{
    [Route("api/[controller]")]
    public class XmlParserController : Controller
    {
        [HttpPost("[action]")]
        public string ParseSentence([FromBody] string inputText)
        {
            return XMLParser.ParseText(inputText);
        }
    }
}