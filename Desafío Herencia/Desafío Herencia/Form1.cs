using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafío_Herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form f = this;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public int tipo_de_inmueble()
        {
            int x = 0;
            if (botonPiso.Checked)
            {
                x = 1;
            }
            else if (botonLocal.Checked)
            {
                x = 2;
            }
            return x;
        }
        public int getTextNro()
        {
            int nro = 0;

            if (botonPiso.Checked)
            {
                nro = Convert.ToInt32(textNroPiso.Text);
            }
            else if (botonLocal.Checked)
            {
                nro = Convert.ToInt32(textNroVentana.Text);
            }

            return nro;
        }
        public int getTextAntiguedad()
        {
            int x = Convert.ToInt32(textAntiguedad.Text);

            return x;
        }
        public int getTextPrecioBase()
        {
            int x = Convert.ToInt32(textPrecioBase.Text);

            return x;
        }
        public int getTextSuperficie()
        {
            int x = Convert.ToInt32(textSuperficie.Text);

            return x;
        }
        public string getTextDireccion()
        {
            string x = textDireccion.Text;

            return x;
        }
        public string getEstado()
        {
            string estado = "";

            if (botonNuevo.Checked)
            {
                estado = "Nuevo";
            }
            else if (botonSegundaMano.Checked)
            {
                estado = "Segunda Mano";
            }

            return estado;
        }
        public void botonCalcularPrecio_Click(object sender, EventArgs e)
        {
             double x = 0;

            if (this.tipo_de_inmueble() == 1)
            {
                Pisos Piso = new Pisos(this.getTextDireccion(), this.getTextSuperficie(), this.getEstado(), this.getTextAntiguedad(), this.getTextPrecioBase(), this.getTextNro());
                x = Piso.precio_final(this.getTextAntiguedad(), this.getTextPrecioBase(), this.getTextNro());
            }
            else if (this.tipo_de_inmueble() == 2)
            {
                Locales Local = new Locales(this.getTextDireccion(), this.getTextSuperficie(), this.getEstado(), this.getTextAntiguedad(), this.getTextPrecioBase(), this.getTextNro());
                x = Local.precio_final(this.getTextSuperficie(), this.getTextAntiguedad(), this.getTextPrecioBase(), this.getTextNro());
            }
            this.labelPrecioFinal.Text = "El Precio Final del Inmueble es de: $" + Convert.ToString(x);

        }
    }
}
