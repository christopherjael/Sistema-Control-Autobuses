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
    public partial class UIAutobuses : Form
    {
        public UIAutobuses()
        {
            InitializeComponent();
        }

        private void ReloadComboBox()
        {
            var autobus = new AutobusesBL().GetAllAutobuses();
            var colors = autobus.Select( a => a.Color).Distinct();
            cbColor.DataSource = colors.ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UIAutobuses_Load(object sender, EventArgs e)
        {
            ReloadComboBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var marca = tbMarca.Text;
            var modelo = tbModelo.Text;
            var placa = tbPlaca.Text;
            var color = Convert.ToString(cbColor.SelectedValue);
            var año = Convert.ToString(dateTimePicker1.Value);

            if (string.IsNullOrEmpty(marca) ||
                string.IsNullOrWhiteSpace(marca) ||
                string.IsNullOrEmpty(modelo) ||
                string.IsNullOrWhiteSpace(placa) ||
                string.IsNullOrEmpty(placa) ||
                color == "Chosee the color" ||
                año.Length != 7)
            {
                MessageBox.Show("Fields Required");
            }
            else
            {
                var autobus = new AutobusesBL();
                var newAutobus = autobus.AddAutobuse(marca, modelo, placa, color, año);
                if (newAutobus == 1)
                {
                    MessageBox.Show("Autobus Created");
                }
                else
                {
                    MessageBox.Show("Autobus cant be created");
                }
            }
        }
    }
}
