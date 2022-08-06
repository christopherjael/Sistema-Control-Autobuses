namespace SCA.UI.Forms
{
    partial class UIActualizarAsignaciones
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
            this.btnAddAutobus = new System.Windows.Forms.Button();
            this.btnAddRuta = new System.Windows.Forms.Button();
            this.btnAddChofer = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbRuta = new System.Windows.Forms.ComboBox();
            this.lbRuta = new System.Windows.Forms.Label();
            this.cbAutobus = new System.Windows.Forms.ComboBox();
            this.lbAutobus = new System.Windows.Forms.Label();
            this.cbChofer = new System.Windows.Forms.ComboBox();
            this.lbChofer = new System.Windows.Forms.Label();
            this.lbRutas = new System.Windows.Forms.Label();
            this.txId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddAutobus
            // 
            this.btnAddAutobus.Location = new System.Drawing.Point(195, 121);
            this.btnAddAutobus.Name = "btnAddAutobus";
            this.btnAddAutobus.Size = new System.Drawing.Size(22, 23);
            this.btnAddAutobus.TabIndex = 24;
            this.btnAddAutobus.Text = "+";
            this.btnAddAutobus.UseVisualStyleBackColor = true;
            this.btnAddAutobus.Click += new System.EventHandler(this.btnAddAutobus_Click);
            // 
            // btnAddRuta
            // 
            this.btnAddRuta.Location = new System.Drawing.Point(419, 122);
            this.btnAddRuta.Name = "btnAddRuta";
            this.btnAddRuta.Size = new System.Drawing.Size(22, 23);
            this.btnAddRuta.TabIndex = 25;
            this.btnAddRuta.Text = "+";
            this.btnAddRuta.UseVisualStyleBackColor = true;
            this.btnAddRuta.Click += new System.EventHandler(this.btnAddRuta_Click);
            // 
            // btnAddChofer
            // 
            this.btnAddChofer.Location = new System.Drawing.Point(418, 63);
            this.btnAddChofer.Name = "btnAddChofer";
            this.btnAddChofer.Size = new System.Drawing.Size(22, 23);
            this.btnAddChofer.TabIndex = 26;
            this.btnAddChofer.Text = "+";
            this.btnAddChofer.UseVisualStyleBackColor = true;
            this.btnAddChofer.Click += new System.EventHandler(this.btnAddChofer_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(244, 171);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 34);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(333, 171);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 34);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbRuta
            // 
            this.cbRuta.FormattingEnabled = true;
            this.cbRuta.Location = new System.Drawing.Point(241, 124);
            this.cbRuta.Name = "cbRuta";
            this.cbRuta.Size = new System.Drawing.Size(174, 21);
            this.cbRuta.TabIndex = 21;
            // 
            // lbRuta
            // 
            this.lbRuta.AutoSize = true;
            this.lbRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRuta.Location = new System.Drawing.Point(242, 105);
            this.lbRuta.Name = "lbRuta";
            this.lbRuta.Size = new System.Drawing.Size(35, 16);
            this.lbRuta.TabIndex = 20;
            this.lbRuta.Text = "Ruta";
            // 
            // cbAutobus
            // 
            this.cbAutobus.FormattingEnabled = true;
            this.cbAutobus.Location = new System.Drawing.Point(15, 123);
            this.cbAutobus.Name = "cbAutobus";
            this.cbAutobus.Size = new System.Drawing.Size(174, 21);
            this.cbAutobus.TabIndex = 19;
            // 
            // lbAutobus
            // 
            this.lbAutobus.AutoSize = true;
            this.lbAutobus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutobus.Location = new System.Drawing.Point(12, 104);
            this.lbAutobus.Name = "lbAutobus";
            this.lbAutobus.Size = new System.Drawing.Size(56, 16);
            this.lbAutobus.TabIndex = 18;
            this.lbAutobus.Text = "Autobus";
            // 
            // cbChofer
            // 
            this.cbChofer.FormattingEnabled = true;
            this.cbChofer.Location = new System.Drawing.Point(240, 65);
            this.cbChofer.Name = "cbChofer";
            this.cbChofer.Size = new System.Drawing.Size(174, 21);
            this.cbChofer.TabIndex = 17;
            // 
            // lbChofer
            // 
            this.lbChofer.AutoSize = true;
            this.lbChofer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChofer.Location = new System.Drawing.Point(241, 46);
            this.lbChofer.Name = "lbChofer";
            this.lbChofer.Size = new System.Drawing.Size(46, 16);
            this.lbChofer.TabIndex = 16;
            this.lbChofer.Text = "Chofer";
            // 
            // lbRutas
            // 
            this.lbRutas.AutoSize = true;
            this.lbRutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRutas.Location = new System.Drawing.Point(12, 9);
            this.lbRutas.Name = "lbRutas";
            this.lbRutas.Size = new System.Drawing.Size(116, 20);
            this.lbRutas.TabIndex = 15;
            this.lbRutas.Text = "Asignaciones";
            // 
            // txId
            // 
            this.txId.Enabled = false;
            this.txId.Location = new System.Drawing.Point(16, 65);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(174, 20);
            this.txId.TabIndex = 27;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(13, 46);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 16);
            this.lblId.TabIndex = 16;
            this.lblId.Text = "Id";
            // 
            // UIActualizarAsignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 219);
            this.Controls.Add(this.txId);
            this.Controls.Add(this.btnAddAutobus);
            this.Controls.Add(this.btnAddRuta);
            this.Controls.Add(this.btnAddChofer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbRuta);
            this.Controls.Add(this.lbRuta);
            this.Controls.Add(this.cbAutobus);
            this.Controls.Add(this.lbAutobus);
            this.Controls.Add(this.cbChofer);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lbChofer);
            this.Controls.Add(this.lbRutas);
            this.Name = "UIActualizarAsignaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UIActualizarAsignaciones";
            this.Load += new System.EventHandler(this.UIActualizarAsignaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAutobus;
        private System.Windows.Forms.Button btnAddRuta;
        private System.Windows.Forms.Button btnAddChofer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbRuta;
        private System.Windows.Forms.Label lbRuta;
        private System.Windows.Forms.ComboBox cbAutobus;
        private System.Windows.Forms.Label lbAutobus;
        private System.Windows.Forms.ComboBox cbChofer;
        private System.Windows.Forms.Label lbChofer;
        private System.Windows.Forms.Label lbRutas;
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.Label lblId;
    }
}