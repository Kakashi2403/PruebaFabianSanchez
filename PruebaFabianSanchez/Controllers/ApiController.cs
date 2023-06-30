using Api.BussinesLogic.ApiService;
using Api.BussinesLogic.Model;
using Api.Infraestructure.Common;
using Api.Infraestructure.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ManageResponseController
    {
        private readonly IApiService _apiService;
        public ApiController(IApiService apiService)
        {
            _apiService = apiService;
        }
        [HttpGet("GetAll")]
        [ProducesResponseType(typeof(Response<EmployeesResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<EmployeesResponse>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Response<EmployeesResponse>>> Get()
        {
            return Evaluate(await _apiService.GetEmployees());
        }
        [HttpPost("{id}")]
        [ProducesResponseType(typeof(Response<EmployeesResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<EmployeesResponse>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Response<EmployeesResponse>>> GetId(int id)
        {
            return Evaluate(await _apiService.GetEmployeesId(id));
        }
    }
}
