namespace Formulario
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.labelCarrera = new System.Windows.Forms.Label();
            this.tbCarrera = new System.Windows.Forms.TextBox();
            this.labelDucha = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.tbDucha = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btEjecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(30, 25);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(33, 42);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(131, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // labelCarrera
            // 
            this.labelCarrera.AutoSize = true;
            this.labelCarrera.Location = new System.Drawing.Point(30, 91);
            this.labelCarrera.Name = "labelCarrera";
            this.labelCarrera.Size = new System.Drawing.Size(41, 13);
            this.labelCarrera.TabIndex = 2;
            this.labelCarrera.Text = "Carrera";
            // 
            // tbCarrera
            // 
            this.tbCarrera.Location = new System.Drawing.Point(33, 107);
            this.tbCarrera.Name = "tbCarrera";
            this.tbCarrera.Size = new System.Drawing.Size(131, 20);
            this.tbCarrera.TabIndex = 3;
            // 
            // labelDucha
            // 
            this.labelDucha.AutoSize = true;
            this.labelDucha.Location = new System.Drawing.Point(30, 211);
            this.labelDucha.Name = "labelDucha";
            this.labelDucha.Size = new System.Drawing.Size(204, 13);
            this.labelDucha.TabIndex = 4;
            this.labelDucha.Text = "¿Usa usted las duchas de la universidad?";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(30, 151);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(32, 13);
            this.labelEdad.TabIndex = 5;
            this.labelEdad.Text = "Edad";
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(33, 167);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(131, 20);
            this.tbEdad.TabIndex = 6;
            // 
            // tbDucha
            // 
            this.tbDucha.Location = new System.Drawing.Point(33, 227);
            this.tbDucha.Name = "tbDucha";
            this.tbDucha.Size = new System.Drawing.Size(131, 20);
            this.tbDucha.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(352, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(381, 235);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(33, 284);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 9;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btEjecutar
            // 
            this.btEjecutar.Location = new System.Drawing.Point(159, 284);
            this.btEjecutar.Name = "btEjecutar";
            this.btEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btEjecutar.TabIndex = 10;
            this.btEjecutar.Text = "Ejecutar";
            this.btEjecutar.UseVisualStyleBackColor = true;
            this.btEjecutar.Click += new System.EventHandler(this.btEjecutar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btEjecutar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tbDucha);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelDucha);
            this.Controls.Add(this.tbCarrera);
            this.Controls.Add(this.labelCarrera);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.labelNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label labelCarrera;
        private System.Windows.Forms.TextBox tbCarrera;
        private System.Windows.Forms.Label labelDucha;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.TextBox tbDucha;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btEjecutar;
    }
}

