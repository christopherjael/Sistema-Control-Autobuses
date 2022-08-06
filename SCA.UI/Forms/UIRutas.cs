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
    public partial class UIRutas : Form
    {
        public UIRutas()
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

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Fields Required");
            }
            else
            {
                var ruta = new RutasBL();
                var newRuta = ruta.AddRutas(nombre);
                if(newRuta == 1)
                {
                    MessageBox.Show("Ruta Created");
                }
                else
                {
                    MessageBox.Show("Ruta cant be created");
                }
            }
        }
    }
}
