namespace FrbaOfertas.CrearOferta
{
    partial class ConfeccionarOferta
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
            this.numericUpDownCantDisp = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLimCom = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonGen = new System.Windows.Forms.Button();
            this.textBoxCodOferta = new System.Windows.Forms.TextBox();
            this.labelCodOferta = new System.Windows.Forms.Label();
            this.dateTimePickerFechaPub = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechVenc = new System.Windows.Forms.DateTimePicker();
            this.richTextBoxDesc = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFecVencOfer = new System.Windows.Forms.Label();
            this.labelFechaPub = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.precioOferta = new System.Windows.Forms.NumericUpDown();
            this.precioLista = new System.Windows.Forms.NumericUpDown();
            this.razonSocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cuit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantDisp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimCom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioOferta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioLista)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownCantDisp
            // 
            this.numericUpDownCantDisp.Location = new System.Drawing.Point(254, 415);
            this.numericUpDownCantDisp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownCantDisp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownCantDisp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCantDisp.Name = "numericUpDownCantDisp";
            this.numericUpDownCantDisp.Size = new System.Drawing.Size(93, 26);
            this.numericUpDownCantDisp.TabIndex = 39;
            this.numericUpDownCantDisp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownLimCom
            // 
            this.numericUpDownLimCom.Location = new System.Drawing.Point(254, 512);
            this.numericUpDownLimCom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownLimCom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownLimCom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLimCom.Name = "numericUpDownLimCom";
            this.numericUpDownLimCom.Size = new System.Drawing.Size(93, 26);
            this.numericUpDownLimCom.TabIndex = 38;
            this.numericUpDownLimCom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 515);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Limite compra";
            // 
            // buttonGen
            // 
            this.buttonGen.Location = new System.Drawing.Point(558, 454);
            this.buttonGen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(132, 43);
            this.buttonGen.TabIndex = 24;
            this.buttonGen.Text = "Generar código";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click_1);
            // 
            // textBoxCodOferta
            // 
            this.textBoxCodOferta.Enabled = false;
            this.textBoxCodOferta.Location = new System.Drawing.Point(254, 462);
            this.textBoxCodOferta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCodOferta.Name = "textBoxCodOferta";
            this.textBoxCodOferta.Size = new System.Drawing.Size(292, 26);
            this.textBoxCodOferta.TabIndex = 36;
            // 
            // labelCodOferta
            // 
            this.labelCodOferta.AutoSize = true;
            this.labelCodOferta.Location = new System.Drawing.Point(70, 468);
            this.labelCodOferta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCodOferta.Name = "labelCodOferta";
            this.labelCodOferta.Size = new System.Drawing.Size(59, 20);
            this.labelCodOferta.TabIndex = 35;
            this.labelCodOferta.Text = "Codigo";
            // 
            // dateTimePickerFechaPub
            // 
            this.dateTimePickerFechaPub.Location = new System.Drawing.Point(254, 178);
            this.dateTimePickerFechaPub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerFechaPub.Name = "dateTimePickerFechaPub";
            this.dateTimePickerFechaPub.Size = new System.Drawing.Size(292, 26);
            this.dateTimePickerFechaPub.TabIndex = 34;
            // 
            // dateTimePickerFechVenc
            // 
            this.dateTimePickerFechVenc.Location = new System.Drawing.Point(254, 238);
            this.dateTimePickerFechVenc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerFechVenc.Name = "dateTimePickerFechVenc";
            this.dateTimePickerFechVenc.Size = new System.Drawing.Size(292, 26);
            this.dateTimePickerFechVenc.TabIndex = 33;
            // 
            // richTextBoxDesc
            // 
            this.richTextBoxDesc.Location = new System.Drawing.Point(644, 185);
            this.richTextBoxDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxDesc.Name = "richTextBoxDesc";
            this.richTextBoxDesc.Size = new System.Drawing.Size(468, 182);
            this.richTextBoxDesc.TabIndex = 32;
            this.richTextBoxDesc.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(640, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 417);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Cantidad disponible";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Precio de lista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 308);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Precio oferta";
            // 
            // labelFecVencOfer
            // 
            this.labelFecVencOfer.AutoSize = true;
            this.labelFecVencOfer.Location = new System.Drawing.Point(70, 245);
            this.labelFecVencOfer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFecVencOfer.Name = "labelFecVencOfer";
            this.labelFecVencOfer.Size = new System.Drawing.Size(137, 20);
            this.labelFecVencOfer.TabIndex = 25;
            this.labelFecVencOfer.Text = "Fecha venc oferta";
            // 
            // labelFechaPub
            // 
            this.labelFechaPub.AutoSize = true;
            this.labelFechaPub.Location = new System.Drawing.Point(70, 185);
            this.labelFechaPub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFechaPub.Name = "labelFechaPub";
            this.labelFechaPub.Size = new System.Drawing.Size(137, 20);
            this.labelFechaPub.TabIndex = 23;
            this.labelFechaPub.Text = "Fecha publicacion";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(420, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 57);
            this.button1.TabIndex = 41;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.Location = new System.Drawing.Point(616, 566);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 57);
            this.button4.TabIndex = 40;
            this.button4.Text = "Confeccionar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // precioOferta
            // 
            this.precioOferta.Location = new System.Drawing.Point(254, 305);
            this.precioOferta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.precioOferta.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.precioOferta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.precioOferta.Name = "precioOferta";
            this.precioOferta.Size = new System.Drawing.Size(292, 26);
            this.precioOferta.TabIndex = 42;
            this.precioOferta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // precioLista
            // 
            this.precioLista.Location = new System.Drawing.Point(254, 360);
            this.precioLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.precioLista.Maximum = new decimal(new int[] {
            -402653185,
            -1613725636,
            54210108,
            0});
            this.precioLista.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.precioLista.Name = "precioLista";
            this.precioLista.Size = new System.Drawing.Size(292, 26);
            this.precioLista.TabIndex = 43;
            this.precioLista.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // razonSocial
            // 
            this.razonSocial.Location = new System.Drawing.Point(254, 97);
            this.razonSocial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.Size = new System.Drawing.Size(292, 26);
            this.razonSocial.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Razón social";
            // 
            // cuit
            // 
            this.cuit.Location = new System.Drawing.Point(254, 62);
            this.cuit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cuit.Name = "cuit";
            this.cuit.Size = new System.Drawing.Size(292, 26);
            this.cuit.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "CUIT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(52, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Datos proveedor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(52, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 49;
            this.label9.Text = "Datos oferta";
            // 
            // ConfeccionarOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 626);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cuit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.razonSocial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.precioLista);
            this.Controls.Add(this.precioOferta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.numericUpDownCantDisp);
            this.Controls.Add(this.numericUpDownLimCom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.textBoxCodOferta);
            this.Controls.Add(this.labelCodOferta);
            this.Controls.Add(this.dateTimePickerFechaPub);
            this.Controls.Add(this.dateTimePickerFechVenc);
            this.Controls.Add(this.richTextBoxDesc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelFecVencOfer);
            this.Controls.Add(this.labelFechaPub);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1194, 682);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1016, 682);
            this.Name = "ConfeccionarOferta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confeccionar ofertas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantDisp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimCom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioOferta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownCantDisp;
        private System.Windows.Forms.NumericUpDown numericUpDownLimCom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.TextBox textBoxCodOferta;
        private System.Windows.Forms.Label labelCodOferta;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaPub;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechVenc;
        private System.Windows.Forms.RichTextBox richTextBoxDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFecVencOfer;
        private System.Windows.Forms.Label labelFechaPub;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown precioOferta;
        private System.Windows.Forms.NumericUpDown precioLista;
        private System.Windows.Forms.TextBox razonSocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cuit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}