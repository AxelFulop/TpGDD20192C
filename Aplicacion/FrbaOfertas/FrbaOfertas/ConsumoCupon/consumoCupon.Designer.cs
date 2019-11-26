namespace FrbaOfertas.ConsumoCupon
{
    partial class consumoCupon
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.filtroDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(172, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 37);
            this.button3.TabIndex = 13;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Location = new System.Drawing.Point(393, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // filtroDescripcion
            // 
            this.filtroDescripcion.Location = new System.Drawing.Point(75, 107);
            this.filtroDescripcion.Name = "filtroDescripcion";
            this.filtroDescripcion.Size = new System.Drawing.Size(302, 26);
            this.filtroDescripcion.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Buscar por nombre y apellido de cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seleccione el cupón de la oferta entregada";
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 184);
            this.grid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1149, 438);
            this.grid.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1044, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // consumoCupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 644);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.filtroDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "consumoCupon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrega ofertas";
            this.Load += new System.EventHandler(this.consumoCupon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox filtroDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button button1;
    }
}