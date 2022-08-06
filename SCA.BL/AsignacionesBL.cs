using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCA.Entity;
using SCA.DL.Repositories;
using SCA.DL;
using System.Data.SqlClient;

namespace SCA.BL
{
    public class AsignacionesBL
    {
        public List<AsignacionesVW> Populate(string search)
        {
            var asignacionRepository = new AsignacionesRepository();
            var asignacion = asignacionRepository.Populate(search);
            return asignacion;
        }
        public Asignaciones GetAsignacionById(int asignacionId)
        {
            var asignacionRepository = new AsignacionesRepository();
            var asignacion = asignacionRepository.GetAsignacionById(asignacionId);
            return asignacion;
        }
        public List<Asignaciones> GetAllAsignaciones()
        {
            var asignacionRepository = new AsignacionesRepository();
            var asignacionesList = asignacionRepository.GetAllAsignaciones();
            return asignacionesList;
        }

        public List<AsignacionesVW> GetAllAsignacionesVW()
        {
            var asignacionRepository = new AsignacionesRepository();
            var asignacionesList = asignacionRepository.GetAllAsignacionesVW();
            return asignacionesList;
        }

        public int AddAsignacion(int choferId, int autobusId, int rutaId)
        {
            var asignacionRepository = new AsignacionesRepository();
            var asignacion = new Asignaciones()
            {
                ChoferId = choferId,
                AutobusId = autobusId,
                RutaId = rutaId
            };
            var asignacionesList = asignacionRepository.AddAsignacion(asignacion);
            return asignacionesList;
        }

        public int UpdateAsignacion(int asignacionId, int choferId, int autobusId, int rutaId)
        {
            var asignacionRepository = new AsignacionesRepository();
            var asignacion = new Asignaciones()
            {
                AsingnacionId = asignacionId,
                ChoferId = choferId,
                AutobusId = autobusId,
                RutaId = rutaId
            };
            var asignacionesList = asignacionRepository.UpdateAsignacion(asignacion);
            return asignacionesList;
        }

        public int DeleteAsignacion(int asignacionId)
        {
            var asignacionRepository = new AsignacionesRepository();
            var asignacion = new Asignaciones()
            {
                AsingnacionId = asignacionId,
            };
            var asignacionesList = asignacionRepository.DeleteAsignacion(asignacion);
            return asignacionesList;
        }
    }
}
