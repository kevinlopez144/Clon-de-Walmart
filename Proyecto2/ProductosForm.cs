using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto2.Entidades;
using Proyecto2.Menus;

namespace Proyecto2
{
    public partial class ProductosForm : Form
    {
        public Productos productos { get; private set; }

        public ProductosForm()
        {
            
            InitializeComponent();
            MenuProductos.Inicializar();
        }

        public ProductosForm(Productos producto)
        {
            InitializeComponent();
            textBox1.Text = producto.Idproducto;
            textBox2.Text = producto.Nombre;
            opcion = producto.Tipo;
            textBox4.Text = producto.Cantidad.ToString();
            textBox5.Text = producto.Precio.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {

        }
        string opcion = null;

        private void button1_Click(object sender, EventArgs e)
        {
            opcion = comboBox1.SelectedItem.ToString();

            productos = new Productos(textBox1.Text, textBox2.Text, opcion, Convert.ToInt32(textBox4.Text), Convert.ToDouble(textBox5.Text));
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
