﻿namespace FrbaOfertas.CragaCredito
{
    partial class CargaCreditoABM
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
            this.buttonAgregarTarjeta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaCarga = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTarjeta = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAgregarTarjeta
            // 
            this.buttonAgregarTarjeta.Location = new System.Drawing.Point(301, 379);
            this.buttonAgregarTarjeta.Name = "buttonAgregarTarjeta";
            this.buttonAgregarTarjeta.Size = new System.Drawing.Size(140, 23);
            this.buttonAgregarTarjeta.TabIndex = 13;
            this.buttonAgregarTarjeta.Text = "Agregar Tarjeta";
            this.buttonAgregarTarjeta.UseVisualStyleBackColor = true;
            this.buttonAgregarTarjeta.Click += new System.EventHandler(this.buttonAgregarTarjeta_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxCliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.comboBoxTarjeta);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dateTimePickerFechaCarga);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(30, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 224);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 189);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(104, 189);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Aceptar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fecha carga";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Monto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Tipo ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Tarjeta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Datos carga";
            // 
            // dateTimePickerFechaCarga
            // 
            this.dateTimePickerFechaCarga.Location = new System.Drawing.Point(76, 145);
            this.dateTimePickerFechaCarga.Name = "dateTimePickerFechaCarga";
            this.dateTimePickerFechaCarga.Size = new System.Drawing.Size(199, 20);
            this.dateTimePickerFechaCarga.TabIndex = 12;
            // 
            // comboBoxTarjeta
            // 
            this.comboBoxTarjeta.FormattingEnabled = true;
            this.comboBoxTarjeta.Location = new System.Drawing.Point(66, 42);
            this.comboBoxTarjeta.Name = "comboBoxTarjeta";
            this.comboBoxTarjeta.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTarjeta.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(66, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 20);
            this.textBox2.TabIndex = 17;
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(66, 16);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(198, 20);
            this.textBoxCliente.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CargaCreditoABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 424);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAgregarTarjeta);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(803, 463);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(685, 463);
            this.Name = "CargaCreditoABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAgregarTarjeta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaCarga;
        private System.Windows.Forms.ComboBox comboBoxTarjeta;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.Label label1;
    }
}