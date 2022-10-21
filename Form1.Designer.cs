namespace SebastianEngelstajn_WindowsFinal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.bttnValidaciones = new System.Windows.Forms.Button();
            this.bttnMostrar = new System.Windows.Forms.Button();
            this.bttnIngresarHoras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sueldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Puesto";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(221, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(221, 123);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 22);
            this.txtApellido.TabIndex = 5;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(221, 190);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 22);
            this.txtSueldo.TabIndex = 6;
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(221, 268);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(100, 22);
            this.txtPuesto.TabIndex = 7;
            // 
            // bttnValidaciones
            // 
            this.bttnValidaciones.Location = new System.Drawing.Point(471, 52);
            this.bttnValidaciones.Name = "bttnValidaciones";
            this.bttnValidaciones.Size = new System.Drawing.Size(100, 24);
            this.bttnValidaciones.TabIndex = 8;
            this.bttnValidaciones.Text = "Validaciones";
            this.bttnValidaciones.UseVisualStyleBackColor = true;
            this.bttnValidaciones.Click += new System.EventHandler(this.bttnValidaciones_Click);
            // 
            // bttnMostrar
            // 
            this.bttnMostrar.Location = new System.Drawing.Point(471, 123);
            this.bttnMostrar.Name = "bttnMostrar";
            this.bttnMostrar.Size = new System.Drawing.Size(100, 24);
            this.bttnMostrar.TabIndex = 9;
            this.bttnMostrar.Text = "Mostrar";
            this.bttnMostrar.UseVisualStyleBackColor = true;
            this.bttnMostrar.Click += new System.EventHandler(this.bttnMostrar_Click);
            // 
            // bttnIngresarHoras
            // 
            this.bttnIngresarHoras.Location = new System.Drawing.Point(459, 188);
            this.bttnIngresarHoras.Name = "bttnIngresarHoras";
            this.bttnIngresarHoras.Size = new System.Drawing.Size(124, 24);
            this.bttnIngresarHoras.TabIndex = 10;
            this.bttnIngresarHoras.Text = "Ingresar Horas";
            this.bttnIngresarHoras.UseVisualStyleBackColor = true;
            this.bttnIngresarHoras.Click += new System.EventHandler(this.bttnIngresarHoras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnIngresarHoras);
            this.Controls.Add(this.bttnMostrar);
            this.Controls.Add(this.bttnValidaciones);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Button bttnValidaciones;
        private System.Windows.Forms.Button bttnMostrar;
        private System.Windows.Forms.Button bttnIngresarHoras;
    }
}

