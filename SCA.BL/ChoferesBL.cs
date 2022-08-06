using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCA.Entity;
using SCA.DL;
using SCA.DL.Repositories;
using System.Data.SqlClient;

namespace SCA.BL
{
    public class ChoferesBL
    {

        public Choferes GetChoferById(int choferId)
        {
            var choferesRepository = new ChoferesRepository();
            var chofer = choferesRepository.GetChoferById(choferId);
            return chofer;

        }
        public List<Choferes> GetAllChoferesFree()
        {
            var chofereRepository = new ChoferesRepository();
            var choferesList = chofereRepository.GetAllChoferesFree();
            return choferesList;
        }

        public int AddChoferes(string nombre, string apellido, DateTime fecheNacimiento, string cedula)
        {
            nombre = nombre.Trim();
            apellido = apellido.Trim();
            var choferesRepository = new ChoferesRepository();
            var chofer = new Choferes()
            {
                Nombre = nombre,
                Apellido = apellido,
                FechaNacimiento = fecheNacimiento,
                Cedula = cedula
            };
            var choferesList = choferesRepository.AddChoferes(chofer);
            return choferesList;
        }
    }
}
