using Proyecto2.Entidades;
using Proyecto2.Menus;
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
    public partial class Crearcuenta : Form
    {
        public Usuario crusuario { get; private set; }
        public Crearcuenta()
        {
            MenuUsuario.Inicializar();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                crusuario = new Usuario(textBox1.Text, textBox2.Text);
                MenuUsuario.añadir(crusuario);
                MessageBox.Show("Datos guardados exitosamente en el archivo JSON.", "Guardado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error de autenticacion", "Error");
            }
        }
    }
}
