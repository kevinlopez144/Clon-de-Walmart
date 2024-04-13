using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Proyecto2.Entidades
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Idusuario { get; set; }


        public Usuario(string nombre, string idusuario)
        {
            Nombre = nombre;
            Idusuario = idusuario;
            
        }

        internal object FirstOrDefault(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
    

    
}
