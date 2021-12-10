using DictionnaireProject.Core.Exceptions;
using DictionnaireProject.Core.Interfaces;
using DictionnaireProject.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DictionnaireProject.Core.Model
{
  public  class DataServices : IApiServices  
    {
        private readonly IApiRepository _iapitRepository;
        public DataServices(IApiRepository iapitRepository)
        {
            _iapitRepository = iapitRepository;
        }
        public async Task<object> GetWith1InputServices(string keyFirst)
        {
            if (null == keyFirst)
            {
                throw new FunctionalException(Exceptions.Constants.MessagesConstantes.MessageErrorReading,  HttpStatusCode.BadRequest);
            }
            return await  _iapitRepository.GetWith1Input(keyFirst);
        }

 
    }
}
