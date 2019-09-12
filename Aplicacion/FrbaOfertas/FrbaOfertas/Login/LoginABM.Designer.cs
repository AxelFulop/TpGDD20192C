namespace FrbaOfertas.Login
{
    partial class LoginABM
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
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonIngesar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(119, 67);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(170, 20);
            this.textBoxUser.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(119, 138);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(170, 20);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(33, 215);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 4;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonIngesar
            // 
            this.buttonIngesar.Location = new System.Drawing.Point(171, 215);
            this.buttonIngesar.Name = "buttonIngesar";
            this.buttonIngesar.Size = new System.Drawing.Size(75, 23);
            this.buttonIngesar.TabIndex = 5;
            this.buttonIngesar.Text = "Ingresar";
            this.buttonIngesar.UseVisualStyleBackColor = true;
            this.buttonIngesar.Click += new System.EventHandler(this.buttonIngesar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(306, 215);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 6;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // LoginABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 261);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonIngesar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUser);
            this.Name = "LoginABM";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginABM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonIngesar;
        private System.Windows.Forms.Button buttonSalir;
    }
}