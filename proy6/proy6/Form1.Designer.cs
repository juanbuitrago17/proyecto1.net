namespace proy6
{
    partial class Form1
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
            this.lBLTITULO1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.lblresultado1 = new System.Windows.Forms.Label();
            this.bttCerrar1 = new System.Windows.Forms.Button();
            this.bttAceptar1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBLTITULO1
            // 
            this.lBLTITULO1.AutoSize = true;
            this.lBLTITULO1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBLTITULO1.Location = new System.Drawing.Point(12, 19);
            this.lBLTITULO1.Name = "lBLTITULO1";
            this.lBLTITULO1.Size = new System.Drawing.Size(784, 29);
            this.lBLTITULO1.TabIndex = 0;
            this.lBLTITULO1.Text = "DETERMINAR SI EL NUMERO ES POSITIVO,NEGATIVO O CERO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "INGRESE EL NUMERO";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero1.Location = new System.Drawing.Point(410, 114);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(152, 31);
            this.txtNumero1.TabIndex = 2;
            // 
            // lblresultado1
            // 
            this.lblresultado1.AutoSize = true;
            this.lblresultado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado1.Location = new System.Drawing.Point(207, 213);
            this.lblresultado1.Name = "lblresultado1";
            this.lblresultado1.Size = new System.Drawing.Size(0, 25);
            this.lblresultado1.TabIndex = 4;
            // 
            // bttCerrar1
            // 
            this.bttCerrar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCerrar1.Location = new System.Drawing.Point(603, 361);
            this.bttCerrar1.Name = "bttCerrar1";
            this.bttCerrar1.Size = new System.Drawing.Size(105, 35);
            this.bttCerrar1.TabIndex = 5;
            this.bttCerrar1.Text = "CERRAR";
            this.bttCerrar1.UseVisualStyleBackColor = true;
            this.bttCerrar1.Click += new System.EventHandler(this.bttCerrar1_Click);
            // 
            // bttAceptar1
            // 
            this.bttAceptar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAceptar1.Location = new System.Drawing.Point(321, 275);
            this.bttAceptar1.Name = "bttAceptar1";
            this.bttAceptar1.Size = new System.Drawing.Size(130, 35);
            this.bttAceptar1.TabIndex = 6;
            this.bttAceptar1.Text = "ACEPTAR";
            this.bttAceptar1.UseVisualStyleBackColor = true;
            this.bttAceptar1.Click += new System.EventHandler(this.bttAceptar1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(74, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "LIMPIAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttAceptar1);
            this.Controls.Add(this.bttCerrar1);
            this.Controls.Add(this.lblresultado1);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lBLTITULO1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lBLTITULO1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Label lblresultado1;
        private System.Windows.Forms.Button bttCerrar1;
        private System.Windows.Forms.Button bttAceptar1;
        private System.Windows.Forms.Button button1;
    }
}