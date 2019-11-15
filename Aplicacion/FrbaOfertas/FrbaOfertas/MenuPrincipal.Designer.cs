namespace FrbaOfertas
{
    partial class MenuPrincipal
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
            this.listadoMenu = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.msg_sin_rol = new System.Windows.Forms.Label();
            this.msg_rol_malo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(994, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 89);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mi perfil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listadoMenu
            // 
            this.listadoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listadoMenu.FormattingEnabled = true;
            this.listadoMenu.ItemHeight = 37;
            this.listadoMenu.Location = new System.Drawing.Point(290, 174);
            this.listadoMenu.Name = "listadoMenu";
            this.listadoMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listadoMenu.Size = new System.Drawing.Size(612, 300);
            this.listadoMenu.Sorted = true;
            this.listadoMenu.TabIndex = 2;
            this.listadoMenu.SelectedIndexChanged += new System.EventHandler(this.listadoMenu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione acción";
            // 
            // msg_sin_rol
            // 
            this.msg_sin_rol.AutoSize = true;
            this.msg_sin_rol.BackColor = System.Drawing.Color.Transparent;
            this.msg_sin_rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_sin_rol.ForeColor = System.Drawing.Color.OrangeRed;
            this.msg_sin_rol.Location = new System.Drawing.Point(404, 525);
            this.msg_sin_rol.Name = "msg_sin_rol";
            this.msg_sin_rol.Size = new System.Drawing.Size(391, 58);
            this.msg_sin_rol.TabIndex = 4;
            this.msg_sin_rol.Text = "   Usted no tiene un rol asignado!\r\nNo tiene acceso a ninguna acción...";
            this.msg_sin_rol.Visible = false;
            // 
            // msg_rol_malo
            // 
            this.msg_rol_malo.AutoSize = true;
            this.msg_rol_malo.BackColor = System.Drawing.Color.Transparent;
            this.msg_rol_malo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_rol_malo.ForeColor = System.Drawing.Color.OrangeRed;
            this.msg_rol_malo.Location = new System.Drawing.Point(374, 538);
            this.msg_rol_malo.Name = "msg_rol_malo";
            this.msg_rol_malo.Size = new System.Drawing.Size(459, 29);
            this.msg_rol_malo.TabIndex = 5;
            this.msg_rol_malo.Text = "No tiene ninguna acción para su rol actual";
            this.msg_rol_malo.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cerrar sesión";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 635);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.msg_rol_malo);
            this.Controls.Add(this.msg_sin_rol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listadoMenu);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1196, 691);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1020, 691);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listadoMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label msg_sin_rol;
        private System.Windows.Forms.Label msg_rol_malo;
        private System.Windows.Forms.Button button2;
    }
}