﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto2.Entidades;
using Newtonsoft.Json;
using System.Text.Json;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Proyecto2.Menus
{
    internal class MenuUsuario
    {
        private const string NombreArchivo = "Usuario.json"; // Nombre del archivo JSON
        private string rutaArchivoJson; // Variable para almacenar la ruta del archivo JSON
        private static string directorioAplicacion = Application.StartupPath;

        public static bool estado;
#pragma warning disable CS0649 // El campo 'MenuUsuario.estado2' nunca se asigna y siempre tendrá el valor predeterminado false
        public static bool estado2;
#pragma warning restore CS0649 // El campo 'MenuUsuario.estado2' nunca se asigna y siempre tendrá el valor predeterminado false
        private static string ruta_usuarios = Path.Combine(directorioAplicacion, NombreArchivo);
        public static List<Usuario> Usuarios { get; private set; }
        public static void Inicializar()
        {
            if (File.Exists(ruta_usuarios))
            {
                string archivo = File.ReadAllText(ruta_usuarios);
                Usuarios = JsonConvert.DeserializeObject<List<Usuario>>(archivo);
            }
            else
            {
                Usuarios = new List<Usuario>();
                File.WriteAllText(ruta_usuarios, "{}");

            }
            
        }

        public static void añadir(Usuario usuario)
        {
            Usuarios.Add(usuario);
            string agregar = JsonConvert.SerializeObject(Usuarios, Formatting.Indented);
            File.WriteAllText(ruta_usuarios, agregar);

        }
        
        public static void Buscar(string nombre, string idusuario)
        {
            string archivo = File.ReadAllText(ruta_usuarios);
            Usuarios = JsonConvert.DeserializeObject<List<Usuario>>(archivo);
            var usuario = Usuarios.FirstOrDefault(u => u.Nombre == nombre && u.Idusuario == idusuario);
            

            if (usuario != null)
            {
                // Si se encuentra el usuario, mostrar mensaje de confirmacion
                MessageBox.Show("Datos registrados", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                estado = true;
            }
            else
            {
                // Si no se encuentra el usuario, mostrar un error
                MessageBox.Show("No se encontró ningún usuario con el nombre e ID especificados.", "Búsqueda Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                estado = false;
            }

        }


    }
}
