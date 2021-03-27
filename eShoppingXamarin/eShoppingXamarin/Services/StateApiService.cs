using eShoppingXamarin.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace Xamapi.Services
{
    public class StateApiService: IStateApiService
    {
       
        public async Task<StateInfo> GetStateAsync()
        {
            StateInfo retVal = null;

            HttpClient client = new HttpClient();
            var stateResponse=  await client.GetAsync("https://world.openfoodfacts.org/states.json");

            if (stateResponse.IsSuccessStatusCode)
            {
                var jsonPayLoad = await stateResponse.Content.ReadAsStringAsync();
                retVal = JsonSerializer.Deserialize<StateInfo>(jsonPayLoad); 
            }
            return retVal;
        }
    }
}
