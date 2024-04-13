using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Entidades
{
    public class Productos
    {
        public string Idproducto { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Cantidad { get; set;}
        public double Precio { get; set;}

        public Productos(string idproducto, string nombre, string tipo, int cantidad, double precio)
        {
            Idproducto = idproducto;
            Nombre = nombre;
            Tipo = tipo;
            Cantidad = cantidad;
            Precio = precio;
        }
    }
}
