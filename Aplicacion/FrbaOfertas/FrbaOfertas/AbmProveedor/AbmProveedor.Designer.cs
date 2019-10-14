namespace FrbaOfertas.AbmProveedor
{
    partial class AbmProveedor
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cuit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.razonSocial = new System.Windows.Forms.TextBox();
            this.RazonColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RubroColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RazonColumn,
            this.MailColumn,
            this.TelefonoColumn,
            this.DireccionColumn,
            this.CPColumn,
            this.CuitColumn,
            this.RubroColumn,
            this.ContactoColumn,
            this.EditColumn});
            this.grid.Location = new System.Drawing.Point(12, 163);
            this.grid.Name = "grid";
            this.grid.RowTemplate.Height = 28;
            this.grid.Size = new System.Drawing.Size(755, 274);
            this.grid.TabIndex = 3;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(11, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(756, 10);
            this.panel3.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = "";
            this.panel1.AccessibleName = "";
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cuit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.razonSocial);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 137);
            this.panel1.TabIndex = 4;
            this.panel1.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Filtros de búsqueda";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(612, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mail";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(381, 73);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(144, 26);
            this.mail.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "CUIT";
            // 
            // cuit
            // 
            this.cuit.Location = new System.Drawing.Point(124, 96);
            this.cuit.Name = "cuit";
            this.cuit.Size = new System.Drawing.Size(144, 26);
            this.cuit.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Razón social";
            // 
            // razonSocial
            // 
            this.razonSocial.Location = new System.Drawing.Point(124, 51);
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.Size = new System.Drawing.Size(144, 26);
            this.razonSocial.TabIndex = 0;
            // 
            // RazonColumn
            // 
            this.RazonColumn.HeaderText = "Razón social";
            this.RazonColumn.Name = "RazonColumn";
            this.RazonColumn.ReadOnly = true;
            // 
            // MailColumn
            // 
            this.MailColumn.HeaderText = "Mail";
            this.MailColumn.Name = "MailColumn";
            this.MailColumn.ReadOnly = true;
            // 
            // TelefonoColumn
            // 
            this.TelefonoColumn.HeaderText = "Telefono";
            this.TelefonoColumn.Name = "TelefonoColumn";
            this.TelefonoColumn.ReadOnly = true;
            // 
            // DireccionColumn
            // 
            this.DireccionColumn.HeaderText = "Dirección";
            this.DireccionColumn.Name = "DireccionColumn";
            this.DireccionColumn.ReadOnly = true;
            // 
            // CPColumn
            // 
            this.CPColumn.HeaderText = "CP";
            this.CPColumn.Name = "CPColumn";
            this.CPColumn.ReadOnly = true;
            // 
            // CuitColumn
            // 
            this.CuitColumn.HeaderText = "CUIT";
            this.CuitColumn.Name = "CuitColumn";
            this.CuitColumn.ReadOnly = true;
            // 
            // RubroColumn
            // 
            this.RubroColumn.HeaderText = "Rubro";
            this.RubroColumn.Name = "RubroColumn";
            this.RubroColumn.ReadOnly = true;
            // 
            // ContactoColumn
            // 
            this.ContactoColumn.HeaderText = "Contacto";
            this.ContactoColumn.Name = "ContactoColumn";
            this.ContactoColumn.ReadOnly = true;
            // 
            // EditColumn
            // 
            this.EditColumn.DataPropertyName = "Mail";
            this.EditColumn.HeaderText = "";
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.Text = "Editar";
            // 
            // AbmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "AbmProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM - Proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RubroColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactoColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditColumn;
    }
}