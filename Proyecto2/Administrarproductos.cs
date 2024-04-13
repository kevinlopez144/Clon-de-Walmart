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
    public partial class Administrarproductos : Form
    {
        public Administrarproductos()
        {
            
            InitializeComponent();
            MenuProductos.Inicializar();
            visualizar();
  
        }

        public void visualizar()
        {
            dataGridView1.Rows.Clear();

            foreach(Productos prod in MenuProductos.productos)
            {
                int rowindex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowindex].Cells[0].Value = prod.Idproducto.ToString();
                dataGridView1.Rows[rowindex].Cells[1].Value = prod.Nombre.ToString();
                dataGridView1.Rows[rowindex].Cells[2].Value = prod.Tipo.ToString();
                dataGridView1.Rows[rowindex].Cells[3].Value = prod.Cantidad.ToString();
                dataGridView1.Rows[rowindex].Cells[4].Value = prod.Precio.ToString();
            }
        }


        private void Administrarproductos_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ProductosForm productoform = new ProductosForm();
            productoform.ShowDialog();

            MenuProductos.añadir(productoform.productos);
            visualizar();
              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idpro = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                MenuProductos.Eliminar(idpro);
                visualizar();
            }
            else
            {
                MessageBox.Show("Ningun producto seleccionado...", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string IdproductoModificar = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string NomproductoModificar = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string TipoproductoModificar = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                int cantproductoModificar = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value);
                double PrecioproductoModificar = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[4].Value);
                Productos prodmodificar = new Productos(IdproductoModificar, NomproductoModificar, TipoproductoModificar, cantproductoModificar, PrecioproductoModificar);
                ProductosForm productosForm = new ProductosForm(prodmodificar);
                productosForm.ShowDialog();
                MenuProductos.Actualizarproducto(IdproductoModificar, productosForm.productos);
                visualizar();
                
                     
            }
            else
            {
                MessageBox.Show("Ningun producto seleccionado...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
