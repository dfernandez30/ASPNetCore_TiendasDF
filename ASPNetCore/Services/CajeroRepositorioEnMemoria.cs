using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendasDF.Models;


namespace ASPNetCore.Services
{
    public class CajeroRepositorioEnMemoria : IERepositorioCajero
    {
        public IEnumerable<Cajero> ObtenerCajeros()
        {
            Cajero[] cajeros = new Cajero[]
            {
            new Cajero {id=1 ,nombre="Luis" ,apellidoPaterno="Aguayo" ,apellidoMaterno="Gonzalez" ,rut=123045649 ,horasTrabajadas=50 ,mesesAntiguedad=30 ,bono=true , numeroCaja=2 ,turno="mañana"},
            new Cajero {id=2 ,nombre="Juan" ,apellidoPaterno="Herrera" ,apellidoMaterno="Cortes" ,rut=215293072 ,horasTrabajadas=30 ,mesesAntiguedad=20 ,bono=true , numeroCaja=5 ,turno="tarde"},
            new Cajero {id=3 ,nombre="Pedro" ,apellidoPaterno="Estrada" ,apellidoMaterno="Campos" ,rut=245821648 ,horasTrabajadas=40 ,mesesAntiguedad=15 ,bono=false , numeroCaja=9 ,turno="tarde"},
            new Cajero {id=4 ,nombre="Paty" ,apellidoPaterno="Farias" ,apellidoMaterno="Muñoz" ,rut=144590748 ,horasTrabajadas=35 ,mesesAntiguedad=9 ,bono=true , numeroCaja=4 ,turno="mañana"},
            };
            return cajeros;
        }
    }
}
