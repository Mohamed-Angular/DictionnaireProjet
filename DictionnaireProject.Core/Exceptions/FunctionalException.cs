using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace DictionnaireProject.Core.Exceptions
{
    public class FunctionalException : Exception
    {
        
        public string ErrorMessage { get; }
        public HttpStatusCode HttpStatusCode { get; }
        public FunctionalException(string message , HttpStatusCode httpStatusCode)
           : base(message)
        {
            ErrorMessage = message; 
            HttpStatusCode = httpStatusCode;
        }
    }
}
