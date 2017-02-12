using HotDogs.Mobile.Exceptions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotDogs.Mobile.Services
{
    public class BaseHttpProvider
    {
        protected string _baseUrl;

        protected HttpClient GetClient()
        {
            return GetClient(_baseUrl);
        }

        protected HttpClient GetClient(string baseUrl)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Add("accept", "application/json");

            return client;
        }

        protected async Task<T> Get<T>(string url)
        {
            using (HttpClient client = GetClient())
            {
                try
                {
                    var response = await client.GetAsync(url);

                    if (!response.IsSuccessStatusCode)
                    {
                        var error = await response.Content.ReadAsAsync<HotDogsApiException>();
                        var message = error != null ? error.Message : "Response Error";
                        throw new HotDogsApiException(message, response.StatusCode);
                    }

                    return await response.Content.ReadAsAsync<T>();
                }
                catch(HttpRequestException ex)
                {
                    throw new HotDogsApiException("Request Fail", false, ex);
                }
                catch(UnsupportedMediaTypeException ex)
                {
                    throw new HotDogsApiException("Unsupported Media Type", false, ex);
                }
            }
        }
    }
}
