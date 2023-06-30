using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Api.Infraestructure.Model
{
    public class DataModel
    {
        public string Status { get; set; } = null!;
        public string Data { get; set; } = null!;
        public string Message { get; set; } = null!;
    }
}
