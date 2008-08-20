using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using System.Net;
//using System.Net.Sockets;
using System.Diagnostics;

namespace keycapture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //public Socket winsock1 = new Socket();

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //this.label1.Text = e.KeyValue.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'songDataSet.Tbl_Remote2' table. You can move, or remove it, as needed.
            this.tbl_Remote2TableAdapter.Fill(this.songDataSet.Tbl_Remote2);
             //this.Focus();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void tbl_Remote2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tbl_Remote2BindingSource.EndEdit();
                this.tbl_Remote2TableAdapter.Update(this.songDataSet.Tbl_Remote2);
            }
            catch (Exception ei)
            {
                MessageBox.Show(ei.ToString());
            }


        }

        private void tbl_Remote2DataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (tbl_Remote2DataGridView.CurrentCell.ColumnIndex == 1) {
                tbl_Remote2DataGridView.CurrentCell.Value = e.KeyValue.ToString();
                //MessageBox.Show(tbl_Remote2DataGridView.RowCount.ToString());
                //MessageBox.Show(tbl_Remote2DataGridView.CurrentCell.RowIndex.ToString());
                if (tbl_Remote2DataGridView.CurrentCell.RowIndex < tbl_Remote2DataGridView.RowCount-1) {
                    tbl_Remote2DataGridView.CurrentCell=tbl_Remote2DataGridView.Rows[tbl_Remote2DataGridView.CurrentCell.RowIndex + 1].Cells[1];
                }
            }

        }

        private void tbl_Remote2DataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void tbl_Remote2DataGridView_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void tbl_Remote2DataGridView_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }


        private void axIRConnect1_DataReceived(object sender, AxInfrared.__IRConnect_DataReceivedEvent e)
        {
            //this.axIRConnect1.conn.Capture.
           // Process
           // this.axIRConnect1.OpenIR();
            //this.axIRConnect1.Capture.ToString();



            if (tbl_Remote2DataGridView.CurrentCell.ColumnIndex == 2)
            {
                tbl_Remote2DataGridView.CurrentCell.Value = e.ToString();
               // MessageBox.Show(AxInfrared.AxIRConnect.AxIRConnect);
            }
            this.axIRConnect1.CloseIR();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process s = Process.Start("winlirc.exe");
        }

        private void axIRConnect1_Error(object sender, AxInfrared.__IRConnect_ErrorEvent e)
        {
            MessageBox.Show(sender.ToString());

            MessageBox.Show("Please make sure WinLIRC is running. \n" + e.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.axIRConnect1.OpenIR();
            //MessageBox.Show("IR on");
        }


    }
}