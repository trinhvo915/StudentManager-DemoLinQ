using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace StudentAPI.core.DataAccess.Repositories
{
    public class ResponseModel
    {
        public HttpStatusCode HttpStatusCode { get; set; }

        public object Data { get; set; }

        public string Message { get; set; }
    }
}
