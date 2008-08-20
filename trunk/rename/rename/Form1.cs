using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace rename
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //openFileDialog1.FileName = "c:\\kara\\Mapping.exe";
            //openFileDialog1.rena
           // FileStream fs = new FileStream();
            //fs.Name = "c:\\kara\\Mapping.exe";
            string message="";

            try
            {
                FileInfo fi = new FileInfo("\\\\nas-server\\public\\temp\\d.txt");
                fi.MoveTo("\\\\nas-server\\public\\temp\\d.txt---");

                message = "To: " + fi.Name.ToString();
            }
            catch 
            {
                message = "Fail: " + "File not found.";
            }

           richTextBox1.Text = richTextBox1.Text + message + "\n";
        }


        
        private void cleanup()
        {}


        private  bool renameFiles(string folderPath, string findString, string replaceWith)
        {
            bool ret = false;
            try
            {
                DirectoryInfo di = new DirectoryInfo(folderPath);
                string destFileName = "";
                foreach (FileInfo fi in di.GetFiles())
                {
                    if (fi.Name.ToLower().IndexOf(findString) > -1)
                    {
                        destFileName = fi.DirectoryName + "\\" +
                        fi.Name.ToLower().Replace(findString, replaceWith);
                        File.Move(fi.FullName, destFileName);
                    }
                }
                ret = true;
            }
            catch (System.Exception ex)
            {
                throw new ApplicationException("Error in renameFiles", ex);
                
            }
            return ret;
        }

        private void tbl_SongBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_SongBindingSource.EndEdit();
            this.tbl_SongTableAdapter.Update(this.songDataSet.Tbl_Song);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'songDataSet.Tbl_Song' table. You can move, or remove it, as needed.
            this.tbl_SongTableAdapter.Fill(this.songDataSet.Tbl_Song);

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
    }
}