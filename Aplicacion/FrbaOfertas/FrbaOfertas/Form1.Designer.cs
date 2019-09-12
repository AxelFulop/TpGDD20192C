namespace FrbaOfertas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.error_message = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ingresar_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.error_message);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ingresar_btn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.user);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 289);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // error_message
            // 
            this.error_message.AutoSize = true;
            this.error_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.error_message.Location = new System.Drawing.Point(320, 187);
            this.error_message.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.error_message.Name = "error_message";
            this.error_message.Size = new System.Drawing.Size(141, 17);
            this.error_message.TabIndex = 7;
            this.error_message.Text = "Error al iniciar sesión";
            this.error_message.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inicio de sesión";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ingresar_btn
            // 
            this.ingresar_btn.Location = new System.Drawing.Point(198, 173);
            this.ingresar_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ingresar_btn.Name = "ingresar_btn";
            this.ingresar_btn.Size = new System.Drawing.Size(112, 31);
            this.ingresar_btn.TabIndex = 4;
            this.ingresar_btn.Text = "Ingresar";
            this.ingresar_btn.UseVisualStyleBackColor = true;
            this.ingresar_btn.Click += new System.EventHandler(this.ingresar_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Tag = "jkhjk";
            this.label2.Text = "Ingrese contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Tag = "jkhjk";
            this.label1.Text = "Ingrese usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(166, 143);
            this.password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(175, 20);
            this.password.TabIndex = 1;
            this.password.UseSystemPasswordChar = true;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(166, 92);
            this.user.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(175, 20);
            this.user.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 289);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ofertas!";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ingresar_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label error_message;
    }
}

