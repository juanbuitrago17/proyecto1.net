namespace proy6
{
    partial class Form4
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
            this.lBLTITULO4 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumero4 = new System.Windows.Forms.TextBox();
            this.bttAceptar4 = new System.Windows.Forms.Button();
            this.lblResultado4 = new System.Windows.Forms.Label();
            this.bttCerrar4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBLTITULO4
            // 
            this.lBLTITULO4.AutoSize = true;
            this.lBLTITULO4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBLTITULO4.Location = new System.Drawing.Point(191, 29);
            this.lBLTITULO4.Name = "lBLTITULO4";
            this.lBLTITULO4.Size = new System.Drawing.Size(425, 29);
            this.lBLTITULO4.TabIndex = 3;
            this.lBLTITULO4.Text = "CONVERTIR UN NUMERO A BYTE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "INGRESE EL NUMERO";
            // 
            // txtNumero4
            // 
            this.txtNumero4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero4.Location = new System.Drawing.Point(421, 118);
            this.txtNumero4.Name = "txtNumero4";
            this.txtNumero4.Size = new System.Drawing.Size(152, 31);
            this.txtNumero4.TabIndex = 5;
            // 
            // bttAceptar4
            // 
            this.bttAceptar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAceptar4.Location = new System.Drawing.Point(324, 249);
            this.bttAceptar4.Name = "bttAceptar4";
            this.bttAceptar4.Size = new System.Drawing.Size(130, 35);
            this.bttAceptar4.TabIndex = 7;
            this.bttAceptar4.Text = "ACEPTAR";
            this.bttAceptar4.UseVisualStyleBackColor = true;
            this.bttAceptar4.Click += new System.EventHandler(this.bttAceptar4_Click);
            // 
            // lblResultado4
            // 
            this.lblResultado4.AutoSize = true;
            this.lblResultado4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado4.Location = new System.Drawing.Point(61, 205);
            this.lblResultado4.Name = "lblResultado4";
            this.lblResultado4.Size = new System.Drawing.Size(0, 25);
            this.lblResultado4.TabIndex = 8;
            // 
            // bttCerrar4
            // 
            this.bttCerrar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCerrar4.Location = new System.Drawing.Point(593, 357);
            this.bttCerrar4.Name = "bttCerrar4";
            this.bttCerrar4.Size = new System.Drawing.Size(105, 35);
            this.bttCerrar4.TabIndex = 9;
            this.bttCerrar4.Text = "CERRAR";
            this.bttCerrar4.UseVisualStyleBackColor = true;
            this.bttCerrar4.Click += new System.EventHandler(this.bttCerrar4_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttCerrar4);
            this.Controls.Add(this.lblResultado4);
            this.Controls.Add(this.bttAceptar4);
            this.Controls.Add(this.txtNumero4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lBLTITULO4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lBLTITULO4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumero4;
        private System.Windows.Forms.Button bttAceptar4;
        private System.Windows.Forms.Label lblResultado4;
        private System.Windows.Forms.Button bttCerrar4;
    }
}