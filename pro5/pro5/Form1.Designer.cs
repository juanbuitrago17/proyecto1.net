namespace pro5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.Button();
            this.registro = new System.Windows.Forms.Button();
            this.grados = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl1.Location = new System.Drawing.Point(12, 119);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(283, 24);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "REGISTRO DE ESTUDIANTE";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl2.Location = new System.Drawing.Point(302, 209);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(234, 24);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "GRADOS FAHRENHEIT";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl3.Location = new System.Drawing.Point(577, 119);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(211, 24);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "AREA Y PERIMETRO";
            // 
            // area
            // 
            this.area.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.area.Location = new System.Drawing.Point(631, 209);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(118, 24);
            this.area.TabIndex = 3;
            this.area.Text = "MOSTRAR";
            this.area.UseVisualStyleBackColor = true;
            this.area.Click += new System.EventHandler(this.area_Click);
            // 
            // registro
            // 
            this.registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro.Location = new System.Drawing.Point(85, 209);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(118, 24);
            this.registro.TabIndex = 4;
            this.registro.Text = "MOSTRAR";
            this.registro.UseVisualStyleBackColor = true;
            this.registro.Click += new System.EventHandler(this.registro_Click);
            // 
            // grados
            // 
            this.grados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grados.Location = new System.Drawing.Point(350, 270);
            this.grados.Name = "grados";
            this.grados.Size = new System.Drawing.Size(118, 24);
            this.grados.TabIndex = 5;
            this.grados.Text = "MOSTRAR";
            this.grados.UseVisualStyleBackColor = true;
            this.grados.Click += new System.EventHandler(this.button2_Click);
            // 
            // cerrar
            // 
            this.cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrar.Location = new System.Drawing.Point(362, 377);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(96, 24);
            this.cerrar.TabIndex = 6;
            this.cerrar.Text = "CERRAR";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.grados);
            this.Controls.Add(this.registro);
            this.Controls.Add(this.area);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button area;
        private System.Windows.Forms.Button registro;
        private System.Windows.Forms.Button grados;
        private System.Windows.Forms.Button cerrar;
    }
}

