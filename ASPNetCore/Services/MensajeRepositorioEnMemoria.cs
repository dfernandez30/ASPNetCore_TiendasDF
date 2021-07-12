using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore.Services
{
    public class MensajeRepositorioEnMemoria : IERepositorioMensaje
    {
        public List<string> ObtenerTodo()
        {
            List<string> objetos = new List<string>() { "pan", "queso", "carne" };
            return objetos;
        }
    }
}
