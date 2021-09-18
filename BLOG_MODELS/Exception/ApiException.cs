using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace BLOG_MODELS.Exception
{
    class ApiException
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
