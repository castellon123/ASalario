namespace ASalario
{
    partial class fmrSalario
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtVentas = new System.Windows.Forms.TextBox();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Fecha de Nacimiento";
            // 
            // dtpFNacimiento
            // 
            this.dtpFNacimiento.Location = new System.Drawing.Point(295, 29);
            this.dtpFNacimiento.Name = "dtpFNacimiento";
            this.dtpFNacimiento.Size = new System.Drawing.Size(236, 26);
            this.dtpFNacimiento.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese Salario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingrese Ventas Promedio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ingrese Años de Antiguedad";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(300, 88);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(230, 26);
            this.txtSalario.TabIndex = 5;
            // 
            // txtVentas
            // 
            this.txtVentas.Location = new System.Drawing.Point(298, 144);
            this.txtVentas.Name = "txtVentas";
            this.txtVentas.Size = new System.Drawing.Size(231, 26);
            this.txtVentas.TabIndex = 6;
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.Location = new System.Drawing.Point(300, 199);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(228, 26);
            this.txtAntiguedad.TabIndex = 7;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(182, 292);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(228, 50);
            this.btnEjecutar.TabIndex = 8;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // fmrSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 393);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.txtAntiguedad);
            this.Controls.Add(this.txtVentas);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFNacimiento);
            this.Controls.Add(this.label1);
            this.Name = "fmrSalario";
            this.Text = "Aumento de Salario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFNacimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtVentas;
        private System.Windows.Forms.TextBox txtAntiguedad;
        private System.Windows.Forms.Button btnEjecutar;
    }
}

