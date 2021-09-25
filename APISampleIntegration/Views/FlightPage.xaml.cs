using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using APISampleIntegration.Models;

namespace APISampleIntegration.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlightPage : ContentPage
    {
        public FlightPage()
        {
            InitializeComponent();
        }
       
        private async void Button_Clicked(object sender, EventArgs e)
        {
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri("https://api.travelpayouts.com/v2/prices/latest?currency=usd&period_type=year&page=1&limit=30&show_to_affiliates=true&sorting=price&trip_class=0&token=54584c8325755dc2dbad7aadad6df16a");
            request.Method = HttpMethod.Get;
            request.Headers.Add("Accept", "aplication/json");
            var client = new HttpClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<FlightDatum>>(content);
                FlightList.ItemsSource = result;
            }
           
          
        }
    }
}