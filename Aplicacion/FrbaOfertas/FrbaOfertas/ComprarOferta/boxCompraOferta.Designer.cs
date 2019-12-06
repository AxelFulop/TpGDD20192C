namespace FrbaOfertas.ComprarOferta
{
    partial class boxCompraOferta
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.comprarBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxTarjeta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAgregarTarjeta = new System.Windows.Forms.Panel();
            this.tarj_saldo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tarj_tipo = new System.Windows.Forms.TextBox();
            this.tarj_fechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.tarj_cvv = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tarj_banco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.o_descripcion = new System.Windows.Forms.RichTextBox();
            this.o_codigo = new System.Windows.Forms.TextBox();
            this.o_precio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.NumericUpDown();
            this.user_cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.verTarjetasBtn = new System.Windows.Forms.Button();
            this.panelAgregarTarjeta.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CancelBtn.Location = new System.Drawing.Point(338, 514);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(177, 51);
            this.CancelBtn.TabIndex = 61;
            this.CancelBtn.Text = "Cancelar";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // comprarBtn
            // 
            this.comprarBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.comprarBtn.Location = new System.Drawing.Point(531, 514);
            this.comprarBtn.Name = "comprarBtn";
            this.comprarBtn.Size = new System.Drawing.Size(177, 51);
            this.comprarBtn.TabIndex = 60;
            this.comprarBtn.Text = "Comprar";
            this.comprarBtn.UseVisualStyleBackColor = false;
            this.comprarBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(529, 78);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 20);
            this.label11.TabIndex = 62;
            this.label11.Text = "Número tarjeta";
            // 
            // comboBoxTarjeta
            // 
            this.comboBoxTarjeta.FormattingEnabled = true;
            this.comboBoxTarjeta.Location = new System.Drawing.Point(663, 75);
            this.comboBoxTarjeta.Name = "comboBoxTarjeta";
            this.comboBoxTarjeta.Size = new System.Drawing.Size(290, 28);
            this.comboBoxTarjeta.TabIndex = 63;
            this.comboBoxTarjeta.SelectedIndexChanged += new System.EventHandler(this.tarj_numero_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(496, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Seleccione la tarjeta con la cual desea pagar";
            // 
            // panelAgregarTarjeta
            // 
            this.panelAgregarTarjeta.Controls.Add(this.tarj_saldo);
            this.panelAgregarTarjeta.Controls.Add(this.label10);
            this.panelAgregarTarjeta.Controls.Add(this.tarj_tipo);
            this.panelAgregarTarjeta.Controls.Add(this.tarj_fechaVencimiento);
            this.panelAgregarTarjeta.Controls.Add(this.tarj_cvv);
            this.panelAgregarTarjeta.Controls.Add(this.label12);
            this.panelAgregarTarjeta.Controls.Add(this.tarj_banco);
            this.panelAgregarTarjeta.Controls.Add(this.label6);
            this.panelAgregarTarjeta.Controls.Add(this.label5);
            this.panelAgregarTarjeta.Controls.Add(this.label4);
            this.panelAgregarTarjeta.Controls.Add(this.label3);
            this.panelAgregarTarjeta.Location = new System.Drawing.Point(533, 127);
            this.panelAgregarTarjeta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAgregarTarjeta.Name = "panelAgregarTarjeta";
            this.panelAgregarTarjeta.Size = new System.Drawing.Size(357, 258);
            this.panelAgregarTarjeta.TabIndex = 67;
            this.panelAgregarTarjeta.Visible = false;
            // 
            // tarj_saldo
            // 
            this.tarj_saldo.Enabled = false;
            this.tarj_saldo.Location = new System.Drawing.Point(105, 149);
            this.tarj_saldo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tarj_saldo.Name = "tarj_saldo";
            this.tarj_saldo.Size = new System.Drawing.Size(201, 26);
            this.tarj_saldo.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 154);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Saldo";
            // 
            // tarj_tipo
            // 
            this.tarj_tipo.Enabled = false;
            this.tarj_tipo.Location = new System.Drawing.Point(105, 41);
            this.tarj_tipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tarj_tipo.Name = "tarj_tipo";
            this.tarj_tipo.Size = new System.Drawing.Size(201, 26);
            this.tarj_tipo.TabIndex = 14;
            // 
            // tarj_fechaVencimiento
            // 
            this.tarj_fechaVencimiento.Enabled = false;
            this.tarj_fechaVencimiento.Location = new System.Drawing.Point(41, 219);
            this.tarj_fechaVencimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tarj_fechaVencimiento.Name = "tarj_fechaVencimiento";
            this.tarj_fechaVencimiento.Size = new System.Drawing.Size(299, 26);
            this.tarj_fechaVencimiento.TabIndex = 12;
            // 
            // tarj_cvv
            // 
            this.tarj_cvv.Enabled = false;
            this.tarj_cvv.Location = new System.Drawing.Point(105, 113);
            this.tarj_cvv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tarj_cvv.Name = "tarj_cvv";
            this.tarj_cvv.Size = new System.Drawing.Size(201, 26);
            this.tarj_cvv.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(4, 16);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(198, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Datos tarjeta seleccionada";
            // 
            // tarj_banco
            // 
            this.tarj_banco.Enabled = false;
            this.tarj_banco.Location = new System.Drawing.Point(105, 77);
            this.tarj_banco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tarj_banco.Name = "tarj_banco";
            this.tarj_banco.Size = new System.Drawing.Size(201, 26);
            this.tarj_banco.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 195);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fecha de vencimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "CVV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Banco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.o_descripcion);
            this.panel1.Controls.Add(this.o_codigo);
            this.panel1.Controls.Add(this.o_precio);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.labelX);
            this.panel1.Location = new System.Drawing.Point(99, 127);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 278);
            this.panel1.TabIndex = 68;
            // 
            // o_descripcion
            // 
            this.o_descripcion.Enabled = false;
            this.o_descripcion.Location = new System.Drawing.Point(36, 120);
            this.o_descripcion.Name = "o_descripcion";
            this.o_descripcion.Size = new System.Drawing.Size(294, 99);
            this.o_descripcion.TabIndex = 17;
            this.o_descripcion.Text = "";
            // 
            // o_codigo
            // 
            this.o_codigo.Enabled = false;
            this.o_codigo.Location = new System.Drawing.Point(152, 57);
            this.o_codigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.o_codigo.Name = "o_codigo";
            this.o_codigo.Size = new System.Drawing.Size(188, 26);
            this.o_codigo.TabIndex = 14;
            // 
            // o_precio
            // 
            this.o_precio.Enabled = false;
            this.o_precio.Location = new System.Drawing.Point(152, 244);
            this.o_precio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.o_precio.Name = "o_precio";
            this.o_precio.Size = new System.Drawing.Size(188, 26);
            this.o_precio.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(4, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Datos oferta";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 249);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Precio individual";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 97);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Descripción";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(21, 57);
            this.labelX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(59, 20);
            this.labelX.TabIndex = 4;
            this.labelX.Text = "Código";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(344, 446);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 20);
            this.label14.TabIndex = 69;
            this.label14.Text = "Cantidad a comprar";
            // 
            // cantidad
            // 
            this.cantidad.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cantidad.Location = new System.Drawing.Point(499, 444);
            this.cantidad.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(172, 26);
            this.cantidad.TabIndex = 70;
            this.cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // user_cliente
            // 
            this.user_cliente.Location = new System.Drawing.Point(188, 43);
            this.user_cliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user_cliente.Name = "user_cliente";
            this.user_cliente.Size = new System.Drawing.Size(251, 26);
            this.user_cliente.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 71;
            this.label2.Text = "Usuario cliente";
            // 
            // verTarjetasBtn
            // 
            this.verTarjetasBtn.Location = new System.Drawing.Point(233, 78);
            this.verTarjetasBtn.Name = "verTarjetasBtn";
            this.verTarjetasBtn.Size = new System.Drawing.Size(134, 41);
            this.verTarjetasBtn.TabIndex = 73;
            this.verTarjetasBtn.Text = "Ver tarjetas";
            this.verTarjetasBtn.UseVisualStyleBackColor = true;
            this.verTarjetasBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // boxCompraOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 577);
            this.Controls.Add(this.verTarjetasBtn);
            this.Controls.Add(this.user_cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAgregarTarjeta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTarjeta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.comprarBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "boxCompraOferta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra oferta";
            this.Load += new System.EventHandler(this.boxCompraOferta_Load);
            this.panelAgregarTarjeta.ResumeLayout(false);
            this.panelAgregarTarjeta.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button comprarBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxTarjeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAgregarTarjeta;
        private System.Windows.Forms.TextBox tarj_saldo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tarj_tipo;
        private System.Windows.Forms.DateTimePicker tarj_fechaVencimiento;
        private System.Windows.Forms.TextBox tarj_cvv;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tarj_banco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox o_codigo;
        private System.Windows.Forms.TextBox o_precio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown cantidad;
        private System.Windows.Forms.RichTextBox o_descripcion;
        private System.Windows.Forms.TextBox user_cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button verTarjetasBtn;
    }
}