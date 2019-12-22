using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_de_ecuaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnresolver_Click(object sender, EventArgs e)
        {
            Calculo calculo = new Calculo();
            calculo.A = double.Parse(txta.Text);
            calculo.B = double.Parse(txtb.Text);
            calculo.C = double.Parse(txtc.Text);

            txtdiscriminante.Text = Convert.ToString(calculo.discriminante());

            if (calculo.discriminante() == 0)
            {
                txtX.Text = Convert.ToString(calculo.solucion0());
            }

            if (calculo.discriminante() > 0)
            {
                txtX1.Text = Convert.ToString(calculo.solucionmayor0sum());
                txtX2.Text = Convert.ToString(calculo.solucionmayor0res());
            }

            if (calculo.discriminante() < 0)
            {
                txtX1i.Text = Convert.ToString(calculo.solucionmenor0sum());
                txtX2i.Text = Convert.ToString(calculo.solucionmenor0res());
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txta.Clear();
            txtb.Clear();
            txtc.Clear();
            txtdiscriminante.Clear();
            txtX.Clear();
            txtX1.Clear();
            txtX1i.Clear();
            txtX2.Clear();
            txtX2i.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
