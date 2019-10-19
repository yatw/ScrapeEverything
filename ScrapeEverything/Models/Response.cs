using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScrapeEverything.Models
{
    public class Response
    {

        public IDictionary<int, string> codeTable = new Dictionary<int, string>();
        public int code;
        public string message;

        public string html;

        public Response(int code = 0)
        {
            this.code = code;
            codeTable.Add(0, "Error: Missing information");
            codeTable.Add(1, "Success");
            codeTable.Add(2, "Error: Invalid Url");
            codeTable.Add(3, "Error: Cannot Find Login Fields");
        }

        public Response setCode(int code)
        {
            this.code = code;
            this.message = codeTable[code];
            return this;
        }
    }
}