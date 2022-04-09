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
            listBox1.Text=String.Empty;
            UniquefilesCode.Clear();


        }

        string[] allFilesInFolder = { };

        List<string> UniquefilesCode = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                UniquefilesCode.Clear();


                FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                    textBox1.Text=folderBrowser.SelectedPath;
                else
                    MessageBox.Show("please Select folder");


                string folderPath = textBox1.Text;
                if (folderPath !=null)
                {


                    allFilesInFolder=Directory.GetFiles(folderPath);

                    listBox1.Items.Clear();
                    if (allFilesInFolder.Count()>0)
                    {

                        foreach (var file in allFilesInFolder)
                        {

                            string code = Helper.FindCode(Path.GetFileName(file));
                            UniquefilesCode.Add(code);
                                
                        }

                        foreach (var item in UniquefilesCode.Distinct().ToArray())
                        {
                            listBox1.Items.Add(item);
                        }

                        label3.Text=Convert.ToString(listBox1.Items.Count);
                    }
                    else
                    {
                        MessageBox.Show("Sorry! no file in this folder");
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            try
            {
                string SearchText = textBox2.Text.ToLower();
                listBox1.Items.Clear();
                foreach (var code in UniquefilesCode.Where(x => x.Contains(SearchText)))
                {
                    listBox1.Items.Add(code.ToLower());
                }

                label3.Text=Convert.ToString(listBox1.Items.Count);
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UniquefilesCode.Clear();

                string folderPath = textBox1.Text;
                if (folderPath !=null)
                {


                    allFilesInFolder=Directory.GetFiles(folderPath);

                    listBox1.Items.Clear();
                    if (allFilesInFolder.Count()>0)
                    {

                        foreach (var file in allFilesInFolder)
                        {

                            string code = Helper.FindCode(Path.GetFileName(file));

                            if (!UniquefilesCode.Contains(code))
                            {
                                UniquefilesCode.Add(code);
                                listBox1.Items.Add(code);
                            }
                        }

                        label3.Text=Convert.ToString(listBox1.Items.Count);
                    }
                    else
                    {
                        MessageBox.Show("Sorry! no file in this folder");
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    static class Helper
    {
        public static string FindCode(this string text)
        {
            string stopAt = String.Empty;
            var listOfSpecialCharecter = new[] {"_", "-", "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(",")", "+", "=", @"\"};
            bool isTrue = false;
            foreach (var specialCharecter in listOfSpecialCharecter)
            {
                isTrue=specialCharecter.Any(text.Contains);
                if (isTrue)
                {
                    stopAt=specialCharecter;
                }
               
            }

 
          

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
