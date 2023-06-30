using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApp.HttpClientApi;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpClientApiService _httpClientApiService;
        private string API_TODOS_USUARIOS = ConfigurationManager.AppSettings["API_TODOS_USUARIOS"];
        public async Task<ActionResult> IndexAsync()
        {
            object bodyModel = new object() { };
            var list = _httpClientApiService.Request<EmployeesResponse>(API_TODOS_USUARIOS, bodyModel, "GET");

            return View(list);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}