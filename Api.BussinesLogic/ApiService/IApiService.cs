using Api.BussinesLogic.Model;
using Api.Infraestructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.BussinesLogic.ApiService
{
    public interface IApiService
    {
        Task<Response<EmployeesResponse>> GetEmployees();
        Task<Response<EmployeesResponse>> GetEmployeesId(int Id);
    }
}
