namespace SCA.UI.Forms
{
    partial class UIChoferes
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRutas = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.lbApellido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.mtbCedula = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(249, 196);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 35);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(156, 196);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 35);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(12, 69);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(153, 20);
            this.tbNombre.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // lbRutas
            // 
            this.lbRutas.AutoSize = true;
            this.lbRutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRutas.Location = new System.Drawing.Point(12, 11);
            this.lbRutas.Name = "lbRutas";
            this.lbRutas.Size = new System.Drawing.Size(57, 20);
            this.lbRutas.TabIndex = 5;
            this.lbRutas.Text = "Rutas";
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(185, 69);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(153, 20);
            this.tbApellido.TabIndex = 10;
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.Location = new System.Drawing.Point(186, 50);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(57, 16);
            this.lbApellido.TabIndex = 9;
            this.lbApellido.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fecha Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cedula";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.CustomFormat = "mm-dd-yyyy";
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpFechaNac.Location = new System.Drawing.Point(16, 140);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(149, 20);
            this.dtpFechaNac.TabIndex = 13;
            // 
            // mtbCedula
            // 
            this.mtbCedula.Location = new System.Drawing.Point(185, 143);
            this.mtbCedula.Mask = "000-0000000-0";
            this.mtbCedula.Name = "mtbCedula";
            this.mtbCedula.Size = new System.Drawing.Size(153, 20);
            this.mtbCedula.TabIndex = 14;
            // 
            // UIChoferes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 248);
            this.Controls.Add(this.mtbCedula);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbRutas);
            this.Name = "UIChoferes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choferes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRutas;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.MaskedTextBox mtbCedula;
    }
}