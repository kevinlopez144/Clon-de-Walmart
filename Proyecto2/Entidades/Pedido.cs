using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2.Entidades
{
    public class Pedido
    {
        public string Idusuario { get; set; }
        public string Idproducto { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }

        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public double Total { get; set; }

        public Pedido(string idusuario, string idproducto, string nombre, string tipo, double precio, int cantidad, double total)
        {
            Idusuario = idusuario;
            Idproducto = idproducto;
            Nombre = nombre;
            Tipo = tipo;
            Precio = precio;
            Cantidad = cantidad;
            Total = total;
        }
    }
}
