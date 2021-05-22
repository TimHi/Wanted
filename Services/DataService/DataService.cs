using System;
using System.Net.Http;
using System.Threading.Tasks;
using Services.DataService.FBIAPI;

namespace Services.DataService
{
    /// <summary>
    /// https://api.fbi.gov/docs#/
    /// </summary>
    public class DataService : IDataService
    {
        public DataService()
        {
        }

        private async Task<string> PerformCloudRequestAsync()
        {
            var client = new HttpClient { BaseAddress = new Uri(Config.BaseURL) };

            var req = new HttpRequestMessage(HttpMethod.Get, Config.WantedEndpoint);

            var resp = await client.SendAsync(req);
            resp.EnsureSuccessStatusCode();

            var allReviews = await resp.Content.ReadAsStringAsync();
            return "";
        }

        public async Task GetFullList(int page)
        {
            string result = await PerformCloudRequestAsync();
        }
    }
}
