namespace FrbaOfertas.AbmCliente
{
    partial class AbmCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grid = new System.Windows.Forms.DataGridView();
            this.ApellidoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DniColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BorrarColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = "";
            this.panel1.AccessibleName = "";
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.mail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.apellido);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dni);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nombre);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 348);
            this.panel1.TabIndex = 0;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mail";
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
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(395, 99);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(144, 26);
            this.mail.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(395, 54);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(144, 26);
            this.apellido.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "DNI";
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(102, 96);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(144, 26);
            this.dni.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(102, 51);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(144, 26);
            this.nombre.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(11, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1167, 221);
            this.panel3.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApellidoColumn,
            this.NombreColumn,
            this.DniColumn,
            this.MailColumn,
            this.TelefonoColumn,
            this.DireccionColumn,
            this.CPColumn,
            this.FechaNacColumn,
            this.EditColumn,
            this.BorrarColumn});
            this.grid.Location = new System.Drawing.Point(12, 158);
            this.grid.Name = "grid";
            this.grid.RowTemplate.Height = 28;
            this.grid.Size = new System.Drawing.Size(1166, 485);
            this.grid.TabIndex = 0;
            this.grid.Tag = "grid";
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ApellidoColumn
            // 
            this.ApellidoColumn.HeaderText = "Apellido";
            this.ApellidoColumn.Name = "ApellidoColumn";
            this.ApellidoColumn.ReadOnly = true;
            // 
            // NombreColumn
            // 
            this.NombreColumn.HeaderText = "Nombre";
            this.NombreColumn.Name = "NombreColumn";
            this.NombreColumn.ReadOnly = true;
            // 
            // DniColumn
            // 
            this.DniColumn.HeaderText = "DNI";
            this.DniColumn.Name = "DniColumn";
            this.DniColumn.ReadOnly = true;
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
            // FechaNacColumn
            // 
            this.FechaNacColumn.HeaderText = "Fecha Nac";
            this.FechaNacColumn.Name = "FechaNacColumn";
            this.FechaNacColumn.ReadOnly = true;
            // 
            // EditColumn
            // 
            this.EditColumn.DataPropertyName = "DNI";
            this.EditColumn.HeaderText = "";
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EditColumn.Text = "Editar";
            this.EditColumn.UseColumnTextForButtonValue = true;
            // 
            // BorrarColumn
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BorrarColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.BorrarColumn.HeaderText = "";
            this.BorrarColumn.Name = "BorrarColumn";
            // 
            // AbmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "AbmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM - Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditColumn;
        private System.Windows.Forms.DataGridViewButtonColumn BorrarColumn;
    }
}