using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendasDF.Models;

namespace ASPNetCore.Models
{
    public class ViewModel
    {      
            public IEnumerable<JefeArea> Jefe { get; set; }
            public IEnumerable<Guardia> Guardia { get; set; }
            public IEnumerable<Cajero> Cajero { get; set; }        
    }
}
