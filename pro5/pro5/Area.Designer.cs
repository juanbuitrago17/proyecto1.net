namespace pro5
{
    partial class Area
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
            this.lblradio = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.bttaceptarA = new System.Windows.Forms.Button();
            this.bttcerrar3 = new System.Windows.Forms.Button();
            this.lblRegistro3 = new System.Windows.Forms.Label();
            this.lblRegistro4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblradio
            // 
            this.lblradio.AutoSize = true;
            this.lblradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblradio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblradio.Location = new System.Drawing.Point(43, 110);
            this.lblradio.Name = "lblradio";
            this.lblradio.Size = new System.Drawing.Size(359, 24);
            this.lblradio.TabIndex = 1;
            this.lblradio.Text = "INGRESE EL RADIO DE EL CIRCULO";
            // 
            // txtRadio
            // 
            this.txtRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRadio.Location = new System.Drawing.Point(479, 107);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(175, 29);
            this.txtRadio.TabIndex = 8;
            // 
            // bttaceptarA
            // 
            this.bttaceptarA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttaceptarA.Location = new System.Drawing.Point(334, 334);
            this.bttaceptarA.Name = "bttaceptarA";
            this.bttaceptarA.Size = new System.Drawing.Size(102, 36);
            this.bttaceptarA.TabIndex = 9;
            this.bttaceptarA.Text = "Aceptar";
            this.bttaceptarA.UseVisualStyleBackColor = true;
            this.bttaceptarA.Click += new System.EventHandler(this.bttaceptarA_Click);
            // 
            // bttcerrar3
            // 
            this.bttcerrar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttcerrar3.Location = new System.Drawing.Point(642, 379);
            this.bttcerrar3.Name = "bttcerrar3";
            this.bttcerrar3.Size = new System.Drawing.Size(96, 36);
            this.bttcerrar3.TabIndex = 11;
            this.bttcerrar3.Text = "CERRAR";
            this.bttcerrar3.UseVisualStyleBackColor = true;
            this.bttcerrar3.Click += new System.EventHandler(this.bttcerrar3_Click);
            // 
            // lblRegistro3
            // 
            this.lblRegistro3.AutoSize = true;
            this.lblRegistro3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRegistro3.Location = new System.Drawing.Point(221, 213);
            this.lblRegistro3.Name = "lblRegistro3";
            this.lblRegistro3.Size = new System.Drawing.Size(0, 24);
            this.lblRegistro3.TabIndex = 12;
            // 
            // lblRegistro4
            // 
            this.lblRegistro4.AutoSize = true;
            this.lblRegistro4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRegistro4.Location = new System.Drawing.Point(221, 266);
            this.lblRegistro4.Name = "lblRegistro4";
            this.lblRegistro4.Size = new System.Drawing.Size(0, 24);
            this.lblRegistro4.TabIndex = 13;
            // 
            // Area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRegistro4);
            this.Controls.Add(this.lblRegistro3);
            this.Controls.Add(this.bttcerrar3);
            this.Controls.Add(this.bttaceptarA);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.lblradio);
            this.Name = "Area";
            this.Text = "Area";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblradio;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Button bttaceptarA;
        private System.Windows.Forms.Button bttcerrar3;
        private System.Windows.Forms.Label lblRegistro3;
        private System.Windows.Forms.Label lblRegistro4;
    }
}