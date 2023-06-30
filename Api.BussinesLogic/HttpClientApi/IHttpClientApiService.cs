using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.BussinesLogic.HttpClientApi
{
    public interface IHttpClientApiService
    {
        Task<TEntity?> Request<TEntity>(string url, object data, string method);
    }
}
