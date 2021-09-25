using APISampleIntegration.Models;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Globalization;
using Xamarin.Essentials;

namespace APISampleIntegration.Services
{
    public class FlightApiService : IFlightApiService
    {
        private const string ApiAccessKey = "54584c8325755dc2dbad7aadad6df16a";

        // private const string ApiAccessKey = "YOUR ACCESS KEY";
        public async Task<FlightResponse> GetFlightInfoAsync()
        {
           HttpClient httpClient = new HttpClient();
          var response = await httpClient.GetAsync($"https://api.travelpayouts.com/v2/prices/latest?currency=usd&period_type=year&page=1&limit=30&show_to_affiliates=true&sorting=price&trip_class=0&token={ApiAccessKey}");  
        
            if(response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                var flightResponse = JsonConvert.DeserializeObject<FlightResponse>(responseString);
                return flightResponse;
            }
            return null;
        }
      
}
}
