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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string usuario = textBox1.Text;
            string contrasena = textBox2.Text;
            Administrarproductos admin = new Administrarproductos();
            try
            {
                if (usuario == "admin" && contrasena == "admin123")
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                    admin.Show();

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta...", "Error");
                }

            }
            catch
            {
                MessageBox.Show("Error de autenticacion...", "Error");
            }

        }

        private void Administrador_Load(object sender, EventArgs e)
        {

        }
    }
}
