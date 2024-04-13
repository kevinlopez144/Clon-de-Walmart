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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto2
{
    public partial class MenuDeProductos : Form
    {
        public Pedido pedido { get; private set; }
        public string rec { get; set; }
        public int contador = 1;
        public MenuDeProductos()
        {
            InitializeComponent();
            MenuProductos.Inicializar();
            MenuPedido.Inicializar();

        }
        public void recibir(string recibido)
        {
            rec = recibido;
        }

        private void electrodomesticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Productos prod in MenuProductos.productos)
            {
                if (prod.Tipo=="Jugos y bebidas")
                {
                    int rowindex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowindex].Cells[0].Value = prod.Idproducto.ToString();
                    dataGridView1.Rows[rowindex].Cells[1].Value = prod.Nombre.ToString();
                    dataGridView1.Rows[rowindex].Cells[2].Value = prod.Tipo.ToString();
                    dataGridView1.Rows[rowindex].Cells[3].Value = prod.Precio.ToString();
                }
                
            }
        }

        private void accesoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Productos prod2 in MenuProductos.productos)
            {
                if (prod2.Tipo == "Lacteos")
                {
                    int rowindex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowindex].Cells[0].Value = prod2.Idproducto.ToString();
                    dataGridView1.Rows[rowindex].Cells[1].Value = prod2.Nombre.ToString();
                    dataGridView1.Rows[rowindex].Cells[2].Value = prod2.Tipo.ToString();
                    dataGridView1.Rows[rowindex].Cells[3].Value = prod2.Precio.ToString();
                }

            }

        }

        private void frutasYVerdurasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Productos prod3 in MenuProductos.productos)
            {
                if (prod3.Tipo == "Frutas y verduras")
                {
                    int rowindex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowindex].Cells[0].Value = prod3.Idproducto.ToString();
                    dataGridView1.Rows[rowindex].Cells[1].Value = prod3.Nombre.ToString();
                    dataGridView1.Rows[rowindex].Cells[2].Value = prod3.Tipo.ToString();
                    dataGridView1.Rows[rowindex].Cells[3].Value = prod3.Precio.ToString();
                }

            }
        }

        private void carnesYPescadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Productos prod4 in MenuProductos.productos)
            {
                if (prod4.Tipo == "Carnes y pescados")
                {
                    int rowindex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowindex].Cells[0].Value = prod4.Idproducto.ToString();
                    dataGridView1.Rows[rowindex].Cells[1].Value = prod4.Nombre.ToString();
                    dataGridView1.Rows[rowindex].Cells[2].Value = prod4.Tipo.ToString();
                    dataGridView1.Rows[rowindex].Cells[3].Value = prod4.Precio.ToString();
                }

            }
        }

        private void limpiezaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Productos prod5 in MenuProductos.productos)
            {
                if (prod5.Tipo == "Limpieza")
                {
                    int rowindex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowindex].Cells[0].Value = prod5.Idproducto.ToString();
                    dataGridView1.Rows[rowindex].Cells[1].Value = prod5.Nombre.ToString();
                    dataGridView1.Rows[rowindex].Cells[2].Value = prod5.Tipo.ToString();
                    dataGridView1.Rows[rowindex].Cells[3].Value = prod5.Precio.ToString();
                }

            }
        }
        Form2 form = new Form2();
        
        private void button1_Click(object sender, EventArgs e)
        {

            if(dataGridView1.SelectedRows.Count > 0)
            {
                
                    string Idpedido = null;
                    if (contador == 1)
                    {
                        string idus = rec;
                        Idpedido = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        string Nompedido = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        string Tipoprodpedido = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        double Precioprodpedido = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[3].Value);
                        double total = Precioprodpedido * contador;
                        pedido = new Pedido(idus, Idpedido, Nompedido, Tipoprodpedido, Precioprodpedido, contador, total);
                        MenuPedido.añadir(pedido);
                        
                    }
                    else
                    {
                        

                    }
                    
                
               
                

                         
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            FormPedidos frm = new FormPedidos();
            frm.Show();
            frm.visualizar();
            

        }

        private void electronicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Productos prod6 in MenuProductos.productos)
            {
                if (prod6.Tipo == "Electronica")
                {
                    int rowindex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowindex].Cells[0].Value = prod6.Idproducto.ToString();
                    dataGridView1.Rows[rowindex].Cells[1].Value = prod6.Nombre.ToString();
                    dataGridView1.Rows[rowindex].Cells[2].Value = prod6.Tipo.ToString();
                    dataGridView1.Rows[rowindex].Cells[3].Value = prod6.Precio.ToString();
                }

            }
        }

        private void higieneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Productos prod7 in MenuProductos.productos)
            {
                if (prod7.Tipo == "Higiene")
                {
                    int rowindex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowindex].Cells[0].Value = prod7.Idproducto.ToString();
                    dataGridView1.Rows[rowindex].Cells[1].Value = prod7.Nombre.ToString();
                    dataGridView1.Rows[rowindex].Cells[2].Value = prod7.Tipo.ToString();
                    dataGridView1.Rows[rowindex].Cells[3].Value = prod7.Precio.ToString();
                }

            }
        }

        private void embutidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Productos prod8 in MenuProductos.productos)
            {
                if (prod8.Tipo == "Embutidos")
                {
                    int rowindex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowindex].Cells[0].Value = prod8.Idproducto.ToString();
                    dataGridView1.Rows[rowindex].Cells[1].Value = prod8.Nombre.ToString();
                    dataGridView1.Rows[rowindex].Cells[2].Value = prod8.Tipo.ToString();
                    dataGridView1.Rows[rowindex].Cells[3].Value = prod8.Precio.ToString();
                }

            }
        }

        private void hogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Productos prod9 in MenuProductos.productos)
            {
                if (prod9.Tipo == "Hogar")
                {
                    int rowindex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowindex].Cells[0].Value = prod9.Idproducto.ToString();
                    dataGridView1.Rows[rowindex].Cells[1].Value = prod9.Nombre.ToString();
                    dataGridView1.Rows[rowindex].Cells[2].Value = prod9.Tipo.ToString();
                    dataGridView1.Rows[rowindex].Cells[3].Value = prod9.Precio.ToString();
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
