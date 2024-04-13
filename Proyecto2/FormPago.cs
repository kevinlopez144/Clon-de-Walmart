using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2
{
    public partial class FormPago : Form
    {
        public bool estadotarjeta { get; set; }
        public FormPago()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormPago_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Numerotarjeta = Convert.ToInt32(textBox1.Text);
            if (Numerotarjeta < 9999999999999999  )
            {
                MessageBox.Show("Tarjeta Invalida");
                estadotarjeta = false;
            }
            else if(Numerotarjeta>9999999999999999)
            {
                MessageBox.Show("Tarjeta Invalida");

            }
            else
            {
                MessageBox.Show("Tarjeta aceptada");
                estadotarjeta = true;
            }
            
        }
    }
}
