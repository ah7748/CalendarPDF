using System.Security.Policy;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;

namespace CalendarPDF
{
    public partial class Form1 : Form
    {
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
                    string ruta = dialog.FileName;
                    string content = reader.ReadToEnd();
                    MessageBox.Show("PDF loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    WebView21.Source = new Uri(path);
                    
                }
            }
            else
            {
                MessageBox.Show("No file selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
            

        }
    }
}