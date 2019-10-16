using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ScrapeEverything.Controllers
{
    public class ScrapeController : ApiController
    {


        // GET api/scrape/url
        // https://localhost:44315/api/scrape?url=https%3A%2F%2Fwww.novaragnarok.com%2F%3Fmodule%3Dvending%26action%3Ditem%26id%3D7620
        public string Get(string url)
        {
            return "You sent: "+url;
        }
    }
}
