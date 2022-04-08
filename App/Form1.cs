using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        string[] allFilesInFolder = { };

        List<string> UniquefilesCode = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
                textBox1.Text=folderBrowser.SelectedPath;
            else
                MessageBox.Show("please Select folder");


            string folderPath=textBox1.Text;
            if (folderPath !=null)
            {

                 allFilesInFolder=Directory.GetFiles(folderPath);
               
                listBox1.Items.Clear();
                if (allFilesInFolder.Count()>0)
                {
                    foreach (var file in allFilesInFolder)
                    {
                        
                        string code =Helper.GetUntilOrEmpty(Path.GetFileName(file), "_");

                        if (!UniquefilesCode.Contains(code))
                        {
                            UniquefilesCode.Add(code);
                            listBox1.Items.Add(code);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Sorry! no file in this folder");
                }
               
            }


        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           string SearchText= textBox2.Text;
            listBox1.Items.Clear();
            foreach (var code in UniquefilesCode.Where(x => x.Contains(SearchText)))
            {
                listBox1.Items.Add(code);
            }
            
        }
    }
    static class Helper
    {
        public static string GetUntilOrEmpty(this string text, string stopAt = "-")
        {
            if (!String.IsNullOrWhiteSpace(text))
            {
                int charLocation = text.IndexOf(stopAt, StringComparison.Ordinal);

                if (charLocation > 0)
                {
                    return text.Substring(0, charLocation);
                }
            }

            return String.Empty;
        }
    }
}
