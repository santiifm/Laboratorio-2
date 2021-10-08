
namespace Desafío_Herencia
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
            this.botonPiso = new System.Windows.Forms.RadioButton();
            this.botonLocal = new System.Windows.Forms.RadioButton();
            this.textAntiguedad = new System.Windows.Forms.TextBox();
            this.textSuperficie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textPrecioBase = new System.Windows.Forms.TextBox();
            this.textNroPiso = new System.Windows.Forms.TextBox();
            this.textNroVentana = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonCalcularPrecio = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.botonNuevo = new System.Windows.Forms.RadioButton();
            this.botonSegundaMano = new System.Windows.Forms.RadioButton();
            this.labelPrecioFinal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonPiso
            // 
            this.botonPiso.AutoSize = true;
            this.botonPiso.Location = new System.Drawing.Point(37, 35);
            this.botonPiso.Name = "botonPiso";
            this.botonPiso.Size = new System.Drawing.Size(45, 17);
            this.botonPiso.TabIndex = 1;
            this.botonPiso.TabStop = true;
            this.botonPiso.Text = "Piso";
            this.botonPiso.UseVisualStyleBackColor = true;
            this.botonPiso.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // botonLocal
            // 
            this.botonLocal.AutoSize = true;
            this.botonLocal.Location = new System.Drawing.Point(177, 35);
            this.botonLocal.Name = "botonLocal";
            this.botonLocal.Size = new System.Drawing.Size(51, 17);
            this.botonLocal.TabIndex = 2;
            this.botonLocal.TabStop = true;
            this.botonLocal.Text = "Local";
            this.botonLocal.UseVisualStyleBackColor = true;
            this.botonLocal.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // textAntiguedad
            // 
            this.textAntiguedad.Location = new System.Drawing.Point(29, 175);
            this.textAntiguedad.Name = "textAntiguedad";
            this.textAntiguedad.Size = new System.Drawing.Size(58, 20);
            this.textAntiguedad.TabIndex = 5;
            // 
            // textSuperficie
            // 
            this.textSuperficie.Location = new System.Drawing.Point(249, 175);
            this.textSuperficie.Name = "textSuperficie";
            this.textSuperficie.Size = new System.Drawing.Size(59, 20);
            this.textSuperficie.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(26, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Antigüedad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(246, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Superficie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dirección";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(31, 257);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(279, 20);
            this.textDireccion.TabIndex = 8;
            this.textDireccion.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MediumPurple;
            this.label5.Location = new System.Drawing.Point(140, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Precio Base";
            // 
            // textPrecioBase
            // 
            this.textPrecioBase.Location = new System.Drawing.Point(143, 175);
            this.textPrecioBase.Name = "textPrecioBase";
            this.textPrecioBase.Size = new System.Drawing.Size(61, 20);
            this.textPrecioBase.TabIndex = 6;
            // 
            // textNroPiso
            // 
            this.textNroPiso.Location = new System.Drawing.Point(37, 87);
            this.textNroPiso.Name = "textNroPiso";
            this.textNroPiso.Size = new System.Drawing.Size(50, 20);
            this.textNroPiso.TabIndex = 3;
            // 
            // textNroVentana
            // 
            this.textNroVentana.Location = new System.Drawing.Point(177, 87);
            this.textNroVentana.Name = "textNroVentana";
            this.textNroVentana.Size = new System.Drawing.Size(51, 20);
            this.textNroVentana.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nro. Piso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nro. Ventanas";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox1.Controls.Add(this.botonPiso);
            this.groupBox1.Controls.Add(this.textNroVentana);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textNroPiso);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.botonLocal);
            this.groupBox1.Location = new System.Drawing.Point(29, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 120);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Inmueble";
            // 
            // botonCalcularPrecio
            // 
            this.botonCalcularPrecio.Location = new System.Drawing.Point(66, 283);
            this.botonCalcularPrecio.Name = "botonCalcularPrecio";
            this.botonCalcularPrecio.Size = new System.Drawing.Size(208, 37);
            this.botonCalcularPrecio.TabIndex = 16;
            this.botonCalcularPrecio.Text = "Calcular Precio Final";
            this.botonCalcularPrecio.UseVisualStyleBackColor = true;
            this.botonCalcularPrecio.Click += new System.EventHandler(this.botonCalcularPrecio_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox2.Controls.Add(this.botonSegundaMano);
            this.groupBox2.Controls.Add(this.botonNuevo);
            this.groupBox2.Location = new System.Drawing.Point(29, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 36);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado";
            // 
            // botonNuevo
            // 
            this.botonNuevo.AutoSize = true;
            this.botonNuevo.Location = new System.Drawing.Point(37, 13);
            this.botonNuevo.Name = "botonNuevo";
            this.botonNuevo.Size = new System.Drawing.Size(57, 17);
            this.botonNuevo.TabIndex = 0;
            this.botonNuevo.TabStop = true;
            this.botonNuevo.Text = "Nuevo";
            this.botonNuevo.UseVisualStyleBackColor = true;
            // 
            // botonSegundaMano
            // 
            this.botonSegundaMano.AutoSize = true;
            this.botonSegundaMano.Location = new System.Drawing.Point(160, 13);
            this.botonSegundaMano.Name = "botonSegundaMano";
            this.botonSegundaMano.Size = new System.Drawing.Size(98, 17);
            this.botonSegundaMano.TabIndex = 1;
            this.botonSegundaMano.TabStop = true;
            this.botonSegundaMano.Text = "Segunda Mano";
            this.botonSegundaMano.UseVisualStyleBackColor = true;
            // 
            // labelPrecioFinal
            // 
            this.labelPrecioFinal.AutoSize = true;
            this.labelPrecioFinal.Location = new System.Drawing.Point(78, 345);
            this.labelPrecioFinal.Name = "labelPrecioFinal";
            this.labelPrecioFinal.Size = new System.Drawing.Size(0, 13);
            this.labelPrecioFinal.TabIndex = 19;
            this.labelPrecioFinal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(334, 408);
            this.Controls.Add(this.labelPrecioFinal);
            this.Controls.Add(this.botonCalcularPrecio);
            this.Controls.Add(this.textPrecioBase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSuperficie);
            this.Controls.Add(this.textAntiguedad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton botonPiso;
        private System.Windows.Forms.RadioButton botonLocal;
        private System.Windows.Forms.TextBox textAntiguedad;
        private System.Windows.Forms.TextBox textSuperficie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPrecioBase;
        private System.Windows.Forms.TextBox textNroPiso;
        private System.Windows.Forms.TextBox textNroVentana;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botonCalcularPrecio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton botonSegundaMano;
        private System.Windows.Forms.RadioButton botonNuevo;
        private System.Windows.Forms.Label labelPrecioFinal;
    }
}

