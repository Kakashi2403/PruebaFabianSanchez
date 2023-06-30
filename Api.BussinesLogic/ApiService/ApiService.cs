
using Api.BussinesLogic.HttpClientApi;
using Api.BussinesLogic.Model;
using Api.BussinesLogic.Models;
using Api.Infraestructure.Model;
using Microsoft.Extensions.Logging;

namespace Api.BussinesLogic.ApiService
{
    public class ApiService : IApiService
    {
        private readonly IHttpClientApiService _httpClientApiService;
        private readonly ILogger<ApiService> _logger;
        public ApiService(IHttpClientApiService httpClientApi, ILogger<ApiService> logger)
        { 
            _httpClientApiService = httpClientApi;
            _logger = logger;
        }

        public async Task<Response<EmployeesResponse>> GetEmployees()
        {
            try
            {
                object bodyModel = new object() { };
                var list = await _httpClientApiService.Request<EmployeesResponse>("https://dummy.restapiexample.com/api/v1/employees", bodyModel, "GET");

                Response<EmployeesResponse> response = new()
                {
                    Body = list
                };
                return response;
            }
            catch (Exception ex) 
            {
                _logger.LogError("{ex}", ex);
                return GenericError<EmployeesResponse>.ExceptionMessage();
            }
        }

        public async Task<Response<EmployeesResponse>> GetEmployeesId(int Id)
        {
            try
            {
                object bodyModel = new object() { };

                var list = await _httpClientApiService.Request<EmployeesResponse>("https://dummy.restapiexample.com/api/v1/employees/" + Id, bodyModel, "GET");

                Response<EmployeesResponse> response = new()
                {
                    Body = list
                };
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError("{ex}", ex);
                return GenericError<EmployeesResponse>.ExceptionMessage();
            }
        }
    }
}
