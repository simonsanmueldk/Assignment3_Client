using Microsoft.JSInterop;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Assignment3.Data;
using Assignment3.Models;

namespace Assignment3.Services
{
    public class AdultService : IAdultService
    {
        private readonly HttpClient httpClient;
        private readonly IJSRuntime jsRuntime;
        private User cachedUser;

        public AdultService(IJSRuntime jsRuntime, IHttpClientFactory clientFactory)
        {
            httpClient = clientFactory.CreateClient("webapi");
            this.jsRuntime = jsRuntime;
        }
        
        private async Task<string> GetAuthentication(IJSRuntime jsRuntime)
        {
            string result = string.Empty;
            try
            {
                if (cachedUser == null)
                {
                    string userAsJson = await jsRuntime.InvokeAsync<string>("sessionStorage.getItem", "currentUser");
                    cachedUser = JsonConvert.DeserializeObject<User>(userAsJson);
                }
                result = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{cachedUser.UserName}:{cachedUser.Password}"));
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }
        
        public async Task AddAdultAsync(Adult adultToAdd)
        {
            try
            {
                string authentication = await GetAuthentication(jsRuntime);
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", authentication);

                var data = new StringContent(JsonConvert.SerializeObject(adultToAdd), Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync($"Adult/AddAdult", data);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    //Success
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task DeleteAdult(Adult adultToDelete)
        {
            string authentication = await GetAuthentication(jsRuntime);
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", authentication);
            var data = new StringContent(JsonConvert.SerializeObject(adultToDelete), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync($"Adult/DeleteAdult", data);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                //Success
            }
        }

        public async Task<IList<Adult>> ReadAllAdults()
        {
            List<Adult> result = null;
          
            try
            {
                var response = await httpClient.GetAsync("Adult/All");
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string responseJson = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    result = JsonConvert.DeserializeObject<List<Adult>>(responseJson);
                    //Success
                }
                return result;

            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public async Task UpdateAdult(Adult adultToUpdate)
        {
            string authentication = await GetAuthentication(jsRuntime);
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", authentication);
            var data = new StringContent(JsonConvert.SerializeObject(adultToUpdate), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync($"Adult/UpdateAdult", data);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                //Success
            }
        }
    }

}
