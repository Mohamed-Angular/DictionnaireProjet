using DictionnaireProject.Core.Interfaces;
using DictionnaireProject.Core.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using EX = DictionnaireProject.Core.Exceptions.Constants.MessagesConstantes;
namespace DictionnaireProject.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DictionnaireController : Controller
    {
        private readonly  IApiServices _iapitServices; 
        public DictionnaireController(IApiServices iapitServices)
        {
            _iapitServices = iapitServices; 
        }

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetDictionnary([Required, FromQuery] string keyFirst)
        {
            dynamic returnValue;
            if (keyFirst == null)
            {
                return BadRequest(EX.BAD_REQUEST_BAD_INPUT);
            }
          if(!Enum.IsDefined(typeof(KeyWordsInputsType), keyFirst) )
            {
                return BadRequest(EX.BAD_REQUEST_BAD_INPUT);

            }
            returnValue = await _iapitServices.GetWith1InputServices(keyFirst);
             

            return Ok(returnValue   );
        }
    }
}
