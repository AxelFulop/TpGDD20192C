namespace FrbaOfertas.AbmRol
{
    partial class AbmRol
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.func_admin = new System.Windows.Forms.ListBox();
            this.func_proveedor = new System.Windows.Forms.ListBox();
            this.func_cliente = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Administrador";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(477, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Proveedor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(884, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cliente";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(956, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 59);
            this.button3.TabIndex = 11;
            this.button3.Text = "Agregar funcionalidad";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // func_admin
            // 
            this.func_admin.FormattingEnabled = true;
            this.func_admin.ItemHeight = 20;
            this.func_admin.Items.AddRange(new object[] {
            "Sin funcionalidades"});
            this.func_admin.Location = new System.Drawing.Point(79, 186);
            this.func_admin.Name = "func_admin";
            this.func_admin.Size = new System.Drawing.Size(266, 424);
            this.func_admin.TabIndex = 12;
            this.func_admin.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // func_proveedor
            // 
            this.func_proveedor.FormattingEnabled = true;
            this.func_proveedor.ItemHeight = 20;
            this.func_proveedor.Items.AddRange(new object[] {
            "Sin funcionalidades"});
            this.func_proveedor.Location = new System.Drawing.Point(483, 186);
            this.func_proveedor.Name = "func_proveedor";
            this.func_proveedor.Size = new System.Drawing.Size(266, 424);
            this.func_proveedor.TabIndex = 13;
            // 
            // func_cliente
            // 
            this.func_cliente.FormattingEnabled = true;
            this.func_cliente.ItemHeight = 20;
            this.func_cliente.Items.AddRange(new object[] {
            "Sin funcionalidades"});
            this.func_cliente.Location = new System.Drawing.Point(890, 186);
            this.func_cliente.Name = "func_cliente";
            this.func_cliente.Size = new System.Drawing.Size(266, 424);
            this.func_cliente.TabIndex = 14;
            this.func_cliente.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 46);
            this.label1.TabIndex = 15;
            this.label1.Text = "Roles y sus funcionalidades";
            // 
            // AbmRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.func_cliente);
            this.Controls.Add(this.func_proveedor);
            this.Controls.Add(this.func_admin);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "AbmRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM - Rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox func_admin;
        private System.Windows.Forms.ListBox func_proveedor;
        private System.Windows.Forms.ListBox func_cliente;
        private System.Windows.Forms.Label label1;

    }
}