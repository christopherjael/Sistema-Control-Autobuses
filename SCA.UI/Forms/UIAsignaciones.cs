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

namespace SCA.UI.Forms
{
    public partial class UIAsignaciones : Form
    {
        public UIAsignaciones()
        {
            InitializeComponent();
        }

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

        private void UIAsignaciones_Load(object sender, EventArgs e)
        {
            ReloadComboBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var atb = Convert.ToInt32(cbAutobus.SelectedValue.ToString().Split('-')[0]);
            var cfr = Convert.ToInt32(cbChofer.SelectedValue.ToString().Split('-')[0]);
            var rt = Convert.ToInt32(cbRuta.SelectedValue.ToString().Split('-')[0]);

            var newAsignacion = new AsignacionesBL().AddAsignacion(cfr, atb, rt);
            if (newAsignacion == 1)
            {
                MessageBox.Show("Asignacion Created");
                ReloadComboBox();
            }
            else
            {
                MessageBox.Show("Asignacion cant be created");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddChofer_Click(object sender, EventArgs e)
        {
            new UIChoferes().ShowDialog();
            ReloadComboBox();
        }

        private void btnAddRuta_Click(object sender, EventArgs e)
        {
            new UIRutas().ShowDialog();
            ReloadComboBox();
        }

        private void btnAddAutobus_Click(object sender, EventArgs e)
        {
            new UIAutobuses().ShowDialog();
            ReloadComboBox();
        }
    }
}
