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
    public class AutobusesBL
    {
        public Autobuses GetAutobusById(int autobusId)
        {
            var autobusRepository = new AutobusesRepository();
            var autobus = autobusRepository.GetAutobusById(autobusId);
            return autobus;
        }
        public List<Autobuses> GetAllAutobuses()
        {
            var autobusRepository = new AutobusesRepository();
            var autobusList = autobusRepository.GetAllAutobuses();
            return autobusList;
        }

        public List<Autobuses> GetAllAutobusesFree()
        {
            var autobusRepository = new AutobusesRepository();
            var autobusList = autobusRepository.GetAllAutobusesFree();
            return autobusList;
        }

        public int AddAutobuse(string marca, string modelos, string placa, string color, string año)
        {
            marca = marca.Trim();
            modelos = modelos.Trim();
            placa = placa.Trim().ToUpper();

            var autobus = new Autobuses()
            {
                Marca = marca,
                Modelo = modelos,
                Placa = placa,
                Color = color,
                Año = año
            };
            var autobusRepository = new AutobusesRepository();
            var result = autobusRepository.AddAutobuse(autobus);
            return result;
        }

        public int UpdateAutobuse(int autobusId, string marca, string modelo, string placa, string color, string año)
        {
            var autobusRepository = new AutobusesRepository();
            var autobus = new Autobuses()
            {
                AutobusId = autobusId,
                Marca = marca,
                Modelo = modelo,
                Placa = placa,
                Color = color,
                Año = año,
            };
            var result = autobusRepository.UpdateAutobuse(autobus);
            return result;
        }

        public int DeleteAutobuse(int autobusId)
        {
            var autobusRepository = new AutobusesRepository();
            var autobus = new Autobuses()
            {
                AutobusId=autobusId,
            };
            var result = autobusRepository.DeleteAutobuse(autobus);
            return result;
        }
    }
}
