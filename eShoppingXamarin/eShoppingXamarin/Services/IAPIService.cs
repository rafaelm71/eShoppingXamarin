using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eShopping.Models;

namespace eShoppingXamarin.Services
{
    public interface IAPIService
    {
        Task<Language> GetLanguageAsync();
    }
}
