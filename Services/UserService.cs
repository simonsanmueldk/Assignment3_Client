using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Security.Claims;
using Assignment3.Data;
using Assignment3.Models;

namespace Assignment3.Services
{
    public class UserService : IUserService
    {
        private readonly IHttpClientFactory _clientFactory;

        public UserService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;

        }
        
        public async Task<User> ValidateUserAsync(string username, string password)
        {
            var parameters = new User()
            {
                UserName = username,
                Password = password
            };
            var httpClient = _clientFactory.CreateClient("webapi");
            HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(parameters), Encoding.UTF8, "application/json");

           HttpResponseMessage response = await httpClient.PostAsync($"User/Find", httpContent);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var jsonString = await response.Content.ReadAsStringAsync ().ConfigureAwait (false);
                User user = JsonConvert.DeserializeObject<User>(jsonString);
                return user;
            }
            return null;
        }
    }
}
