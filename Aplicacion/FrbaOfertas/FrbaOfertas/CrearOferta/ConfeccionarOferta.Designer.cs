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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBoxDesc = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxProovedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFecVencOfer = new System.Windows.Forms.Label();
            this.labelFechaPub = new System.Windows.Forms.Label();
            this.textBoxPrecioLista = new System.Windows.Forms.TextBox();
            this.textBoxPrecOfer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePickerFechVenc = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaPub = new System.Windows.Forms.DateTimePicker();
            this.labelCodOferta = new System.Windows.Forms.Label();
            this.textBoxCodOferta = new System.Windows.Forms.TextBox();
            this.buttonGen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownLimCom = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCantDisp = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimCom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantDisp)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDownCantDisp);
            this.panel1.Controls.Add(this.numericUpDownLimCom);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.buttonGen);
            this.panel1.Controls.Add(this.textBoxCodOferta);
            this.panel1.Controls.Add(this.labelCodOferta);
            this.panel1.Controls.Add(this.dateTimePickerFechaPub);
            this.panel1.Controls.Add(this.dateTimePickerFechVenc);
            this.panel1.Controls.Add(this.richTextBoxDesc);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxProovedor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelFecVencOfer);
            this.panel1.Controls.Add(this.labelFechaPub);
            this.panel1.Controls.Add(this.textBoxPrecioLista);
            this.panel1.Controls.Add(this.textBoxPrecOfer);
            this.panel1.Location = new System.Drawing.Point(38, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 319);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // richTextBoxDesc
            // 
            this.richTextBoxDesc.Location = new System.Drawing.Point(440, 59);
            this.richTextBoxDesc.Name = "richTextBoxDesc";
            this.richTextBoxDesc.Size = new System.Drawing.Size(179, 133);
            this.richTextBoxDesc.TabIndex = 13;
            this.richTextBoxDesc.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Descripcion";
            // 
            // textBoxProovedor
            // 
            this.textBoxProovedor.Location = new System.Drawing.Point(170, 207);
            this.textBoxProovedor.Name = "textBoxProovedor";
            this.textBoxProovedor.Size = new System.Drawing.Size(182, 20);
            this.textBoxProovedor.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Proovedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cantidad disponible";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio de lista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio oferta";
            // 
            // labelFecVencOfer
            // 
            this.labelFecVencOfer.AutoSize = true;
            this.labelFecVencOfer.Location = new System.Drawing.Point(13, 66);
            this.labelFecVencOfer.Name = "labelFecVencOfer";
            this.labelFecVencOfer.Size = new System.Drawing.Size(94, 13);
            this.labelFecVencOfer.TabIndex = 6;
            this.labelFecVencOfer.Text = "Fecha venc oferta";
            // 
            // labelFechaPub
            // 
            this.labelFechaPub.AutoSize = true;
            this.labelFechaPub.Location = new System.Drawing.Point(13, 27);
            this.labelFechaPub.Name = "labelFechaPub";
            this.labelFechaPub.Size = new System.Drawing.Size(94, 13);
            this.labelFechaPub.TabIndex = 5;
            this.labelFechaPub.Text = "Fecha publicacion";
            // 
            // textBoxPrecioLista
            // 
            this.textBoxPrecioLista.Location = new System.Drawing.Point(170, 136);
            this.textBoxPrecioLista.Name = "textBoxPrecioLista";
            this.textBoxPrecioLista.Size = new System.Drawing.Size(182, 20);
            this.textBoxPrecioLista.TabIndex = 3;
            // 
            // textBoxPrecOfer
            // 
            this.textBoxPrecOfer.Location = new System.Drawing.Point(170, 100);
            this.textBoxPrecOfer.Name = "textBoxPrecOfer";
            this.textBoxPrecOfer.Size = new System.Drawing.Size(182, 20);
            this.textBoxPrecOfer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(423, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Generar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePickerFechVenc
            // 
            this.dateTimePickerFechVenc.Location = new System.Drawing.Point(170, 60);
            this.dateTimePickerFechVenc.Name = "dateTimePickerFechVenc";
            this.dateTimePickerFechVenc.Size = new System.Drawing.Size(196, 20);
            this.dateTimePickerFechVenc.TabIndex = 14;
            // 
            // dateTimePickerFechaPub
            // 
            this.dateTimePickerFechaPub.Location = new System.Drawing.Point(170, 20);
            this.dateTimePickerFechaPub.Name = "dateTimePickerFechaPub";
            this.dateTimePickerFechaPub.Size = new System.Drawing.Size(196, 20);
            this.dateTimePickerFechaPub.TabIndex = 15;
            // 
            // labelCodOferta
            // 
            this.labelCodOferta.AutoSize = true;
            this.labelCodOferta.Location = new System.Drawing.Point(13, 242);
            this.labelCodOferta.Name = "labelCodOferta";
            this.labelCodOferta.Size = new System.Drawing.Size(40, 13);
            this.labelCodOferta.TabIndex = 16;
            this.labelCodOferta.Text = "Codigo";
            // 
            // textBoxCodOferta
            // 
            this.textBoxCodOferta.Enabled = false;
            this.textBoxCodOferta.Location = new System.Drawing.Point(170, 242);
            this.textBoxCodOferta.Name = "textBoxCodOferta";
            this.textBoxCodOferta.Size = new System.Drawing.Size(182, 20);
            this.textBoxCodOferta.TabIndex = 17;
            // 
            // buttonGen
            // 
            this.buttonGen.Location = new System.Drawing.Point(358, 237);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(73, 28);
            this.buttonGen.TabIndex = 5;
            this.buttonGen.Text = "Gen cod";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Limite compra";
            // 
            // numericUpDownLimCom
            // 
            this.numericUpDownLimCom.Location = new System.Drawing.Point(170, 275);
            this.numericUpDownLimCom.Name = "numericUpDownLimCom";
            this.numericUpDownLimCom.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownLimCom.TabIndex = 19;
            // 
            // numericUpDownCantDisp
            // 
            this.numericUpDownCantDisp.Location = new System.Drawing.Point(170, 172);
            this.numericUpDownCantDisp.Name = "numericUpDownCantDisp";
            this.numericUpDownCantDisp.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownCantDisp.TabIndex = 20;
            // 
            // ConfeccionarOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 430);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(805, 469);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(687, 469);
            this.Name = "ConfeccionarOferta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimCom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantDisp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPrecioLista;
        private System.Windows.Forms.TextBox textBoxPrecOfer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFecVencOfer;
        private System.Windows.Forms.Label labelFechaPub;
        private System.Windows.Forms.TextBox textBoxProovedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaPub;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechVenc;
        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.TextBox textBoxCodOferta;
        private System.Windows.Forms.Label labelCodOferta;
        private System.Windows.Forms.NumericUpDown numericUpDownCantDisp;
        private System.Windows.Forms.NumericUpDown numericUpDownLimCom;
        private System.Windows.Forms.Label label7;
    }
}