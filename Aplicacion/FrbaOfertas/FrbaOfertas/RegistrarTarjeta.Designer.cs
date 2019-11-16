namespace FrbaOfertas
{
    partial class RegistrarTarjeta
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
            this.panelAgregarTarjeta = new System.Windows.Forms.Panel();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.dateTimePickerFechaVenc = new System.Windows.Forms.DateTimePicker();
            this.textBoxCVV = new System.Windows.Forms.TextBox();
            this.textBoxBanco = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelAgregarTarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAgregarTarjeta
            // 
            this.panelAgregarTarjeta.Controls.Add(this.buttonLimpiar);
            this.panelAgregarTarjeta.Controls.Add(this.dateTimePickerFechaVenc);
            this.panelAgregarTarjeta.Controls.Add(this.textBoxCVV);
            this.panelAgregarTarjeta.Controls.Add(this.textBoxBanco);
            this.panelAgregarTarjeta.Controls.Add(this.comboBoxTipo);
            this.panelAgregarTarjeta.Controls.Add(this.textBoxNumero);
            this.panelAgregarTarjeta.Controls.Add(this.buttonAceptar);
            this.panelAgregarTarjeta.Controls.Add(this.label6);
            this.panelAgregarTarjeta.Controls.Add(this.label5);
            this.panelAgregarTarjeta.Controls.Add(this.label4);
            this.panelAgregarTarjeta.Controls.Add(this.label3);
            this.panelAgregarTarjeta.Controls.Add(this.label2);
            this.panelAgregarTarjeta.Location = new System.Drawing.Point(34, 47);
            this.panelAgregarTarjeta.Name = "panelAgregarTarjeta";
            this.panelAgregarTarjeta.Size = new System.Drawing.Size(316, 224);
            this.panelAgregarTarjeta.TabIndex = 5;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(200, 189);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 13;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFechaVenc
            // 
            this.dateTimePickerFechaVenc.Location = new System.Drawing.Point(121, 156);
            this.dateTimePickerFechaVenc.Name = "dateTimePickerFechaVenc";
            this.dateTimePickerFechaVenc.Size = new System.Drawing.Size(183, 20);
            this.dateTimePickerFechaVenc.TabIndex = 12;
            // 
            // textBoxCVV
            // 
            this.textBoxCVV.Location = new System.Drawing.Point(66, 121);
            this.textBoxCVV.Name = "textBoxCVV";
            this.textBoxCVV.Size = new System.Drawing.Size(198, 20);
            this.textBoxCVV.TabIndex = 11;
            // 
            // textBoxBanco
            // 
            this.textBoxBanco.Location = new System.Drawing.Point(66, 87);
            this.textBoxBanco.Name = "textBoxBanco";
            this.textBoxBanco.Size = new System.Drawing.Size(198, 20);
            this.textBoxBanco.TabIndex = 10;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Credito",
            "Debito"});
            this.comboBoxTipo.Location = new System.Drawing.Point(66, 48);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipo.TabIndex = 9;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(66, 15);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(198, 20);
            this.textBoxNumero.TabIndex = 3;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(104, 189);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 8;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fecha de vencimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "CVV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Banco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione la tarjeta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistrarTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 430);
            this.Controls.Add(this.panelAgregarTarjeta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(805, 469);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(687, 469);
            this.Name = "RegistrarTarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar tarjeta";
            this.Load += new System.EventHandler(this.RegistrarTarjeta_Load);
            this.panelAgregarTarjeta.ResumeLayout(false);
            this.panelAgregarTarjeta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAgregarTarjeta;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaVenc;
        private System.Windows.Forms.TextBox textBoxCVV;
        private System.Windows.Forms.TextBox textBoxBanco;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}