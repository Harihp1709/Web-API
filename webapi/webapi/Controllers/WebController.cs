using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Controllers
{
    [Route("[controller]")]   
    public class WebController : ControllerBase
    {

        private static List<string> studentnames = new List<string> { "hari", "sujith", "sasi" ,"abc", "def"};

        [HttpGet]
        
        public IEnumerable<string> GetNames()
        {
            return studentnames;
        }
       

    }
}
