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
using SCA.UI.Forms;

namespace SCA.UI
{
    public partial class Menu : Form
    {
        DataGridViewRow selectedRow;
        public Menu()
        {
            InitializeComponent();
        }

        private void ReloadDataSource()
        {
            selectedRow = null;
            var asignacionBL = new AsignacionesBL();
            var asignacionesList = asignacionBL.GetAllAsignacionesVW();
            dataGridView1.DataSource = asignacionesList;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lbContext.Text = "Asignaciones";
            ReloadDataSource();
        }

        private void btnAddAsign_Click(object sender, EventArgs e)
        {
            new UIAsignaciones().ShowDialog();
            ReloadDataSource();
        }

        private void btnUpdateAsign_Click(object sender, EventArgs e)
        {
            if (selectedRow == null)
            {
                MessageBox.Show("Select a row");
                return;
            }
            else
            {
                var asignacionBL = new AsignacionesBL();
                int asignacionId = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                int choferId = Convert.ToInt32(selectedRow.Cells[1].Value.ToString());
                int autobusId = Convert.ToInt32(selectedRow.Cells[5].Value.ToString());
                int rutaId = Convert.ToInt32(selectedRow.Cells[11].Value.ToString());

                new UIActualizarAsignaciones(asignacionId, choferId, autobusId, rutaId).ShowDialog();
                ReloadDataSource();
            };

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            selectedRow = dataGridView1.Rows[idx];
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReloadDataSource();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txSearch.Clear();
        }

        private void btnDeleteAsign_Click(object sender, EventArgs e)
        {
            if (selectedRow == null)
            {
                MessageBox.Show("Select a row");
                return;
            }
            else
            {

                const string message = "Are you sure that you want deleted this row?";
                const string caption = "Delete row";
                DialogResult dialogResult = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                // If the no button was pressed ...
                if (dialogResult == DialogResult.Yes)
                {
                    var asignacionBL = new AsignacionesBL();
                    int asignacionId = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                    var result = asignacionBL.DeleteAsignacion(asignacionId);

                    if (result == 1)
                    {
                        MessageBox.Show("Asignacion Deleted");
                    }
                    else
                    {
                        MessageBox.Show("Error to Delete");
                    }

                    ReloadDataSource();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }

            };
        }

        private void txSearch_TextChanged(object sender, EventArgs e)
        {
            var asignacionesBL  = new AsignacionesBL();
            var asignacionesVWList = asignacionesBL.Populate(txSearch.Text);
            dataGridView1.DataSource = asignacionesVWList;
        }
    }
}
