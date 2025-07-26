using System.Drawing.Text;
using System.Security.Policy;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;

namespace CalendarPDF
{
    public partial class Form1 : Form
    {
        private string textoExtraido = "";
        public Form1()
        {
            InitializeComponent();
            WebView21.EnsureCoreWebView2Async();
        }

        private void button1_Click(object sender, EventArgs e) /* Cargar PDF - Upload PDF */
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PDF Files (*.pdf)|*.pdf";
            dialog.Multiselect = false;

            

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String path = dialog.FileName;
                using (StreamReader reader = new StreamReader(path))
                {

                    string content = reader.ReadToEnd();
                    MessageBox.Show("PDF loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    WebView21.Source = new Uri(path);

                    textoExtraido = ExtraccionDatos.ExtraerTextoPlano(path);

                }
            }
            else
            {
                MessageBox.Show("No file selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nombreBuscado = textBox1.Text.Trim();
            richTextBox1.Clear();

            if (!string.IsNullOrEmpty(nombreBuscado) && !string.IsNullOrEmpty(textoExtraido))
            {
                var lineas = textoExtraido.Split('\n');
                int resultadoCount = 0;

                foreach (var linea in lineas)
                {
                    int idx = linea.IndexOf(nombreBuscado, StringComparison.OrdinalIgnoreCase);
                    if(idx >= 0)
                    {
                        
                    }
                }

                if (resultadoCount == 0)
                {
                    richTextBox1.SelectionColor = Color.Gray;
                    richTextBox1.SelectionFont = richTextBox1.Font;
                    richTextBox1.AppendText("No se encontraron coincidencias.");
                }
            }
            else
            {
                richTextBox1.Clear();
            }
        
                
            
        }
    }
}