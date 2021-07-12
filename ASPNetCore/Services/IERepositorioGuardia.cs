using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendasDF.Models;

namespace ASPNetCore.Services
{
    public interface IERepositorioGuardia
    {
        IEnumerable<Guardia> ObtenerGuardias();
    }
}
