using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCA.Entity
{
    public class AsignacionesVW
    {
        public int AsingnacionId { get; set; }
        public int ChoferId { get; set; }
        public string Chofer { get; set; }
        public string Cedula { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int AutobusId { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Color { get; set; }
        public string Año { get; set; }
        public int RutaId { get; set; }
        public string Nombre_Ruta { get; set; }
    }
}
