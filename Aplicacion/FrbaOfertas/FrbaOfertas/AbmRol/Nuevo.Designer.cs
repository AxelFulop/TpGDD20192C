namespace FrbaOfertas.AbmRol
{
    partial class Nuevo
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
            this.button3 = new System.Windows.Forms.Button();
            this.nombreRol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.func_disp = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.func_rol = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CancelBtn.Location = new System.Drawing.Point(404, 575);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(174, 57);
            this.CancelBtn.TabIndex = 59;
            this.CancelBtn.Text = "Cancelar";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Location = new System.Drawing.Point(596, 575);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 57);
            this.button3.TabIndex = 58;
            this.button3.Text = "Registrar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // nombreRol
            // 
            this.nombreRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreRol.Location = new System.Drawing.Point(154, 54);
            this.nombreRol.MaxLength = 25;
            this.nombreRol.Name = "nombreRol";
            this.nombreRol.Size = new System.Drawing.Size(308, 30);
            this.nombreRol.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nombre";
            // 
            // func_disp
            // 
            this.func_disp.FormattingEnabled = true;
            this.func_disp.ItemHeight = 20;
            this.func_disp.Location = new System.Drawing.Point(98, 148);
            this.func_disp.Name = "func_disp";
            this.func_disp.Size = new System.Drawing.Size(426, 404);
            this.func_disp.TabIndex = 60;
            this.func_disp.SelectedIndexChanged += new System.EventHandler(this.func_disp_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 25);
            this.label3.TabIndex = 62;
            this.label3.Text = "Funcionalidades disponibles";
            // 
            // func_rol
            // 
            this.func_rol.BackColor = System.Drawing.SystemColors.Window;
            this.func_rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.func_rol.ForeColor = System.Drawing.Color.LimeGreen;
            this.func_rol.FormattingEnabled = true;
            this.func_rol.ItemHeight = 20;
            this.func_rol.Location = new System.Drawing.Point(682, 148);
            this.func_rol.Name = "func_rol";
            this.func_rol.Size = new System.Drawing.Size(426, 404);
            this.func_rol.TabIndex = 63;
            this.func_rol.SelectedIndexChanged += new System.EventHandler(this.func_rol_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(630, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 25);
            this.label2.TabIndex = 64;
            this.label2.Text = "Funcionalidades para el nuevo rol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(562, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 55);
            this.label4.TabIndex = 65;
            this.label4.Text = "=>";
            // 
            // Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 635);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.func_rol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.func_disp);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.nombreRol);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1196, 691);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1020, 691);
            this.Name = "Nuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo rol";
            this.Load += new System.EventHandler(this.Nuevo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox nombreRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox func_disp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox func_rol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}