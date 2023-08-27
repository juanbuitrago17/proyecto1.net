namespace proy6
{
    partial class Form3
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
            this.lBLTITULO3 = new System.Windows.Forms.Label();
            this.txtNumero3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.bttAceptar3 = new System.Windows.Forms.Button();
            this.bttCerrar3 = new System.Windows.Forms.Button();
            this.bttlimpiar3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBLTITULO3
            // 
            this.lBLTITULO3.AutoSize = true;
            this.lBLTITULO3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBLTITULO3.Location = new System.Drawing.Point(106, 34);
            this.lBLTITULO3.Name = "lBLTITULO3";
            this.lBLTITULO3.Size = new System.Drawing.Size(574, 29);
            this.lBLTITULO3.TabIndex = 2;
            this.lBLTITULO3.Text = "DETERMINAR SI EL NUMERO ES PRIMO O NO";
            // 
            // txtNumero3
            // 
            this.txtNumero3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero3.Location = new System.Drawing.Point(417, 138);
            this.txtNumero3.Name = "txtNumero3";
            this.txtNumero3.Size = new System.Drawing.Size(152, 31);
            this.txtNumero3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "INGRESE EL NUMERO";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.Location = new System.Drawing.Point(246, 218);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(0, 25);
            this.lblR.TabIndex = 10;
            // 
            // bttAceptar3
            // 
            this.bttAceptar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAceptar3.Location = new System.Drawing.Point(317, 275);
            this.bttAceptar3.Name = "bttAceptar3";
            this.bttAceptar3.Size = new System.Drawing.Size(130, 35);
            this.bttAceptar3.TabIndex = 11;
            this.bttAceptar3.Text = "ACEPTAR";
            this.bttAceptar3.UseVisualStyleBackColor = true;
            this.bttAceptar3.Click += new System.EventHandler(this.bttAceptar3_Click);
            // 
            // bttCerrar3
            // 
            this.bttCerrar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCerrar3.Location = new System.Drawing.Point(600, 363);
            this.bttCerrar3.Name = "bttCerrar3";
            this.bttCerrar3.Size = new System.Drawing.Size(105, 35);
            this.bttCerrar3.TabIndex = 12;
            this.bttCerrar3.Text = "CERRAR";
            this.bttCerrar3.UseVisualStyleBackColor = true;
            this.bttCerrar3.Click += new System.EventHandler(this.bttCerrar3_Click);
            // 
            // bttlimpiar3
            // 
            this.bttlimpiar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttlimpiar3.Location = new System.Drawing.Point(52, 372);
            this.bttlimpiar3.Name = "bttlimpiar3";
            this.bttlimpiar3.Size = new System.Drawing.Size(130, 35);
            this.bttlimpiar3.TabIndex = 13;
            this.bttlimpiar3.Text = "LIMPIAR";
            this.bttlimpiar3.UseVisualStyleBackColor = true;
            this.bttlimpiar3.Click += new System.EventHandler(this.bttlimpiar3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttlimpiar3);
            this.Controls.Add(this.bttCerrar3);
            this.Controls.Add(this.bttAceptar3);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumero3);
            this.Controls.Add(this.lBLTITULO3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lBLTITULO3;
        private System.Windows.Forms.TextBox txtNumero3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Button bttAceptar3;
        private System.Windows.Forms.Button bttCerrar3;
        private System.Windows.Forms.Button bttlimpiar3;
    }
}