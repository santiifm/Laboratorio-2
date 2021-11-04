using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafioWinForms_SantiagoFernándezMarcello
{
    public partial class Form1 : Form
    {
        private double precioFinal;
        public Form1()
        {
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                checkBox1.Enabled = true;
            }
            else
            {
                checkBox1.Enabled = false;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                checkBox2.Enabled = true;
            }
            else
            {
                checkBox2.Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int calidad = 0;
            int tipo = 0;

            if (checkBox1.Checked || checkBox2.Checked)
            {
                tipo = 1;
            }
            if (radioButton3.Checked)
            {
                calidad = 0;
            }
            else if (radioButton4.Checked)
            {
                calidad = 1;
            }
            if (radioButton1.Checked == true)
            {

                Camisa camisa = new Camisa(calidad, tipo, Convert.ToDouble(textBox2.Text), Convert.ToInt32(textBox3.Text));
                precioFinal = camisa.calcularPrecio();
            }
            else if (radioButton2.Checked == true)
            {
                Pantalon pantalon = new Pantalon(calidad, tipo, Convert.ToDouble(textBox2.Text), Convert.ToInt32(textBox3.Text));
                precioFinal = pantalon.calcularPrecio();
            }
            Form2 frm = new Form2(this);
            frm.Show();
        }
        public string GetPrecioFinal()
        {
            string stringPrecioFinal = Convert.ToString(this.precioFinal);
            return stringPrecioFinal;
        }
    }
}
