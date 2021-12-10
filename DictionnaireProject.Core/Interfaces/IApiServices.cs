using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DictionnaireProject.Core.Interfaces
{
     
        public interface IApiServices
        {
                Task<object> GetWith1InputServices(string keyFirst);
              
        }
    
}
