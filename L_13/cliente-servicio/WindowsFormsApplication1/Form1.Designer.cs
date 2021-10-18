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
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_Temperatura = new System.Windows.Forms.Label();
            this.conexion = new System.Windows.Forms.Button();
            this.temperaturaBox = new System.Windows.Forms.TextBox();
            this.conversion2 = new System.Windows.Forms.RadioButton();
            this.conversion1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(155, 191);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Convertir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label_Temperatura);
            this.groupBox1.Controls.Add(this.conexion);
            this.groupBox1.Controls.Add(this.temperaturaBox);
            this.groupBox1.Controls.Add(this.conversion2);
            this.groupBox1.Controls.Add(this.conversion1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.ForeColor = System.Drawing.Color.Snow;
            this.groupBox1.Location = new System.Drawing.Point(16, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(515, 366);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(23, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "DESCONECTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_Temperatura
            // 
            this.label_Temperatura.AutoSize = true;
            this.label_Temperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Temperatura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Temperatura.Location = new System.Drawing.Point(31, 113);
            this.label_Temperatura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Temperatura.Name = "label_Temperatura";
            this.label_Temperatura.Size = new System.Drawing.Size(135, 25);
            this.label_Temperatura.TabIndex = 11;
            this.label_Temperatura.Text = "Temperatura";
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
            // temperaturaBox
            // 
            this.temperaturaBox.Location = new System.Drawing.Point(174, 116);
            this.temperaturaBox.Margin = new System.Windows.Forms.Padding(4);
            this.temperaturaBox.Name = "temperaturaBox";
            this.temperaturaBox.Size = new System.Drawing.Size(101, 22);
            this.temperaturaBox.TabIndex = 10;
            // 
            // conversion2
            // 
            this.conversion2.AutoSize = true;
            this.conversion2.Location = new System.Drawing.Point(36, 207);
            this.conversion2.Margin = new System.Windows.Forms.Padding(4);
            this.conversion2.Name = "conversion2";
            this.conversion2.Size = new System.Drawing.Size(94, 21);
            this.conversion2.TabIndex = 7;
            this.conversion2.TabStop = true;
            this.conversion2.Text = "De ºF a ºC";
            this.conversion2.UseVisualStyleBackColor = true;
            // 
            // conversion1
            // 
            this.conversion1.AutoSize = true;
            this.conversion1.Location = new System.Drawing.Point(36, 179);
            this.conversion1.Margin = new System.Windows.Forms.Padding(4);
            this.conversion1.Name = "conversion1";
            this.conversion1.Size = new System.Drawing.Size(94, 21);
            this.conversion1.TabIndex = 8;
            this.conversion1.TabStop = true;
            this.conversion1.Text = "De ºC a ºF";
            this.conversion1.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton conversion2;
        private System.Windows.Forms.RadioButton conversion1;
        private System.Windows.Forms.TextBox temperaturaBox;
        private System.Windows.Forms.Button conexion;
        private System.Windows.Forms.Label label_Temperatura;
        private System.Windows.Forms.Button button1;
    }
}

