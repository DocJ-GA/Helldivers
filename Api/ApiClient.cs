using Helldivers.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Helldivers.Api
{
    public class ApiClient
    {
        public string XSuperClient { get; set; } = string.Empty;
        public string XSuperContact { get;set; } = string.Empty;

        protected const string _url = "https://api.helldivers2.dev/";
        protected HttpClient _httpClient;

        public ApiClient(string xSuperClient, string xSuperContact)
        {
            XSuperClient = xSuperClient;
            XSuperContact = xSuperContact;
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            _httpClient.DefaultRequestHeaders.Add("X-Super-Client", XSuperClient);
            _httpClient.DefaultRequestHeaders.Add("X-Super-Contact", XSuperContact);
        }

        public async Task<Planet> GetPlanet(int index)
        {
            return (await _httpClient.GetFromJsonAsync<Planet>(_url + "api/v1/planets/" + index))!;
        }
    }
}
