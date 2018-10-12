using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronOcr;

namespace ImageScannerOCRApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            browseButton.DialogResult.ToString();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void outputTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            AutoOcr ocr = new AutoOcr();
            var result = ocr.Read(inputImageTextbox.Text);
            outputTextbox.Text = result.ToString();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            try
            {
                outputTextbox.Clear();
                while (true)
                {
                    var FD = new System.Windows.Forms.OpenFileDialog();
                    if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        string fileType = fileTypeMethod(FD.FileName);
                        if (fileType == "png" || fileType == "jpg" || fileType == "jpeg")
                        {
                            inputImageTextbox.Text = FD.FileName;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Choose a file type of png, jpg, or jpeg");
                            continue;
                        }
                    }
                    else
                    {
                        outputTextbox.Text = "CANCELLED";
                        break;
                    }
                }
            }
            catch (Exception excep)
            {
                outputTextbox.Text = excep.Message + "\n End message \n" + excep.InnerException + "\n End inner exception \n" + excep.StackTrace + "\n End stacktrace";
            }
        }

        public static string fileTypeMethod(string str)
        {
            char[] delimiterChars = { ' ', '-', '.', '_', ':', '\\' };        
            return str.Split(delimiterChars).Last();
        }
    }
}
