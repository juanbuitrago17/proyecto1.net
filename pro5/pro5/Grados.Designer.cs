namespace pro5
{
    partial class Grados
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
            this.lblcelsius = new System.Windows.Forms.Label();
            this.txtcelcius = new System.Windows.Forms.TextBox();
            this.bttaceptarC = new System.Windows.Forms.Button();
            this.bttcerrar3 = new System.Windows.Forms.Button();
            this.lblRegistro2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblcelsius
            // 
            this.lblcelsius.AutoSize = true;
            this.lblcelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcelsius.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblcelsius.Location = new System.Drawing.Point(23, 124);
            this.lblcelsius.Name = "lblcelsius";
            this.lblcelsius.Size = new System.Drawing.Size(328, 24);
            this.lblcelsius.TabIndex = 1;
            this.lblcelsius.Text = "INGRESE LOS GRADOS CELSIUS";
            // 
            // txtcelcius
            // 
            this.txtcelcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelcius.Location = new System.Drawing.Point(432, 119);
            this.txtcelcius.Name = "txtcelcius";
            this.txtcelcius.Size = new System.Drawing.Size(175, 29);
            this.txtcelcius.TabIndex = 6;
            // 
            // bttaceptarC
            // 
            this.bttaceptarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttaceptarC.Location = new System.Drawing.Point(346, 277);
            this.bttaceptarC.Name = "bttaceptarC";
            this.bttaceptarC.Size = new System.Drawing.Size(102, 36);
            this.bttaceptarC.TabIndex = 9;
            this.bttaceptarC.Text = "Aceptar";
            this.bttaceptarC.UseVisualStyleBackColor = true;
            this.bttaceptarC.Click += new System.EventHandler(this.bttaceptarC_Click);
            // 
            // bttcerrar3
            // 
            this.bttcerrar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttcerrar3.Location = new System.Drawing.Point(647, 374);
            this.bttcerrar3.Name = "bttcerrar3";
            this.bttcerrar3.Size = new System.Drawing.Size(96, 36);
            this.bttcerrar3.TabIndex = 11;
            this.bttcerrar3.Text = "CERRAR";
            this.bttcerrar3.UseVisualStyleBackColor = true;
            this.bttcerrar3.Click += new System.EventHandler(this.bttcerrar3_Click);
            // 
            // lblRegistro2
            // 
            this.lblRegistro2.AutoSize = true;
            this.lblRegistro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRegistro2.Location = new System.Drawing.Point(23, 217);
            this.lblRegistro2.Name = "lblRegistro2";
            this.lblRegistro2.Size = new System.Drawing.Size(0, 24);
            this.lblRegistro2.TabIndex = 12;
            this.lblRegistro2.Click += new System.EventHandler(this.label1_Click);
            // 
            // Grados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRegistro2);
            this.Controls.Add(this.bttcerrar3);
            this.Controls.Add(this.bttaceptarC);
            this.Controls.Add(this.txtcelcius);
            this.Controls.Add(this.lblcelsius);
            this.Name = "Grados";
            this.Text = "Grados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcelsius;
        private System.Windows.Forms.TextBox txtcelcius;
        private System.Windows.Forms.Button bttaceptarC;
        private System.Windows.Forms.Button bttcerrar3;
        private System.Windows.Forms.Label lblRegistro2;
    }
}