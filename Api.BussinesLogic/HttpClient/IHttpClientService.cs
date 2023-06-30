using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Api.BussinesLogic.HttpClient
{
    public interface IHttpClientService
    {
        Task<string> SendRequest(HttpWebRequest request, string body);
    }
}
