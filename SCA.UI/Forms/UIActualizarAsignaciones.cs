using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCA.BL;
using SCA.Entity;

namespace SCA.UI.Forms
{
    public partial class UIActualizarAsignaciones : Form
    {
        #region PROPIEDADES
        int AsignacionId;
        int ChoferId;
        int AutobusId;
        int RutaId;
        #endregion

        #region METODOS
        private void ReloadComboBox()
        {
            var ruta = new RutasBL();
            var chofer = new ChoferesBL();
            var autobus = new AutobusesBL();
            var asingacion = new AsignacionesBL();

            var rutaList = ruta.GetAllRutasFree();
            var choferList = chofer.GetAllChoferesFree();
            var autobusList = autobus.GetAllAutobusesFree();

            var choferes = choferList.Select(a => a.ChoferId + "- " + a.Nombre + "," + a.Apellido);
            var autobuses = autobusList.Select(a => a.AutobusId + "- " + a.Placa);
            var rutas = rutaList.Select(a => a.RutaId + "- " + a.Nombre);

            cbChofer.DataSource = choferes.ToList();
            cbAutobus.DataSource = autobuses.ToList();
            cbRuta.DataSource = rutas.ToList();
        }
        #endregion
        public UIActualizarAsignaciones(int asignacionId, int choferId, int autobusId, int rutaId)
        {
            InitializeComponent();
            this.AsignacionId = asignacionId;
            this.ChoferId = choferId;
            this.AutobusId = autobusId;
            this.RutaId = rutaId;
        }

        private void UIActualizarAsignaciones_Load(object sender, EventArgs e)
        {

            // Bussiness 
            var choferBL = new ChoferesBL();
            var autobusBL = new AutobusesBL();
            var rutaBl = new RutasBL();

            // Obteniendo la ruta, chofer y autobus seleccionados para actualizar
            var choferSelected = choferBL.GetChoferById(this.ChoferId);
            var autobusSelected = autobusBL.GetAutobusById(this.AutobusId);
            var rutaSelected = rutaBl.GetRutaById(this.RutaId);

            // Bussiness 2
            var choferBL2 = new ChoferesBL();
            var autobusBL2 = new AutobusesBL();
            var rutaBl2 = new RutasBL();

            // Obteniendo los choferes, rutas y autobuses libres de asignacion
            var choferes = choferBL2.GetAllChoferesFree();
            var autobuses = autobusBL2.GetAllAutobusesFree();
            var rutas = rutaBl2.GetAllRutasFree();

            // Agregando la ruta, chofer y autobus seleccionado en la lista
            choferes.Insert(0, choferSelected);
            autobuses.Insert(0, autobusSelected);
            rutas.Insert(0, rutaSelected);

            // obteniedo solo los (ids, nombres) de las rutas, choferes y autobuese libre de asignacion
            var choferesQuery = choferes.Select(c => c.ChoferId + "- " + c.Nombre).ToList();
            var autobusesQuery = autobuses.Select(a => a.AutobusId + "- " + a.Placa).ToList();
            var rutasQuery = rutas.Select(r => r.RutaId + "- " + r.Nombre).ToList();

            
            // Estableciendo el origen de dato para los comboBoxs
            cbChofer.DataSource = choferesQuery;
            cbAutobus.DataSource = autobusesQuery;
            cbRuta.DataSource = rutasQuery;

            // Estableciendo el id de la asignacion a textBox (Asignacion Id)
            txId.Text = Convert.ToString(this.AsignacionId);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAutobus_Click(object sender, EventArgs e)
        {
            new UIAutobuses().ShowDialog();
            ReloadComboBox();
        }

        private void btnAddRuta_Click(object sender, EventArgs e)
        {
            new UIRutas().ShowDialog();
            ReloadComboBox();
        }

        private void btnAddChofer_Click(object sender, EventArgs e)
        {
            new UIChoferes().ShowDialog();
            ReloadComboBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var asignacionBL = new AsignacionesBL();

            var atb = Convert.ToInt32(cbAutobus.SelectedValue.ToString().Split('-')[0]);
            var cfr = Convert.ToInt32(cbChofer.SelectedValue.ToString().Split('-')[0]);
            var rt = Convert.ToInt32(cbRuta.SelectedValue.ToString().Split('-')[0]);

            var result = asignacionBL.UpdateAsignacion(this.AsignacionId, cfr, atb, rt);
            if (result == 1)
            {
                MessageBox.Show("Asignacion Updated");
                this.Close();

            }
            else
            {
                MessageBox.Show("Error to update");
                this.Close();
            }
        }
    }
}
