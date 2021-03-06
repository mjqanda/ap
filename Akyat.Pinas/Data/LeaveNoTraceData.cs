using System;
using System.Net.Http;
using System.Threading.Tasks;
using Akyat.Pinas.Models;
using Newtonsoft.Json;

namespace Akyat.Pinas.Data
{
    class LeaveNoTraceData
    {
        const string url = "https://ia601507.us.archive.org/10/items/mountainsData/LeaveNoTraceData.json";
        private static LeaveNoTrace _leaveNoTraces = new LeaveNoTrace();

        public LeaveNoTraceData()
        {
            Task.Run(() => this.LoadDataAsync(url)).Wait();
        }

        private async Task LoadDataAsync(string uri)
        {
            if (_leaveNoTraces != null)
            {

                string responseJsonString = null;

                using (var httpClient = new HttpClient())
                {
                    try
                    {
                        Task<HttpResponseMessage> getResponse = httpClient.GetAsync(uri);

                        HttpResponseMessage response = await getResponse;

                        responseJsonString = await response.Content.ReadAsStringAsync();
                        _leaveNoTraces = JsonConvert.DeserializeObject<LeaveNoTrace>(responseJsonString);
                    }
                    catch (Exception ex)
                    {
                        string message = ex.Message;
                    }
                }

            }
        }
        public LeaveNoTrace GetLeaveNoTraceData()
        {
            return _leaveNoTraces;
        }
    }
}