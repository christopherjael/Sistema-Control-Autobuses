namespace SCA.UI.Forms
{
    partial class UIAutobuses
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
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.lbModelo = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbRutas = new System.Windows.Forms.Label();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.lbAño = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(185, 67);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(153, 20);
            this.tbModelo.TabIndex = 21;
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModelo.Location = new System.Drawing.Point(186, 48);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(53, 16);
            this.lbModelo.TabIndex = 20;
            this.lbModelo.Text = "Modelo";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(260, 231);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 35);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(167, 231);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 35);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(12, 67);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(153, 20);
            this.tbMarca.TabIndex = 17;
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.Location = new System.Drawing.Point(13, 48);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(45, 16);
            this.lbMarca.TabIndex = 15;
            this.lbMarca.Text = "Marca";
            // 
            // lbRutas
            // 
            this.lbRutas.AutoSize = true;
            this.lbRutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRutas.Location = new System.Drawing.Point(12, 9);
            this.lbRutas.Name = "lbRutas";
            this.lbRutas.Size = new System.Drawing.Size(95, 20);
            this.lbRutas.TabIndex = 16;
            this.lbRutas.Text = "Autobuses";
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlaca.Location = new System.Drawing.Point(13, 103);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(42, 16);
            this.lbPlaca.TabIndex = 22;
            this.lbPlaca.Text = "Placa";
            // 
            // tbPlaca
            // 
            this.tbPlaca.Location = new System.Drawing.Point(12, 122);
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(153, 20);
            this.tbPlaca.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Color";
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(185, 122);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(151, 21);
            this.cbColor.TabIndex = 25;
            this.cbColor.Text = "Chosee the color";
            // 
            // lbAño
            // 
            this.lbAño.AutoSize = true;
            this.lbAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAño.Location = new System.Drawing.Point(13, 159);
            this.lbAño.Name = "lbAño";
            this.lbAño.Size = new System.Drawing.Size(31, 16);
            this.lbAño.TabIndex = 26;
            this.lbAño.Text = "Año";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 178);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 20);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // UIAutobuses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 288);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbAño);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPlaca);
            this.Controls.Add(this.lbPlaca);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.lbModelo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbRutas);
            this.Name = "UIAutobuses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Autobuses";
            this.Load += new System.EventHandler(this.UIAutobuses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbRutas;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.TextBox tbPlaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label lbAño;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}