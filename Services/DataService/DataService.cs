using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Services.DataService.FBIAPI;
using Services.DataService.FBIAPI.Model;

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
            //TODO: https://stackoverflow.com/questions/19704432/await-httpclient-sendasynchttpcontent-is-non-responsive
            //Fix blocking
            var resp = client.SendAsync(req).Result;
            resp.EnsureSuccessStatusCode();
            //https://stackoverflow.com/a/25542532 TODO: Parse somewhre
            var content = await resp.Content.ReadAsStringAsync();
            return content;
        }

        public async Task<List<Person>> GetFullList(int page)
        {
            var resultList = new List<Person>();
            var result = await PerformCloudRequestAsync();
            dynamic WantedList = JsonConvert.DeserializeObject(result);
            var personList = WantedList["items"];
            if(personList != null)
            {
                foreach(var jsonPerson in personList)
                {
                    Person p = new Person(url: url, age_range: age_range, uid: uid, weight: weight, hair: hair,
                        ncic: ncic, caution: caution, title: title, images: images);
                    resultList.Add(p);
                }
            }
            return resultList;
        }
    }
}
