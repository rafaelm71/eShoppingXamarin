using eShoppingXamarin.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Xamapi.Services
{
    public interface IStateApiService
    {
        Task<StateInfo> GetStateAsync();
         
    }

}
