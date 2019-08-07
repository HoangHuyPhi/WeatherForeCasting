using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace WeatherForeCasting
{
    // Creating RestService to make an API request 
    public class RestService
    {
        HttpClient client;

        public RestService()
        {

            client = new HttpClient();
        }

        public async Task<WeatherData> GetWeatherData(String query)
        {
            WeatherData result = null;
            try
            {
                var response = await client.GetAsync(query);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<WeatherData>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\t\tERROR {0}", ex.Message);
            }
            return result;
        }
    }
}
