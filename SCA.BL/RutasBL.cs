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
    public class RutasBL
    {
        
        public Rutas GetRutaById(int rutaId)
        {
            var rutaRepository = new RutasRepository();
            var ruta = rutaRepository.GetRutaById(rutaId);
            return ruta;
        }

        public List<Rutas> GetAllRutas()
        {
            var rutaRepository = new RutasRepository();
            var rutasList = rutaRepository.GetAllRutas();
            return rutasList;
        }

        public List<Rutas> GetAllRutasFree()
        {
            var rutaRepository = new RutasRepository();
            var rutasList = rutaRepository.GetAllRutasFree();
            return rutasList;
        }

        public int AddRutas(string nombre)
        {
            nombre = nombre.Trim();
            var ruta = new Rutas()
            {
                Nombre = nombre
            };

            var rutaRepository = new RutasRepository();
            var result = rutaRepository.AddRutas(ruta);
            return result;
        }

        public int UpdateRuta(int rutaId, string nombre)
        {
            var rutaRepository = new RutasRepository();

            var rutas = new Rutas()
            {
                RutaId = rutaId,
                Nombre = nombre
            };
            var result = rutaRepository.UpdateRuta(rutas);
            return result;
        }

        public int DeleteRuta(int rutaId)
        {
            var rutaRepository = new RutasRepository();
            var ruta = new Rutas()
            {
                RutaId=rutaId
            };
            var result = rutaRepository.DeleteRuta(ruta);
            return result;
        }
    }
}
