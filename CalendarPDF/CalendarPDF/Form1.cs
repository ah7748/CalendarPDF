namespace CalendarPDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                }
            }
            else
            {
                MessageBox.Show("No file selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }






    }
}
