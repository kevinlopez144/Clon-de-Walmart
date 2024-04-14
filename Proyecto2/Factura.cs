using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;

namespace Proyecto2
{
    internal class Factura
    {
       private void crearFactura() 
        {

            // Crear documento PDF
            iTextSharp.text.Document doc = new iTextSharp.text.Document();
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Configurar el cuadro de diálogo de guardado
            saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*";
            saveFileDialog.Title = "Guardar factura como PDF";
            saveFileDialog.FileName = "factura.pdf"; // Nombre de archivo predeterminado

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                PdfWriter.GetInstance(doc, new FileStream(filename, FileMode.Create));
                doc.Open();

                // Agregar contenido a la factura
                doc.Add(new Paragraph("Factura"));
                doc.Add(new Paragraph("==================="));
                doc.Add(new Paragraph($"Cliente: "));
                doc.Add(new Paragraph($"Fecha: "));
                doc.Add(new Paragraph("==================="));
                doc.Add(new Paragraph("Productos:"));
                doc.Add(new Paragraph($""));
                doc.Add(new Paragraph("==================="));
                doc.Add(new Paragraph($"Total: "));

                doc.Close();

                MessageBox.Show("Factura generada exitosamente y guardada como PDF.");
            }

        }

    }
}
