using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendasDF.Models;

namespace ASPNetCore.Services
{
    public class JefeRepositorioEnMemoria : IERepositorioJefe
    {
        public IEnumerable<JefeArea> ObtenerJefes()
        {
            JefeArea[] jefes = new JefeArea[]
            {
            new JefeArea {id=1 ,nombre="Juan" ,apellidoPaterno="Jimenes" ,apellidoMaterno="Prada" ,rut=146515093 ,horasTrabajadas=62 ,mesesAntiguedad=80 ,bono=true , area="Bodega", tamanioEquipo=2},
            new JefeArea {id=2 ,nombre="Andres" ,apellidoPaterno="Garcia" ,apellidoMaterno="Peña" ,rut=598157242 ,horasTrabajadas=48 ,mesesAntiguedad=55 ,bono=true ,area="Administracion", tamanioEquipo=3},
            new JefeArea {id=3 ,nombre="Laura" ,apellidoPaterno="Nieto" ,apellidoMaterno="Duran" ,rut=344817866 ,horasTrabajadas=29 ,mesesAntiguedad=45 ,bono=true ,area="Tienda", tamanioEquipo=5}
            };
            return jefes;
        }
    }
}
