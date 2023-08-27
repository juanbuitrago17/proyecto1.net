namespace pro5
{
    partial class Registro
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
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtgrado = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.bttaceptarR = new System.Windows.Forms.Button();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.bttcerrar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblnombre.Location = new System.Drawing.Point(12, 74);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(406, 24);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "INGRESE EL NOMBRE DEL ESTUDIANTE";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbledad.Location = new System.Drawing.Point(12, 151);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(373, 24);
            this.lbledad.TabIndex = 1;
            this.lbledad.Text = "INGRESE LA EDAD DEL ESTUDIANTE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "INGRESE EL GRADO DEL ESTUDIANTE";
            // 
            // txtgrado
            // 
            this.txtgrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgrado.Location = new System.Drawing.Point(498, 227);
            this.txtgrado.Name = "txtgrado";
            this.txtgrado.Size = new System.Drawing.Size(175, 29);
            this.txtgrado.TabIndex = 5;
            // 
            // txtedad
            // 
            this.txtedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtedad.Location = new System.Drawing.Point(498, 146);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(175, 29);
            this.txtedad.TabIndex = 6;
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(498, 69);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(175, 29);
            this.txtnombre.TabIndex = 7;
            // 
            // bttaceptarR
            // 
            this.bttaceptarR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttaceptarR.Location = new System.Drawing.Point(352, 335);
            this.bttaceptarR.Name = "bttaceptarR";
            this.bttaceptarR.Size = new System.Drawing.Size(102, 36);
            this.bttaceptarR.TabIndex = 8;
            this.bttaceptarR.Text = "Aceptar";
            this.bttaceptarR.UseVisualStyleBackColor = true;
            this.bttaceptarR.Click += new System.EventHandler(this.bttaceptarR_Click);
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRegistro.Location = new System.Drawing.Point(86, 289);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(0, 20);
            this.lblRegistro.TabIndex = 9;
            // 
            // bttcerrar2
            // 
            this.bttcerrar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttcerrar2.Location = new System.Drawing.Point(621, 392);
            this.bttcerrar2.Name = "bttcerrar2";
            this.bttcerrar2.Size = new System.Drawing.Size(96, 36);
            this.bttcerrar2.TabIndex = 10;
            this.bttcerrar2.Text = "CERRAR";
            this.bttcerrar2.UseVisualStyleBackColor = true;
            this.bttcerrar2.Click += new System.EventHandler(this.bttcerrar2_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttcerrar2);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.bttaceptarR);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtgrado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lblnombre);
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtgrado;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button bttaceptarR;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Button bttcerrar2;
    }
}