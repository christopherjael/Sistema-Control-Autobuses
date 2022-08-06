using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCA.Entity;
using SCA.BL;

namespace SCA.UI.Forms
{
    public partial class UIChoferes : Form
    {
        public UIChoferes()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var nombre = tbNombre.Text;
            var apellido = tbApellido.Text;
            var fechaNac = dtpFechaNac.Value;
            var cedula = mtbCedula.Text;

            if(string.IsNullOrWhiteSpace(nombre) || 
                string.IsNullOrEmpty(nombre) || 
                string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrEmpty(apellido) || 
                mtbCedula.MaskCompleted || 
                mtbCedula.Text == string.Empty)
            {
                MessageBox.Show("Fields Requiered");
            }else
            {
                var chofer = new ChoferesBL();
                var newChofer = chofer.AddChoferes(nombre, apellido, fechaNac, cedula);
                if (newChofer == 1)
                {
                    MessageBox.Show("Chofer Created");
                }
                else
                {
                    MessageBox.Show("Chofer cant be created");
                }
            } 
        }
    }
}
