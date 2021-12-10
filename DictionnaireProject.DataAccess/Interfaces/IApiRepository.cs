using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DictionnaireProject.DataAccess.Interfaces
{
    public interface IApiRepository
    {
        Task<object> GetWith1Input(string keyFirst);
    }
}
