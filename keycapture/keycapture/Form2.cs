using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace keycapture
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tbl_SongBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.tbl_SongBindingSource.EndEdit();
            //this.tbl_SongTableAdapter.Update(this.songDataSet.Tbl_Song);

        }


        private Thread trd;


        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'songDataSet.Tbl_Song' table. You can move, or remove it, as needed.
            //this.tbl_SongTableAdapter.Fill(this.songDataSet.Tbl_Song);

            //progressBar1.Step = 10;
            //progressBar1.Value = progressBar1.Value + 10;

            //if (progressBar1.Value >= 100)
            //{
            //    progressBar1.Value = 0;
            //}
            ////return;
            ////}
            //progressBar1.Value = progressBar1.Value + 5;

            //Thread td1 = new Thread(new ThreadStart(animationcontrol));
            //td1.Start();


            Thread trd = new Thread(new ThreadStart(this.ThreadTask));
            trd.IsBackground = true;
            trd.Start();

           
        }

       


        private void ThreadTask()
        {
            int stp;
            int newval;
            Random rnd = new Random();

            while (true)
            {
                stp = this.progressBar1.Step * rnd.Next(-1, 2);
                newval = this.progressBar1.Value + stp;

                if (newval > this.progressBar1.Maximum)
                    newval = this.progressBar1.Maximum;
                else if (newval < this.progressBar1.Minimum)
                    newval = this.progressBar1.Minimum;

                //unsafe thread
               // this.progressBar1.Value = newval;

                //safe thread
                this.SetText(newval);

                Thread.Sleep(100);
            }
        }



        // This delegate enables asynchronous calls for setting
        // the text property on a TextBox control.
        delegate void SetTextCallback(int text);

        private void SetText(int text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.progressBar1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                //this.textBox1.Text = text;
                this.progressBar1.Value=text;

            }
        }


        //private void updateprogressbar()
        //{

        //    for (int i = 0; i <= 100; i += 1)
        //    {
        //        progressBar1.Value = i;
        //        //Thread.Sleep(1000);
        //    }
        //}

        //private void animationcontrol()
        //{
        //    // Thread.Sleep(500);
        //    updateprogressbar();

        //}


        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    if (progressBar1.Value == 100)
        //        progressBar1.Value = 0;
        //    else
        //        progressBar1.Value = progressBar1.Value + 4;

        //}

        //private void getsocket()
        //{

        //   // System.Net.Sockets.Socket st = new System.Net.Sockets.Socket(System.Net.Sockets.SocketInformation);
        //   // st.Connect("127.0.0.1");
        //   // st.SendTimeout.ToString();
        //   //// Socket st = new 
        //   // st.SendTimeout = 100;
        //   // st.Ttl.ToString();
        //  //  "test".Split('');

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the main thread");
        }


    }
}