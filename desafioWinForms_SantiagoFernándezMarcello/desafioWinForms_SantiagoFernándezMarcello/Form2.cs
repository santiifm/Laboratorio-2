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
    public partial class Form2 : Form
    {
        private Form1 mainForm = null;
        public Form2(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.label1.Text = "El precio final de la compra es de: $" + mainForm.GetPrecioFinal();
        }
    }
}
