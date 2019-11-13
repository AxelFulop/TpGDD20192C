namespace FrbaOfertas.AbmRol
{
    partial class Editar
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
            this.label1 = new System.Windows.Forms.Label();
            this.func_rol = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreRol = new System.Windows.Forms.TextBox();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.func_a_agregar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_inhabilitar = new System.Windows.Forms.Button();
            this.btn_habilitar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rol: ";
            // 
            // func_rol
            // 
            this.func_rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.func_rol.ForeColor = System.Drawing.Color.OrangeRed;
            this.func_rol.FormattingEnabled = true;
            this.func_rol.ItemHeight = 29;
            this.func_rol.Items.AddRange(new object[] {
            "Sin funcionalidades..."});
            this.func_rol.Location = new System.Drawing.Point(56, 164);
            this.func_rol.Name = "func_rol";
            this.func_rol.Size = new System.Drawing.Size(462, 468);
            this.func_rol.TabIndex = 2;
            this.func_rol.SelectedIndexChanged += new System.EventHandler(this.func_rol_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Funcionalidades";
            // 
            // nombreRol
            // 
            this.nombreRol.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nombreRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreRol.Location = new System.Drawing.Point(100, 12);
            this.nombreRol.Name = "nombreRol";
            this.nombreRol.Size = new System.Drawing.Size(281, 44);
            this.nombreRol.TabIndex = 4;
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(1058, 12);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(108, 44);
            this.buttonVolver.TabIndex = 5;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.func_a_agregar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(589, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 170);
            this.panel1.TabIndex = 6;
            this.panel1.Tag = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(195, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // func_a_agregar
            // 
            this.func_a_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.func_a_agregar.FormattingEnabled = true;
            this.func_a_agregar.Location = new System.Drawing.Point(78, 43);
            this.func_a_agregar.Name = "func_a_agregar";
            this.func_a_agregar.Size = new System.Drawing.Size(372, 33);
            this.func_a_agregar.TabIndex = 1;
            this.func_a_agregar.SelectedIndexChanged += new System.EventHandler(this.func_a_agregar_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Seleccione funcionalidad a agregar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(585, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Agregar funcionalidad";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.Location = new System.Drawing.Point(745, 505);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 58);
            this.button3.TabIndex = 8;
            this.button3.Text = "Eliminar rol";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(352, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Presione una funcionalidad para eliminarla del rol";
            // 
            // btn_inhabilitar
            // 
            this.btn_inhabilitar.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_inhabilitar.Location = new System.Drawing.Point(775, 340);
            this.btn_inhabilitar.Name = "btn_inhabilitar";
            this.btn_inhabilitar.Size = new System.Drawing.Size(162, 39);
            this.btn_inhabilitar.TabIndex = 10;
            this.btn_inhabilitar.Text = "Inhabilitar rol";
            this.btn_inhabilitar.UseVisualStyleBackColor = false;
            this.btn_inhabilitar.Visible = false;
            this.btn_inhabilitar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_habilitar
            // 
            this.btn_habilitar.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_habilitar.Location = new System.Drawing.Point(775, 340);
            this.btn_habilitar.Name = "btn_habilitar";
            this.btn_habilitar.Size = new System.Drawing.Size(162, 39);
            this.btn_habilitar.TabIndex = 11;
            this.btn_habilitar.Text = "Habilitar rol";
            this.btn_habilitar.UseVisualStyleBackColor = false;
            this.btn_habilitar.Visible = false;
            this.btn_habilitar.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cambiar nombre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_habilitar);
            this.Controls.Add(this.btn_inhabilitar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.nombreRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.func_rol);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.Editar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox func_rol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreRol;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox func_a_agregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_inhabilitar;
        private System.Windows.Forms.Button btn_habilitar;
        private System.Windows.Forms.Button button1;
    }
}