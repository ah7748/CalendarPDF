using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;
using System.Text.RegularExpressions;

namespace CalendarPDF
{
    internal class ExtraccionDatos
    {
        public static string ExtraerTextoPlano(string ruta)
        {
            var textoCompleto = new StringBuilder();
            using (PdfDocument document = PdfDocument.Open(ruta))
            {
                foreach (Page page in document.GetPages())
                {
                    textoCompleto.AppendLine(page.Text);
                }
            }
            return textoCompleto.ToString();
        }
    }
}
