 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using DictionnaireProject.DataAccess.Constants.Api;
using DictionnaireProject.DataAccess.Constants.Standards;

using System.Net;
using DictionnaireProject.DataAccess.Interfaces;
using DictionnaireProject.DataAccess.Exceptions;
using DictionnaireProject.DataAccess.Exceptions.Constants;
using Newtonsoft.Json.Linq;

namespace DictionnaireProject.DataAccess.Repositories
{
   public class DataRepository : IApiRepository
    {
        public async Task<object> GetWith1Input(string keyFirst)
        {
            try
            {
                string apiResponse;
                var returnData = new List<object>();
                string url = Apis.ApiUrlData;
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync(url + keyFirst))
                    {
                          apiResponse = await response.Content.ReadAsStringAsync();
                      
                    }
                }
                return apiResponse;
            }
            catch (Exception ex)
            {
                 throw new TechnicalException(MessagesConstantes.MessageErrorReading, HttpStatusCode.BadRequest);
            }
        }
    }
}
