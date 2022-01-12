using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DictionnaireProject.DataAccess.Interfaces
{
    public interface IApiRepository<T>
    {
        Task<T> GetWith1Input(String keyFirst);
    }
}
