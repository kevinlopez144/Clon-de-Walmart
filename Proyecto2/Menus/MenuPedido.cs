using Newtonsoft.Json;
using Proyecto2.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2.Menus
{
    internal class MenuPedido
    {
        public static string rd { get; set; }
        private const string ruta_pedidos = @"C:\Users\usuario\Desktop\Pedidos.json";
        public static List<Pedido> pedidos { get; private set; }
        public static bool estado;
        public static bool estado2;
        public static void Inicializar()
        {
            if (File.Exists(ruta_pedidos))
            {
                string archivo = File.ReadAllText(ruta_pedidos);
                pedidos = JsonConvert.DeserializeObject<List<Pedido>>(archivo);
            }
            else
            {
                pedidos = new List<Pedido>();

            }


        }
        public static void añadir(Pedido pedido)
        {
            pedidos.Add(pedido);
            string agregar = JsonConvert.SerializeObject(pedidos, Formatting.Indented);
            File.WriteAllText(ruta_pedidos, agregar);
            MessageBox.Show("Producto agregado correctamente.", "Hecho");
            

        }
        public static void Eliminar(string idpedido)
        {
            pedidos.RemoveAll(e => e.Idproducto.Equals(idpedido));
            string agregar = JsonConvert.SerializeObject(pedidos, Formatting.Indented);
            File.WriteAllText(ruta_pedidos, agregar);
            MessageBox.Show("Producto eliminado correctamente.", "Hecho");

        }

        public static void Ver(string idus)
        {
            string archivo = File.ReadAllText(ruta_pedidos);
            pedidos = JsonConvert.DeserializeObject<List<Pedido>>(archivo);
            var pedido = pedidos.FirstOrDefault(u => u.Idusuario == idus);
            if (pedido != null)
            {
                rd = idus;
            }
        }

        public static void rep(string idpedido, int cant)
        {
            /*int pe = pedidos.FindIndex(u => u.Idproducto == idpedido && u.Cantidad < cant);
            
            if (pe != -1)
            {
                cant = cant + 1;
            }
            string agregar = JsonConvert.SerializeObject(pedidos, Formatting.Indented);
            File.WriteAllText(ruta_pedidos, agregar);*/
        }

    }
}
