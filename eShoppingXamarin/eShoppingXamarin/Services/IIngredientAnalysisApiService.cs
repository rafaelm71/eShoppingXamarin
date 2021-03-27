using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static eShoppingXamarin.Models.Name;

namespace eShoppingXamarin
{
    public interface IIngredientAnalysisApiService
    {
        Task<IngredientAnalysis> GetIngredientAnalysisAsync();
        
    }
}
