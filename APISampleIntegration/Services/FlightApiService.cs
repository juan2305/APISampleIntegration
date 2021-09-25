using APISampleIntegration.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace APISampleIntegration.Services
{
    public class FlightApiService : IFlightApiService
    {
        private const string ApiAccessKey = "876592c360msh2dbf5b49f00cdf7p150db8jsnc971a9d56da4";
       // private const string ApiAccessKey = "YOUR ACCESS KEY";
        public async Task<FlightResponse> GetFlightResponseAsync()
        {
           HttpClient httpClient = new HttpClient();
          var response = await httpClient.GetAsync($"https://rapidapi.com/Travelpayouts/api/flight-data?access_key={ApiAccessKey}");
       
          if (response.IsSuccessStatusCode)
            {
                var responseString = response.Content.ReadAsStringAsync();
                var flightResponse = JsonConvert.DeserializeObject<FlightResponse>(await responseString);
                return flightResponse;
            }
            return null;
        }

    }
}
