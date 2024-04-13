using Newtonsoft.Json;
using Proyecto2.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Menus
{
    internal class MenuProductos
    {
        private const string ruta_productos = @"C:\Users\usuario\Desktop\Productos.json";
        public static List<Productos> productos { get; private set; }
        public static void Inicializar()
        {
            if (File.Exists(ruta_productos))
            {
                string archivo = File.ReadAllText(ruta_productos);
                productos = JsonConvert.DeserializeObject<List<Productos>>(archivo);
            }
            else
            {
                productos = new List<Productos>();

            }

        }
        public static void añadir(Productos producto)
        {
            productos.Add(producto);
            string agregar = JsonConvert.SerializeObject(productos, Formatting.Indented);
            File.WriteAllText(ruta_productos, agregar);

        }

        public static void Eliminar(string idprod)
        {
            productos.RemoveAll(e => e.Idproducto.Equals(idprod));
            string agregar = JsonConvert.SerializeObject(productos, Formatting.Indented);
            File.WriteAllText(ruta_productos, agregar);

        }
        public static void Actualizarproducto(string idprodorigen, Productos prodmodificado)
        {
            int indprodoriginal = productos.FindIndex(e => e.Idproducto == idprodorigen);

            if (indprodoriginal != -1)
            {
                productos[indprodoriginal] = prodmodificado;
            }

            string agregar = JsonConvert.SerializeObject(productos, Formatting.Indented);
            File.WriteAllText(ruta_productos, agregar);
        }

        public static void Buscartipoproducto(string tipopro)
        {
            productos.FindIndex(e => e.Tipo == tipopro);

        }

    }
}
