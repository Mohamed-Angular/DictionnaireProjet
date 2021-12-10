using System;
using System.Collections.Generic;

using System.Text;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.Serialization;
namespace DictionnaireProject.Core.Exceptions
{
   public class TechnicalException : Exception
    {
        public string ErrorMessage { get; }
        public HttpStatusCode HttpStatusCode { get; }
        public TechnicalException(string message, HttpStatusCode httpStatusCode)
           : base(message)
        {
            ErrorMessage = message;
            HttpStatusCode = httpStatusCode;
        }
    }
}
