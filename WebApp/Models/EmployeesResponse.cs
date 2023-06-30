using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApp.Models
{

    public class EmployeesResponse
    {
        [JsonPropertyName("status")] 
        public string Status { get; set; } = null;
        [JsonPropertyName("data")]
        public Datum[] Data { get; set; } = null;
        [JsonPropertyName("message")] 
        public string Message { get; set; } = null;
    }

    public class Datum
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("employee_name")]
        public string Employee_name { get; set; } = null;
        [JsonPropertyName("employee_salary")]
        public int Employee_salary { get; set; }
        [JsonPropertyName("employee_age")]
        public int Employee_age { get; set; }
        [JsonPropertyName("profile_image")]
        public string Profile_image { get; set; } = null;
    }

}
