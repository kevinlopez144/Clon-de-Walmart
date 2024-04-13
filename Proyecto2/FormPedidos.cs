using Newtonsoft.Json;
using Proyecto2.Entidades;
using Proyecto2.Menus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto2
{
    public partial class FormPedidos : Form
    {
     
        public FormPedidos()
        {
            InitializeComponent();
            MenuProductos.Inicializar();
            MenuPedido.Inicializar();
            visualizar();
            total();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        public void visualizar()
        {
            dataGridView1.Rows.Clear();
            foreach (Pedido ped in MenuPedido.pedidos)
            {
                
                if (ped.Idusuario==MenuPedido.rd)
                {
                    int rowindex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowindex].Cells[0].Value = ped.Idproducto.ToString();
                    dataGridView1.Rows[rowindex].Cells[1].Value = ped.Nombre.ToString();
                    dataGridView1.Rows[rowindex].Cells[2].Value = ped.Tipo.ToString();                 
                    dataGridView1.Rows[rowindex].Cells[3].Value = ped.Precio.ToString();
                    dataGridView1.Rows[rowindex].Cells[4].Value = ped.Cantidad.ToString();
                    dataGridView1.Rows[rowindex].Cells[5].Value = ped.Total.ToString();
                }
                                   
            }

        }

        public void total()
        {
            double total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToDouble(row.Cells[5].Value);
            }
            textBox1.Text = total.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idped = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                MenuPedido.Eliminar(idped);
                visualizar();
                total();
            }
            else
            {
                MessageBox.Show("Ningun producto seleccionado...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            MetodoDePago metodo = new MetodoDePago();
            metodo.Show();

        }
    }
}
