using Api.Infraestructure.Model;
using Microsoft.AspNetCore.Mvc;

namespace Api.Infraestructure.Common
{
    public class ManageResponseController : ControllerBase
    {
        public ActionResult<Response<T>> Evaluate<T>(Response<T> response)
        {
            return response.Errors != null && response.Errors.Any() ? BadRequest(response) : Ok(response);
        }
    }
}
