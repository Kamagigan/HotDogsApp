using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HotDogs.Mobile.Exceptions
{
    public class HotDogsApiException : Exception
    {
        public HttpStatusCode StatusCode { get; set; }

        public bool Connection { get; set; }

        public HotDogsApiException(string message, HttpStatusCode statusCode) : base(message)
        {
            StatusCode = statusCode;
            Connection = true;
        }

        public HotDogsApiException(string message, bool connection, Exception innerException) : base(message, innerException)
        {
            Connection = connection;
            StatusCode = HttpStatusCode.ServiceUnavailable;
        }
    }
}
