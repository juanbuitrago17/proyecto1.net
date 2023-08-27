namespace proy6
{
    partial class Form2
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
            this.lBLTITULO2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.bttAceptar2 = new System.Windows.Forms.Button();
            this.bttCerrar2 = new System.Windows.Forms.Button();
            this.lblResultado2 = new System.Windows.Forms.Label();
            this.bttlimpiar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBLTITULO2
            // 
            this.lBLTITULO2.AutoSize = true;
            this.lBLTITULO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBLTITULO2.Location = new System.Drawing.Point(41, 26);
            this.lBLTITULO2.Name = "lBLTITULO2";
            this.lBLTITULO2.Size = new System.Drawing.Size(681, 29);
            this.lBLTITULO2.TabIndex = 1;
            this.lBLTITULO2.Text = "DETERMINAR EL MES QUE REPRESENTA EL NUMERO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "INGRESE EL NUMERO";
            // 
            // txtNumero2
            // 
            this.txtNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero2.Location = new System.Drawing.Point(430, 132);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(152, 31);
            this.txtNumero2.TabIndex = 3;
            // 
            // bttAceptar2
            // 
            this.bttAceptar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAceptar2.Location = new System.Drawing.Point(334, 256);
            this.bttAceptar2.Name = "bttAceptar2";
            this.bttAceptar2.Size = new System.Drawing.Size(130, 35);
            this.bttAceptar2.TabIndex = 7;
            this.bttAceptar2.Text = "ACEPTAR";
            this.bttAceptar2.UseVisualStyleBackColor = true;
            this.bttAceptar2.Click += new System.EventHandler(this.bttAceptar2_Click);
            // 
            // bttCerrar2
            // 
            this.bttCerrar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCerrar2.Location = new System.Drawing.Point(598, 363);
            this.bttCerrar2.Name = "bttCerrar2";
            this.bttCerrar2.Size = new System.Drawing.Size(105, 35);
            this.bttCerrar2.TabIndex = 8;
            this.bttCerrar2.Text = "CERRAR";
            this.bttCerrar2.UseVisualStyleBackColor = true;
            this.bttCerrar2.Click += new System.EventHandler(this.bttCerrar2_Click);
            // 
            // lblResultado2
            // 
            this.lblResultado2.AutoSize = true;
            this.lblResultado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado2.Location = new System.Drawing.Point(274, 209);
            this.lblResultado2.Name = "lblResultado2";
            this.lblResultado2.Size = new System.Drawing.Size(0, 25);
            this.lblResultado2.TabIndex = 9;
            // 
            // bttlimpiar2
            // 
            this.bttlimpiar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttlimpiar2.Location = new System.Drawing.Point(67, 363);
            this.bttlimpiar2.Name = "bttlimpiar2";
            this.bttlimpiar2.Size = new System.Drawing.Size(130, 35);
            this.bttlimpiar2.TabIndex = 10;
            this.bttlimpiar2.Text = "LIMPIAR";
            this.bttlimpiar2.UseVisualStyleBackColor = true;
            this.bttlimpiar2.Click += new System.EventHandler(this.bttlimpiar2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttlimpiar2);
            this.Controls.Add(this.lblResultado2);
            this.Controls.Add(this.bttCerrar2);
            this.Controls.Add(this.bttAceptar2);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lBLTITULO2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lBLTITULO2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button bttAceptar2;
        private System.Windows.Forms.Button bttCerrar2;
        private System.Windows.Forms.Label lblResultado2;
        private System.Windows.Forms.Button bttlimpiar2;
    }
}