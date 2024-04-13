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
    public partial class Form2 : Form
    {
#pragma warning disable CS0169 // El campo 'Form2.numericUpDownIdusuario' nunca se usa
        private object numericUpDownIdusuario;
#pragma warning restore CS0169 // El campo 'Form2.numericUpDownIdusuario' nunca se usa
        
        public Usuario usuario { get; private set; }

        public Form2()
        {
            MenuUsuario.Inicializar();
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            MenuDeProductos frm = new MenuDeProductos();
            string buscarnombre = textBox1.Text;
            string buscarid = textBox2.Text;
            frm.recibir(buscarid);
            MenuPedido.Ver(buscarid);

            MenuUsuario.Buscar(buscarnombre, buscarid);

            if (MenuUsuario.estado == true)
            {
                textBox1.Clear();
                textBox2.Clear();
                this.Close();
                frm.Show();
                
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }

        }
        
        
        

        private void button2_Click(object sender, EventArgs e)
        {
            Administrador frm = new Administrador();
            this.Close();
            frm.Show();
        }
    }
}
