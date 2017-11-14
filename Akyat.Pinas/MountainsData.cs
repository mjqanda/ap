using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace Akyat.Pinas
{
    public class MountainsData
    {
        const string url = "https://ia601507.us.archive.org/10/items/mountainsData/mountainsData.json";
        private static List<Mountain> Mountains = new List<Mountain>();
        public MountainsData()
        {
            Task.Run(() => this.LoadDataAsync(url)).Wait();
        }
        private async Task LoadDataAsync(string uri)
        {
            if (Mountains != null)
            {
                string responseJsonString = null;

                using (var httpClient = new HttpClient())
                {
                    try
                    {
                        Task<HttpResponseMessage> getResponse = httpClient.GetAsync(uri);

                        HttpResponseMessage response = await getResponse;

                        responseJsonString = await response.Content.ReadAsStringAsync();
                        Mountains = JsonConvert.DeserializeObject<List<Mountain>>(responseJsonString);
                    }
                    catch (Exception ex)
                    {
                        string message = ex.Message;
                    }
                }
            }
        }
        public List<Mountain> GetAllMountains()
        {
            IEnumerable<Mountain> mountainsss = (Mountains.OrderBy(mountain => mountain.MtName)).ToList<Mountain>();
            return mountainsss.ToList<Mountain>();
        }

        public List<Mountain> GetData()
        {
            return Mountains;
        }
    }
}

        
