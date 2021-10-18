namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_altura = new System.Windows.Forms.Label();
            this.conexion = new System.Windows.Forms.Button();
            this.alturaBox = new System.Windows.Forms.TextBox();
            this.altura = new System.Windows.Forms.RadioButton();
            this.Longitud = new System.Windows.Forms.RadioButton();
            this.Bonito = new System.Windows.Forms.RadioButton();
            this.palindromo = new System.Windows.Forms.RadioButton();
            this.mayusculas = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(154, 83);
            this.nombre.Margin = new System.Windows.Forms.Padding(4);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(217, 22);
            this.nombre.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(334, 200);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Controls.Add(this.mayusculas);
            this.groupBox1.Controls.Add(this.palindromo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label_altura);
            this.groupBox1.Controls.Add(this.conexion);
            this.groupBox1.Controls.Add(this.alturaBox);
            this.groupBox1.Controls.Add(this.altura);
            this.groupBox1.Controls.Add(this.Longitud);
            this.groupBox1.Controls.Add(this.Bonito);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.ForeColor = System.Drawing.Color.Snow;
            this.groupBox1.Location = new System.Drawing.Point(16, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(513, 425);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(23, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "DESCONECTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_altura
            // 
            this.label_altura.AutoSize = true;
            this.label_altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_altura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_altura.Location = new System.Drawing.Point(31, 113);
            this.label_altura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_altura.Name = "label_altura";
            this.label_altura.Size = new System.Drawing.Size(69, 25);
            this.label_altura.TabIndex = 11;
            this.label_altura.Text = "Altura";
            // 
            // conexion
            // 
            this.conexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conexion.ForeColor = System.Drawing.Color.DimGray;
            this.conexion.Location = new System.Drawing.Point(23, 33);
            this.conexion.Name = "conexion";
            this.conexion.Size = new System.Drawing.Size(146, 29);
            this.conexion.TabIndex = 7;
            this.conexion.Text = "CONECTAR";
            this.conexion.UseVisualStyleBackColor = true;
            this.conexion.Click += new System.EventHandler(this.conexion_Click);
            // 
            // alturaBox
            // 
            this.alturaBox.Location = new System.Drawing.Point(154, 113);
            this.alturaBox.Margin = new System.Windows.Forms.Padding(4);
            this.alturaBox.Name = "alturaBox";
            this.alturaBox.Size = new System.Drawing.Size(101, 22);
            this.alturaBox.TabIndex = 10;
            // 
            // altura
            // 
            this.altura.AutoSize = true;
            this.altura.Location = new System.Drawing.Point(36, 246);
            this.altura.Margin = new System.Windows.Forms.Padding(4);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(96, 21);
            this.altura.TabIndex = 9;
            this.altura.TabStop = true;
            this.altura.Text = "¿Soy alto?";
            this.altura.UseVisualStyleBackColor = true;
            // 
            // Longitud
            // 
            this.Longitud.AutoSize = true;
            this.Longitud.Location = new System.Drawing.Point(36, 217);
            this.Longitud.Margin = new System.Windows.Forms.Padding(4);
            this.Longitud.Name = "Longitud";
            this.Longitud.Size = new System.Drawing.Size(251, 21);
            this.Longitud.TabIndex = 7;
            this.Longitud.TabStop = true;
            this.Longitud.Text = "¿Cuál es la longitud de mi nombre?";
            this.Longitud.UseVisualStyleBackColor = true;
            // 
            // Bonito
            // 
            this.Bonito.AutoSize = true;
            this.Bonito.Location = new System.Drawing.Point(36, 188);
            this.Bonito.Margin = new System.Windows.Forms.Padding(4);
            this.Bonito.Name = "Bonito";
            this.Bonito.Size = new System.Drawing.Size(173, 21);
            this.Bonito.TabIndex = 8;
            this.Bonito.TabStop = true;
            this.Bonito.Text = "¿Mi nombre es bonito?";
            this.Bonito.UseVisualStyleBackColor = true;
            // 
            // palindromo
            // 
            this.palindromo.AutoSize = true;
            this.palindromo.Location = new System.Drawing.Point(36, 275);
            this.palindromo.Margin = new System.Windows.Forms.Padding(4);
            this.palindromo.Name = "palindromo";
            this.palindromo.Size = new System.Drawing.Size(225, 21);
            this.palindromo.TabIndex = 13;
            this.palindromo.TabStop = true;
            this.palindromo.Text = "¿Es mi nombre un palíndromo?";
            this.palindromo.UseVisualStyleBackColor = true;
            // 
            // mayusculas
            // 
            this.mayusculas.AutoSize = true;
            this.mayusculas.Location = new System.Drawing.Point(36, 304);
            this.mayusculas.Margin = new System.Windows.Forms.Padding(4);
            this.mayusculas.Name = "mayusculas";
            this.mayusculas.Size = new System.Drawing.Size(260, 21);
            this.mayusculas.TabIndex = 14;
            this.mayusculas.TabStop = true;
            this.mayusculas.Text = "¿Cuál es mi nombre en mayúsculas?";
            this.mayusculas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 692);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Longitud;
        private System.Windows.Forms.RadioButton Bonito;
        private System.Windows.Forms.TextBox alturaBox;
        private System.Windows.Forms.RadioButton altura;
        private System.Windows.Forms.Button conexion;
        private System.Windows.Forms.Label label_altura;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton mayusculas;
        private System.Windows.Forms.RadioButton palindromo;
    }
}

