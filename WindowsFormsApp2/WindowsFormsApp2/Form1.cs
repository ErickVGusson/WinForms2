using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTroca_Click(object sender, EventArgs e)
        {

            string valor1 = txbValor1.Text;
            string valor2 = txbValor2.Text;
            string valor3 = txbValor3.Text;

            txbValor1.Text = valor3;
            txbValor2.Text = valor1;
            txbValor3.Text = valor2;

        }

        private void btnDecrescente_Click(object sender, EventArgs e)
        {

            float valor1 = float.Parse(txbValor1.Text);
            float valor2 = float.Parse(txbValor2.Text);
            float valor3 = float.Parse(txbValor3.Text);

            //verificando o maior numero
            if ( valor1 > valor2 && valor1 > valor3 )
            {
                txbValor1.Text = valor1.ToString();
            }
            
            else if ( valor2 > valor1 && valor2 > valor3 )
            {
                txbValor1.Text = valor2.ToString();
            }

            else if( valor3 > valor1 && valor3 > valor2 )
            {
                txbValor1.Text = valor3.ToString();
            }

            //Achando o numero do meio
            if ( ( valor1 < valor2 && valor1 > valor3 ) || ( valor1 > valor2 && valor1 < valor3 ) )
            {
                txbValor2.Text = valor1.ToString();
            }

            else if ( ( valor2 < valor1 && valor2 > valor3 ) || ( valor2 > valor1 && valor2 < valor3 ) )
            {
                txbValor2.Text = valor2.ToString();
            }

            else if ( ( valor3 < valor1 && valor3 > valor2 ) || ( valor3 > valor1 && valor3 < valor2 ) )
            {
                txbValor2.Text = valor3.ToString();
            }

            //verificando o menor numero
            if ( valor1 < valor2 && valor1 < valor3 )
            {
                txbValor3.Text = valor1.ToString();
            }

            else if ( valor2 < valor1 && valor2 < valor3 )
            {
                txbValor3.Text = valor2.ToString();
            }

            else if ( valor3 < valor1 && valor3 < valor2 )
            {
                txbValor3.Text = valor3.ToString();
            }





        }
    }
}
