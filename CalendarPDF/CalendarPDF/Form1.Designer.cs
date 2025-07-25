namespace CalendarPDF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnUploadPDF = new Button();
            textBox1 = new TextBox();
            WebView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)WebView21).BeginInit();
            SuspendLayout();
            // 
            // BtnUploadPDF
            // 
            BtnUploadPDF.Location = new Point(30, 49);
            BtnUploadPDF.Name = "BtnUploadPDF";
            BtnUploadPDF.Size = new Size(186, 63);
            BtnUploadPDF.TabIndex = 0;
            BtnUploadPDF.Text = "Cargar PDF";
            BtnUploadPDF.UseVisualStyleBackColor = true;
            BtnUploadPDF.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 23);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // WebView21
            // 
            WebView21.AllowExternalDrop = true;
            WebView21.CreationProperties = null;
            WebView21.DefaultBackgroundColor = Color.White;
            WebView21.Location = new Point(267, 12);
            WebView21.Name = "WebView21";
            WebView21.Size = new Size(499, 426);
            WebView21.TabIndex = 2;
            WebView21.ZoomFactor = 1D;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WebView21);
            Controls.Add(textBox1);
            Controls.Add(BtnUploadPDF);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)WebView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnUploadPDF;
        private TextBox textBox1;
        private Microsoft.Web.WebView2.WinForms.WebView2 WebView21;
    }
}
