using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebApp.HttpClient;
using WebApp.HttpClientApi;
using WebApp.Model;

namespace WebApp.HttpClientApiService
{
    public class HttpClientApiService : IHttpClientApiService
    {
        private readonly IHttpClientService _httpClientService;
        private readonly ILogger<HttpClientApiService> _logger;
        public HttpClientApiService(IHttpClientService httpClientService, ILogger<HttpClientApiService> logger)
        { 
            _httpClientService = httpClientService;
            _logger = logger;
        }
        public async Task<TEntity> Request<TEntity>(string url, object data, string method)
        {
                JsonSerializerOptions serializerOptions = new JsonSerializerOptions()
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    WriteIndented = false
                };

                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;

                request.Method = method;


                string dataJson = data == null ? "" : JsonSerializer.Serialize(data, serializerOptions);

                DataModel dataModel = new DataModel()
                {
                    Data = dataJson
                };

                string dataModelJson = JsonSerializer.Serialize(dataModel, serializerOptions);

                string Response = await _httpClientService.SendRequest(request, dataModelJson);
                var dataResponse = JsonSerializer.Deserialize<TEntity>(Response, serializerOptions);
                TEntity responseObj = dataResponse;
                return responseObj;           
        }
    }
}
