using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Api.BussinesLogic.HttpClient
{
    public class HttpClientService : IHttpClientService
    {
        public async Task<string> SendRequest(HttpWebRequest request, string body)
        {
            if (request.Method != "GET")
            {
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(body);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
            using var httpResponse = (HttpWebResponse)(await request.GetResponseAsync());
            using var reader = new StreamReader(httpResponse.GetResponseStream());
            return reader.ReadToEnd();
        }
    }
}
