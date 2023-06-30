using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Infraestructure.Model
{
    public class GenericError<T>
    {
        public static Response<T> ExceptionMessage()
        {
            return new()
            {
                Errors = new List<Error>() { new() { Message = "Ha ocurrido un error procesando la solicitud" } }
            };
        }
        public static Response<T> UpdateElementNotFound() 
        {
            return new()
            {
                Errors = new List<Error>() { new() { Message = "El elemento que esta intentando actualizar no existe" } }
            };
        }
    }
}
