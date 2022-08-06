namespace SCA.UI
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txSearch = new System.Windows.Forms.TextBox();
            this.btnAddAsign = new System.Windows.Forms.Button();
            this.gbAsignaciones = new System.Windows.Forms.GroupBox();
            this.btnDeleteAsign = new System.Windows.Forms.Button();
            this.btnUpdateAsign = new System.Windows.Forms.Button();
            this.lbContext = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbAsignaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(840, 471);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txSearch
            // 
            this.txSearch.Location = new System.Drawing.Point(12, 62);
            this.txSearch.Name = "txSearch";
            this.txSearch.Size = new System.Drawing.Size(294, 20);
            this.txSearch.TabIndex = 1;
            this.txSearch.TextChanged += new System.EventHandler(this.txSearch_TextChanged);
            // 
            // btnAddAsign
            // 
            this.btnAddAsign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAsign.Location = new System.Drawing.Point(16, 27);
            this.btnAddAsign.Name = "btnAddAsign";
            this.btnAddAsign.Size = new System.Drawing.Size(117, 41);
            this.btnAddAsign.TabIndex = 2;
            this.btnAddAsign.Text = "Add";
            this.btnAddAsign.UseVisualStyleBackColor = true;
            this.btnAddAsign.Click += new System.EventHandler(this.btnAddAsign_Click);
            // 
            // gbAsignaciones
            // 
            this.gbAsignaciones.Controls.Add(this.btnDeleteAsign);
            this.gbAsignaciones.Controls.Add(this.btnUpdateAsign);
            this.gbAsignaciones.Controls.Add(this.btnAddAsign);
            this.gbAsignaciones.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbAsignaciones.Location = new System.Drawing.Point(435, 23);
            this.gbAsignaciones.Name = "gbAsignaciones";
            this.gbAsignaciones.Size = new System.Drawing.Size(417, 81);
            this.gbAsignaciones.TabIndex = 3;
            this.gbAsignaciones.TabStop = false;
            this.gbAsignaciones.Text = "Asignaciones";
            // 
            // btnDeleteAsign
            // 
            this.btnDeleteAsign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAsign.Location = new System.Drawing.Point(280, 27);
            this.btnDeleteAsign.Name = "btnDeleteAsign";
            this.btnDeleteAsign.Size = new System.Drawing.Size(117, 41);
            this.btnDeleteAsign.TabIndex = 2;
            this.btnDeleteAsign.Text = "Delete";
            this.btnDeleteAsign.UseVisualStyleBackColor = true;
            this.btnDeleteAsign.Click += new System.EventHandler(this.btnDeleteAsign_Click);
            // 
            // btnUpdateAsign
            // 
            this.btnUpdateAsign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateAsign.Location = new System.Drawing.Point(148, 27);
            this.btnUpdateAsign.Name = "btnUpdateAsign";
            this.btnUpdateAsign.Size = new System.Drawing.Size(117, 41);
            this.btnUpdateAsign.TabIndex = 2;
            this.btnUpdateAsign.Text = "Update";
            this.btnUpdateAsign.UseVisualStyleBackColor = true;
            this.btnUpdateAsign.Click += new System.EventHandler(this.btnUpdateAsign_Click);
            // 
            // lbContext
            // 
            this.lbContext.AutoSize = true;
            this.lbContext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContext.Location = new System.Drawing.Point(15, 94);
            this.lbContext.Name = "lbContext";
            this.lbContext.Size = new System.Drawing.Size(81, 24);
            this.lbContext.TabIndex = 8;
            this.lbContext.Text = "Context";
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Location = new System.Drawing.Point(12, 35);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(60, 20);
            this.lbSearch.TabIndex = 9;
            this.lbSearch.Text = "Search";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(19, 123);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh Table";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(305, 61);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(88, 23);
            this.btnClearSearch.TabIndex = 11;
            this.btnClearSearch.Text = "Clear Search";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 635);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.lbContext);
            this.Controls.Add(this.gbAsignaciones);
            this.Controls.Add(this.txSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbAsignaciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txSearch;
        private System.Windows.Forms.Button btnAddAsign;
        private System.Windows.Forms.GroupBox gbAsignaciones;
        private System.Windows.Forms.Button btnDeleteAsign;
        private System.Windows.Forms.Button btnUpdateAsign;
        private System.Windows.Forms.Label lbContext;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClearSearch;
    }
}