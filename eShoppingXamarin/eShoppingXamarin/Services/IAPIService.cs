using System;
using System.Collections.Generic;
using System.Text;
using eShoppingXamarin.Models;
using System.Threading.Tasks;


namespace eShoppingXamarin.Services
{
    public interface IAPIService
    {
        Task<Language> GetLanguageAsync();
    }
}
