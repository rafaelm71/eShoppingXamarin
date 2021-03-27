using eShoppingXamarin;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static eShoppingXamarin.Models.Name;

namespace ApiXamarin.Services
{
    public class IngredientAnalysisApiService : IIngredientAnalysisApiService
    {
        
        public async Task<IngredientAnalysis> GetIngredientAnalysisAsync()
        {
            IngredientAnalysis retVal = null;
            HttpClient client = new HttpClient();
            var IngredientAnalysisResponse = await client.GetAsync("https://world.openfoodfacts.org/ingredients-analysis.json");
            if (IngredientAnalysisResponse.IsSuccessStatusCode)
            {
                var jsonPayload = await IngredientAnalysisResponse.Content.ReadAsStringAsync();
                retVal = JsonSerializer.Deserialize<IngredientAnalysis>(jsonPayload);
            }
            return retVal;
           
           
        }
    }
}
