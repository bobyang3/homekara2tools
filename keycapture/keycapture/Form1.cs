//// check here for open office with VS 
//http://support.microsoft.com/default.aspx?scid=kb;en-us;317114
//http://support.microsoft.com/kb/306683/
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection; 
using Microsoft.Office.Core;
using Access = Microsoft.Office.Interop.Access;



namespace keycapture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //public Socket winsock1 = new Socket();

        private bool PorgressBarRunning = false;
        int currentRow;
        int currentColumn;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //this.label1.Text = e.KeyValue.ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'songDataSet.Tbl_Song' table. You can move, or remove it, as needed.
            this.tbl_SongTableAdapter.Fill(this.songDataSet.Tbl_Song);
            //// TODO: This line of code loads data into the 'songDataSet.PhonSpell' table. You can move, or remove it, as needed.
            //this.phonSpellTableAdapter.Fill(this.songDataSet.PhonSpell);
            //// TODO: This line of code loads data into the 'songDataSet.PhonSpell' table. You can move, or remove it, as needed.
            //this.phonSpellTableAdapter.Fill(this.songDataSet.PhonSpell);
            // TODO: This line of code loads data into the 'songDataSet.PhonSpell' table. You can move, or remove it, as needed.
            this.phonSpellTableAdapter.Fill(this.songDataSet.PhonSpell);
            // TODO: This line of code loads data into the 'songDataSet.Tbl_Singer' table. You can move, or remove it, as needed.
            //this.tbl_SingerTableAdapter.Fill(this.songDataSet.Tbl_Singer);
            // TODO: This line of code loads data into the 'songDataSet.Tbl_Extension' table. You can move, or remove it, as needed.
            //this.tbl_ExtensionTableAdapter.Fill(this.songDataSet.Tbl_Extension);
            //// TODO: This line of code loads data into the 'songDataSet.PhonSpell' table. You can move, or remove it, as needed.
            //this.phonSpellTableAdapter.Fill(this.songDataSet.PhonSpell);
            //// TODO: This line of code loads data into the 'songDataSet.Tbl_KeyName' table. You can move, or remove it, as needed.
            //this.tbl_KeyNameTableAdapter.Fill(this.songDataSet.Tbl_KeyName);
            // TODO: This line of code loads data into the 'songDataSet.Tbl_Remote2' table. You can move, or remove it, as needed.
            this.tbl_Remote2TableAdapter.Fill(this.songDataSet.Tbl_Remote2);

            // TODO: This line of code loads data into the 'songDataSet.Tbl_Singer' table. You can move, or remove it, as needed.
           // this.tbl_SingerTableAdapter.Fill(this.songDataSet.Tbl_Singer);


            // TODO: This line of code loads data into the 'songDataSet.Tbl_Singer' table. You can move, or remove it, as needed.
            this.tbl_SingerTableAdapter.Fill(this.songDataSet.Tbl_Singer);

            // TODO: This line of code loads data into the 'songDataSet.Tbl_Song' table. You can move, or remove it, as needed.
            this.tbl_SongTableAdapter.Fill(this.songDataSet1.Tbl_Song);
            //this.tbl_SongTableAdapter.Fill(this.songDataSet.Tbl_Song);

             //this.Focus();

            //Thread trd = new Thread(new ThreadStart(this.ThreadTask));
            //trd.IsBackground = true;
            //trd.Start();
        }

        private void tbl_SongBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_SongBindingSource.EndEdit();
            this.tbl_SongTableAdapter.Update(this.songDataSet.Tbl_Song);

        }

        private void tbl_SingerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_SingerBindingSource.EndEdit();
            this.tbl_SingerTableAdapter.Update(this.songDataSet.Tbl_Singer);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void checkForDuplicated(DataGridView dgv, string currentValue, int currentLocation) {
            for (int i = currentLocation+1; i < dgv.RowCount-1; i++)
            {
                if (currentValue==dgv.Rows[i].Cells[1].Value.ToString())
                {
                    dgv.Rows[i].Cells[0].Style.BackColor = Color.Pink;
                    remote2duplicates = true;                
                }


            }

        }

        Boolean remote2duplicates = false;

        private void tbl_Remote2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            //DataSource;
            //DataView dv = (DataView)tbl_Remote2DataGridView.DataSource;
            //DataTable dt = dv.ToTable();
            //MessageBox.Show(dt.Rows[0][0].ToString());

            //string[] fieldstring= new string[tbl_Remote2DataGridView.RowCount+100];

            remote2duplicates = false;

            for (int i = 0; i < tbl_Remote2DataGridView.RowCount - 1; i++)
            {
                tbl_Remote2DataGridView.Rows[i].Cells[0].Style.BackColor = Color.White;
            }

            for (int i=0; i<tbl_Remote2DataGridView.RowCount-1;i++)
            {
                checkForDuplicated(tbl_Remote2DataGridView, tbl_Remote2DataGridView.Rows[i].Cells[1].Value.ToString(), i);            
            }




            DialogResult dlgRes = DialogResult.No; //;= null;


            if (remote2duplicates == true)
            {
                dlgRes = MessageBox.Show("資料重複,確定要紀錄嗎?", "save data?", MessageBoxButtons.YesNoCancel);
            }
            else
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

            //MessageBox.Show(remote2duplicates.ToString());


            if (dlgRes == DialogResult.Yes)
            {
                // Application.Exit();
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





        }

        private void tbl_Remote2DataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            
 

        }

        private void tbl_Remote2DataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void tbl_Remote2DataGridView_KeyUp(object sender, KeyEventArgs e)
        {
          //  MessageBox.Show(e.KeyValue.ToString());

            if (currentRow < tbl_Remote2DataGridView.RowCount-1)
            {
                tbl_Remote2DataGridView.CurrentCell = tbl_Remote2DataGridView.Rows[currentRow].Cells[1];
            }
        
        }

        //private void tbl_Remote2DataGridView_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        //{
        //    if (tbl_Remote2DataGridView.CurrentCell.ColumnIndex == 1)
        //    {
        //        tbl_Remote2DataGridView.CurrentCell.Value = e.KeyValue.ToString();
        //        //MessageBox.Show(tbl_Remote2DataGridView.RowCount.ToString());
        //        //MessageBox.Show(tbl_Remote2DataGridView.CurrentCell.RowIndex.ToString());
        //        label1.Text = e.KeyCode.ToString();
        //        if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
        //        {
        //            return;
        //        }
        //        if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
        //        {
        //            //tbl_Remote2DataGridView.CurrentCell = tbl_Remote2DataGridView.Columns[1].cells[.cell.Columns[[1].cel;
        //        }
        //        if (e.KeyCode == Keys.Up)
        //        {
        //            tbl_Remote2DataGridView.CurrentCell = tbl_Remote2DataGridView.Rows[tbl_Remote2DataGridView.CurrentCell.RowIndex + 1].Cells[1];
        //        }
        //        if (tbl_Remote2DataGridView.CurrentCell.RowIndex < tbl_Remote2DataGridView.RowCount - 1)
        //        {
        //            tbl_Remote2DataGridView.CurrentCell = tbl_Remote2DataGridView.Rows[tbl_Remote2DataGridView.CurrentCell.RowIndex + 1].Cells[1];

        //        }
        //    }

        //}


        //private void axIRConnect1_DataReceived(object sender, AxInfrared.__IRConnect_DataReceivedEvent e)
        //{
        //    //this.axIRConnect1.conn.Capture.
        //   // Process
        //   // this.axIRConnect1.OpenIR();
        //    //this.axIRConnect1.Capture.ToString();



        //    if (tbl_Remote2DataGridView.CurrentCell.ColumnIndex == 2)
        //    {
        //        tbl_Remote2DataGridView.CurrentCell.Value = e.ToString();
        //    }
        //    //this.axIRConnect1.CloseIR();

        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process s = Process.Start("winlirc.exe");
        }

        //private void axIRConnect1_Error(object sender, AxInfrared.__IRConnect_ErrorEvent e)
        //{
        //    MessageBox.Show("Please make sure WinLIRC is running. \n" + e.ToString());
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            //this.axIRConnect1.OpenIR();
        }

        private void tbl_KeyNameDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public string Left(string param, int length)
        {
            //we start at 0 since we want to get the characters starting from the
            //left and with the specified lenght and assign it to a variable
            string result = param.Substring(0, length);
            //return the result of the operation
            return result;
        }
        public string Right(string param, int length)
        {
            //start at the index based on the lenght of the sting minus
            //the specified lenght and assign it a variable
            string result = param.Substring(param.Length - length, length);
            //return the result of the operation
            return result;
        }
        

        private string passFullWord(string st)
        {
            string newst = "";            

            for (int i=0;i<st.Length; i++ )
            {
                try
                {
                    getPhonSpell(Right(Left(st, i + 1), 1));

                    if (spell1TextBox.Text.Trim().Length <= 0)
                    { newst = newst + Right(Left(st, i + 1), 1); }
                    else
                    {
                        newst = newst + spell1TextBox.Text;
                    }
                }
                catch { }
            }
            return newst;        
        }


        private void getPhonSpell(string stWord) {
            try
            {
                phonSpellTableAdapter.FillBy(songDataSet.PhonSpell, stWord);
                //phonSpellBindingSource.Filter = "Word = '"+ stWord+"'";
                //phonSpellBindingSource.Filter = 
                //DataView dv = phonSpellBindingSource.sou


                //this is needed to update the thread in the text box
                if (songDataSet.PhonSpell.Rows[0][2] != null || songDataSet.PhonSpell.Rows[0][2]=="")  //the first row for the return word
                {
                    SetText(songDataSet.PhonSpell.Rows[0][2].ToString());
                   // SetText(songDataSet.PhonSpell.Rows[0][2].ToString());
                    //Console.WriteLine(songDataSet.PhonSpell.Rows[0][2].ToString());
                }
                else
                {
                  //  SetText("");
                }
            }
            catch {
                //if nothing in found in the FillBy, it will jump to here as an error.
                SetText(stWord);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (PorgressBarRunning == false)
            {

                MessageBox.Show("The process may take long. please wait, it may seem like crashed but it is not. \n 請稍等，他會像是當機，可是是在實行中，看有多少要改，可能會花上幾分鐘.");

                //Program.startProcessBarForm();
                //Program.showForm2();


                //Thread trd = new Thread(new ThreadStart(this.ThreadTask));
                //trd.IsBackground = true;
                //trd.Start();
                //Form3 f3 = new Form3();
                //f3.Show();


                //for (int i = 0; i < this.dataGridView1.RowCount - 1; i++)
                ////   for (int i = 0; i < 10 - 1; i++)
                //{
                //    Console.WriteLine(this.dataGridView1[1, i].Value.ToString());
                //    //Console cs = new console
                //    //f3.textBox1.Text = this.dataGridView1[1, i].Value.ToString();
                //    this.dataGridView1[2, i].Value = passFullWord(this.dataGridView1[1, i].Value.ToString());

                //    // dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex + 1].Cells[1];
                //    //MessageBox.Show(this.dataGridView1[1,i].Value.ToString());
                //    //Program.fm2.label1.Text = this.dataGridView1[1, i].Value.ToString();
                //}

                this.progressBar1.Maximum = this.dataGridView1.RowCount;

                // Form1 fm1 = this;
                //Thread trd = new Thread(new ParameterizedThreadStart(ThreadTask));
                // Thread trd = new Thread(new ParameterizedThreadStart(ThreadTask));
                trd = new Thread(new ThreadStart(ThreadTask));
                //  trd.IsBackground = true;
                trd.Start();
                //// trd.Join();


                // Form2 fm = new Form2();
                //fm.Show();

                //  this.phonSpellTableAdapter.FillBy(songDataSet.PhonSpell,"裡");

                // this.tbl_SingerTableAdapter.Fill(this.songDataSet.Tbl_Singer);
                //this.phonSpellTableAdapter.Fill(this.songDataSet.PhonSpell);
                PorgressBarRunning = true;
            }

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }


        Thread trd2;

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (PorgressBarRunning == false)
            {
                MessageBox.Show("The process may take long. please wait, it may seem like crashed but it is not. \n 請稍等，他會像是當機，可是是在實行中，看有多少要改，可能會花上幾分鐘.");
                this.progressBar1.Maximum = this.tbl_SongDataGridView.RowCount;
                trd2 = new Thread(new ThreadStart(ThreadTask2));
                trd2.Start();
                PorgressBarRunning = true;
            }
            else
            {
             //   MessageBox.Show("other thread is running");
            }
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Program.startProcessBarForm();
            Program.showForm2();
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        if (components != null)
        //        {
        //            components.Dispose();
        //        }
        //    }
        //    base.Dispose(disposing);
        //}

        private string GetRemoteString(string strSongNumber)
        {
            string RecievedString = "";


            string sendStr = "a ";

            if (strSongNumber.ToLower() == "test".ToLower())
            {
                sendStr = "hello!This is a test test";
            }
            else if (strSongNumber.Length <= 1)
            {
                sendStr = "hello!This is a test test";
                MessageBox.Show("Song Number must be more than 2 digits.");
                //return;
            }
            else
            {
                sendStr = "a " + strSongNumber.ToString().Trim();
            }


            c.Connect(ipe);

            byte[] bs = Encoding.ASCII.GetBytes(sendStr + "\n\r");
            c.Send(bs, bs.Length, 0);
            //c.Send(bs);
            string recvStr = "";
            byte[] recvBytes = new byte[1024];
            int bytes;
            //bytes = c.Receive(recvBytes, recvBytes.Length, 0);
            //    bytes = c.Receive(recvBytes);
            //    recvStr += Encoding.ASCII.GetString(recvBytes, 0, bytes);
            //MessageBox.Show(recvStr);
            //MessageBox.Show("Test Successfully!");
            if (strSongNumber.ToLower() == "test".ToLower())
            {
                MessageBox.Show("Test Successfully!");
                // MessageBox.Show(recvStr);
            }
            else if (strSongNumber.Length <= 1)
            {
                //MessageBox.Show("Test Successfully!");
                //MessageBox.Show("Song Number must be more than 2 digits.");
                //return;
            }
            else
            {
                //richTextBoxinfo.Text = textBoxSongNumber.Text + " is added. \nPlease check the TV screen.";
                // richTextBoxinfo.Text = textBoxSongNumber.Text + " is added. \nPlease check the TV screen.";

            }


            return RecievedString;
//            c.Close();

        }

        private Socket c;
        private IPHostEntry ipHostInfo;
        private IPAddress ip;
        private IPEndPoint ipe;
        private bool button3FirstWords = true;
        private AsyncCallback callbackProc;

        private void closeConnection()
        {
            c.Close();
            button3.Enabled = true;
        }

        private void openConnection(string strServer, string strPort)
        {
            //string capturedString = "";

            try
            {
                int port = 0;
                try
                {
                    port = int.Parse(strPort);
                }
                catch
                {
                    MessageBox.Show("Port must be Number Only.");
                    return;
                }

                string host = strServer;

                ipHostInfo = Dns.Resolve(host);
                ip = ipHostInfo.AddressList[0];

                //IPAddress ip = IPAddress.Parse(host);
                ipe = new IPEndPoint(ip, port);



               // Socket 
               c = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


               //// This is a non blocking IO
               //c.Blocking = false;
               //// Assign Callback function to read from Asyncronous Socket
               //callbackProc = new AsyncCallback(ConnectCallback);
               //// Begin Asyncronous Connection
               //c.BeginConnect(ipe, callbackProc, c);
               
            }

            catch (ArgumentNullException e)
            {
                MessageBox.Show("ArgumentNullException: {0}" + e.ToString());
                button3.Enabled = true;

            }
            catch (SocketException e)
            {
                MessageBox.Show("Connection Fails!...Please check \n1. Winlirc is running\n2. Firewall is open.\n");
                button3.Enabled = true;
            }
            //Console.ReadLine(); 

        }
        //Byte[] m_byBuff = new Byte[32767];

        //public void ConnectCallback(IAsyncResult ar)
        //{
        //    try
        //    {
        //        // Get The connection socket from the callback
        //        Socket sock1 = (Socket)ar.AsyncState;
        //        if (sock1.Connected)
        //        {
        //            // Define a new Callback to read the data
        //            AsyncCallback recieveData = new AsyncCallback(OnRecievedData);
        //            // Begin reading data asyncronously
        //            sock1.BeginReceive(m_byBuff, 0, m_byBuff.Length, SocketFlags.None, recieveData, sock1);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(this, ex.Message, "Setup Recieve callbackProc failed!");
        //    }
        //}


        private void button3_Click_1(object sender, EventArgs e)
        {
            openConnection("127.0.0.1", "8765");
            //button3.Enabled = false;
            changebutton3FirstWords();
        }

        private void changebutton3FirstWords()
        {
            if (button3FirstWords == true)
            {
                button3.Text = "close connection";
                button3FirstWords = false;
            }
            else
            {
                button3.Text = "open connection";
                button3FirstWords = true;
            }
        }


        //delegate void CalcPiDelegate(int digits);

        Thread trd;

        private void button4_Click(object sender, EventArgs e)
        { 
            this.progressBar1.Maximum = this.dataGridView1.RowCount;

            //Form1 fm1 = this;
            //Thread trd = new Thread(new ParameterizedThreadStart(ThreadTask));
            // Thread trd = new Thread(new ParameterizedThreadStart(ThreadTask));
            trd = new Thread(new ThreadStart(ThreadTask));
            //  trd.IsBackground = true;
            trd.Start();
            //// trd.Join();
        }
        
        //private void getconvertingwords()
        //{
        //    for (int i = 0; i < this.dataGridView1.RowCount - 1; i++)
        //    //   for (int i = 0; i < 10 - 1; i++)
        //    {
        //        try
        //        {
        //            dataGridView1[2, i].Value = passFullWord(dataGridView1[1, i].Value.ToString());

        //        }
        //        catch { }

        //        //MessageBox.Show(this.dataGridView1[1,i].Value.ToString());
        //        //Program.fm2.label1.Text = this.dataGridView1[1, i].Value.ToString();
        //    }
        //}
        
        //void CalcPi(int digits)
        //{
        //   // StringBuilder pi = new StringBuilder("3", digits + 2);
        //    int stp;
        //    int newval;
        //    // Show progress
        //  //  ShowProgress(pi.ToString(), digits, 0);

        //    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
        //    //   for (int i = 0; i < 10 - 1; i++)
        //    {
        //        try
        //        {
        //            // Console.WriteLine(this.dataGridView1[1, i].Value.ToString());
        //            dataGridView1[2, i].Value = passFullWord(dataGridView1[1, i].Value.ToString());
        //            //MessageBox.Show(dataGridView1[2, i].Value.ToString());

        //           // phonSpellBindingSource.s

        //            newval = i + 1;


        //            if (newval > progressBar1.Maximum)
        //                newval = progressBar1.Maximum;
        //            else if (newval < progressBar1.Minimum)
        //                newval = progressBar1.Minimum;

        //            //unsafe thread
        //            // this.toolStripProgressBar1.Value = newval;

        //            //safe thread
        //            SetText(newval.ToString());


        //        }
        //        catch { }

        //        //MessageBox.Show(this.dataGridView1[1,i].Value.ToString());
        //        //Program.fm2.label1.Text = this.dataGridView1[1, i].Value.ToString();
        //    }

        //}

        private  void ThreadTask()
        {
            int newval;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            //   for (int i = 0; i < 10 - 1; i++)
            {
                try
                {
                    dataGridView1[2, i].Value = passFullWord(dataGridView1[1, i].Value.ToString());

                    newval = i+1;                    

                    if (newval > progressBar1.Maximum)
                        newval = progressBar1.Maximum;
                    else if (newval < progressBar1.Minimum)
                        newval = progressBar1.Minimum;

                    ShowProgress(newval);
                }
                catch { }
            }

            ShowProgress(progressBar1.Maximum);
            PorgressBarRunning = false;
            MessageBox.Show("Singer Spelling Finished: \nPlease remember to save if you like the result!!");
        }

        private void ThreadTask2()
        {
            int newval;
            //this.tbl_SongDataGridView.Enabled = false;

            for (int i = 0; i < this.tbl_SongDataGridView.RowCount - 1; i++)
            // for (int i = 0; i < 10 - 1; i++)
            {
                 //MessageBox.Show(this.dataGridView1[1,i].Value.ToString());
                try
                {
                    this.tbl_SongDataGridView[2, i].Value = passFullWord(this.tbl_SongDataGridView[1, i].Value.ToString());
                   // this.tbl_SongDataGridView.CurrentCell = this.tbl_SongDataGridView[2,i];
              
                    newval = i + 1;

                    if (newval > progressBar1.Maximum)
                        newval = progressBar1.Maximum;
                    else if (newval < progressBar1.Minimum)
                        newval = progressBar1.Minimum;

                    ShowProgress(newval);
                }
                catch { }

            }

            ShowProgress(progressBar1.Maximum);
            PorgressBarRunning = false;
            this.tbl_SongDataGridView.Enabled = true;
            MessageBox.Show("Song Title Spelling Finished: \nPlease remember to save if you like the result!!");
        }

        //delegate void setSpell1TextBox(string text1);
        //private void setText2(string text1)
        //{
        //    if (spell1TextBox.InvokeRequired)
        //    {
        //        setSpell1TextBox s = new setSpell1TextBox(text1);
        //        invoke(s, new objectp[] { text1 });
        //    }
        //    else
        //    {
        //    spell1TextBox.Text=text1;
        //    }

        //}



        // This delegate enables asynchronous calls for setting
        // the text property on a TextBox control.

        //delegate void SetTextCallback2(int text);

        //private void SetText2(int text)
        //{
        //    // InvokeRequired required compares the thread ID of the
        //    // calling thread to the thread ID of the creating thread.
        //    // If these threads are different, it returns true.

        //    if (progressBar1.InvokeRequired)
        //    {
        //        SetTextCallback d2 = new SetTextCallback(SetText);
        //        Invoke(d2, new object[] { text });
        //       // Console.WriteLine(spell1TextBox.Text);
        //    }
        //    else
        //    {
        //        //progressBar1.Value = text;
        //        progressBar1.Value = text;
        //    }
        //}


        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.

            try
            {
                if (spell1TextBox.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(SetText);
                    Invoke(d, new object[] { text });
                    //  Console.WriteLine(spell1TextBox.Text);
                }
                else
                {
                    //progressBar1.Value = text;
                    spell1TextBox.Text = text;
                }
            }
            catch { }
        }



        delegate void ShowProgressDelegate(int digitsSoFar);

        void ShowProgress(int digitsSoFar)
        {
            // Make sure we're on the right thread
            if (progressBar1.InvokeRequired == false)
            {
                //_pi.Text = pi;
                //progressBar1.Maximum = totalDigits;
                progressBar1.Value = digitsSoFar;
            }
            else
            {
                // Show progress asynchronously
                ShowProgressDelegate showProgress = new ShowProgressDelegate(ShowProgress);
                //Invoke(showProgress, new object[] { pi, totalDigits, digitsSoFar});
                BeginInvoke(showProgress, new object[] { digitsSoFar });
            }
        }

        private void tbl_SongDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
           // Console.WriteLine("song: there is error, but don't pop up the error message.");
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
          //  Console.WriteLine("singer: there is error, but don't pop up the error message.");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            //ProcessDirectory(@"C:\kara\");

        }


        public void ProcessDirectory(string targetDirectory)
        {

            // Process the list of files found in the directory
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
            {
                //ProcessFile(fileName);
                string[] extensions= new string[] {".exe", ".dll"};
                string extension = Path.GetExtension(fileName);
                for (int i = 0; i < extensions.Length; i++)
                {
                    if (extension == extensions[i])
                    {
                        Console.WriteLine("GetExtension('{0}') returns '{1}'", fileName, extension);
                        //return;
                    }
                }

                //Console.WriteLine(fileName);
            }

            // Recurse into subdirectories of this directory;
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
            {
                ProcessDirectory(subdirectory);
            }
        }

        //private string[] covertDataGridView2Array()
        //{
        //  //  List lt = new List();
            
        //  //  string[] 
        //    return 0;

        //}

        private void tbl_Remote2BindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            ////DataSource;
            //MessageBox.Show(tbl_Remote2DataGridView.Rows[0].Cells[0].ToString());


            //DialogResult dlgRes; //;= null;
            //dlgRes = MessageBox.Show("are you sure you want to save", "save data?", MessageBoxButtons.YesNoCancel);


            //if (dlgRes == DialogResult.Yes)
            //{
            //    // Application.Exit();
            //}

        }

        private void tbl_Remote2DataGridView_KeyDown_1(object sender, KeyEventArgs e)
        {
            this.currentRow = tbl_Remote2DataGridView.CurrentCell.RowIndex+1;

            if (tbl_Remote2DataGridView.CurrentCell.ColumnIndex == 1)
            {
                tbl_Remote2DataGridView.CurrentCell.Value = e.KeyValue.ToString();
                //MessageBox.Show(tbl_Remote2DataGridView.RowCount.ToString());
                //MessageBox.Show(tbl_Remote2DataGridView.CurrentCell.RowIndex.ToString());
                label1.Text = e.KeyCode.ToString();
                //if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                //{
                //    return;
                //}
                //if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                //{
                //    //tbl_Remote2DataGridView.CurrentCell = tbl_Remote2DataGridView.Columns[1].cells[.cell.Columns[[1].cel;
                //}
                //if (e.KeyCode == Keys.Up)
                //{
                //    tbl_Remote2DataGridView.CurrentCell = tbl_Remote2DataGridView.Rows[tbl_Remote2DataGridView.CurrentCell.RowIndex + 1].Cells[1];
                //}
                //if (tbl_Remote2DataGridView.CurrentCell.RowIndex < tbl_Remote2DataGridView.RowCount - 1)
                //{
                //    tbl_Remote2DataGridView.CurrentCell = tbl_Remote2DataGridView.Rows[tbl_Remote2DataGridView.CurrentCell.RowIndex + 1].Cells[1];

                //}
            }
        }

        Thread trd3;

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (PorgressBarRunning == false)
            {
                MessageBox.Show("請先將song.mbd做一份備份!");
                this.progressBar1.Maximum = this.tbl_SongDataGridView.RowCount;
               // tbl_SongDataGridView.DataSource = songDataSet.Tbl_Song;
                trd3 = new Thread(new ThreadStart(ThreadTask3));
                trd3.Start();
                PorgressBarRunning = true;
               
            }
            else
            {
                //   MessageBox.Show("other thread is running");
            }
        }


        private void ThreadTask3()
        {
            //this.tbl_SongDataGridView.Enabled = false;
            int newval;
            int totalsongremoved = 0;
            int currentrealROW = 0;
            //this.tbl_SongDataGridView.Enabled = false;
            //int totalRow = this.tbl_SongDataGridView.RowCount;
            int totalRow = songDataSet.Tbl_Song.Rows.Count;

           // songDataSet.Tbl_Song.Rows.RemoveAt();

            for (int i = 0; i < totalRow - 1; i++)
            // for (int i = 0; i < 10 - 1; i++)
            {
                //MessageBox.Show(this.dataGridView1[1,i].Value.ToString());
                try
                {
                    currentrealROW = currentrealROW + 1;
                    //this.tbl_SongDataGridView[3, i].Value = passFullWord(this.tbl_SongDataGridView[1, i].Value.ToString());
                    // this.tbl_SongDataGridView.CurrentCell = this.tbl_SongDataGridView[2,i];
                    //if (System.IO.File.Exists(this.tbl_SongDataGridView[3, i].Value.ToString().Trim()) == false)
                    if (System.IO.File.Exists(songDataSet1.Tbl_Song[i][3].ToString().Trim()) == false)
                    {
                        //this.tbl_SongDataGridView[3, i].RowIndex.
                        //this.tbl_SongDataGridView.Rows.RemoveAt(i);
                        //songDataSet1.Tbl_Song.Rows.RemoveAt(i);
                        songDataSet1.Tbl_Song.Rows.Find(songDataSet1.Tbl_Song[i][0]).Delete();
                       // tbl_SongBindingSource1.RemoveAt(i);
                        i = i - 1;
                        totalsongremoved = totalsongremoved + 1;
                    }


                    newval = currentrealROW + 1;

                    if (newval > progressBar1.Maximum)
                        newval = progressBar1.Maximum;
                    else if (newval < progressBar1.Minimum)
                        newval = progressBar1.Minimum;

                    ShowProgress(newval);
                }
                catch { }

            }

            ShowProgress(progressBar1.Maximum);
            PorgressBarRunning = false;
            this.tbl_SongDataGridView.Enabled = true;
            MessageBox.Show("Song Location Check Finished: \nRemoved entry: " + totalsongremoved.ToString() + "\n");

            try
            {
                songDataSet = songDataSet1;
                tbl_SongBindingSource1.DataSource = songDataSet;
                this.Validate();
                this.tbl_SongBindingSource.EndEdit();
                this.tbl_SongTableAdapter.Update(this.songDataSet.Tbl_Song);

                this.tbl_SongDataGridView.Refresh();
            }
            catch { }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //this.tbl_SongDataGridView.Refresh();
            //tbl_SongDataGridView.DataSource = null;
            //this.songDataSet1 = this.songDataSet;
            //songDataSet1 = this.songDataSet.Clone();
            //tbl_SongBindingSource1.DataSource = this.songDataSet;
            songDataSet = songDataSet1;
            //MessageBox.Show(songDataSet.Tbl_Song.Count.ToString());
            //MessageBox.Show(songDataSet1.Tbl_Song.Count.ToString());
            //tbl_SongDataGridView.DataSource = songDataSet.Tbl_Song;
            tbl_SongBindingSource1.DataSource = songDataSet;
                //this.tbl_SongTableAdapter.Update(this.songDataSet1.Tbl_Song);
            //this.tbl_SongTableAdapter.Update(this.songDataSet.Tbl_Song);
            this.Validate();
            this.tbl_SongBindingSource.EndEdit();
            this.tbl_SongTableAdapter.Update(this.songDataSet.Tbl_Song);

            this.tbl_SongDataGridView.Refresh();




        }

//        Access.Application oAccess = null;
//        oAccess = new Access.ApplicationClass();
//        // Open a database in exclusive mode:
//oAccess.OpenCurrentDatabase(
//        "c:\\mydb.mdb", //filepath
//   true //Exclusive
   //);

        private string msAction = null;
        // Commonly-used variable for optional arguments:
        private object moMissing = System.Reflection.Missing.Value;

        private void NAR(object o)
        {
            // Releases the Automation object.
            try // use try..catch in case o is not set
            {
                Marshal.ReleaseComObject(o);
            }
            catch { }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Access.Application oAccess = null;
            Access.Form oForm = null;
            Access.Controls oCtls = null;
            Access.Control oCtl = null;
            string sDBPath = null; //path to Northwind.mdb
            string sForm = null; //name of form to show


            //E:\_HD_\HD1\_Projects_\Homekara2\keycapture\keycapture\bin\Release\(print)song.mdb


            // Enable exception handler:
        // try
         //{
            sForm = "Form2";

            // Start a new instance of Access for Automation:
            Access.ApplicationClass oAccess = new Access.ApplicationClass();
            //oAccess.Visible = true;

            // Make sure Access is visible:
   //         if(!oAccess.Visible) oAccess.Visible = true;

            // Determine the path to Northwind.mdb:
     //       sDBPath = oAccess.SysCmd(Access.AcSysCmdAction.acSysCmdAccessDir,
      //         moMissing, moMissing).ToString();
     //       sDBPath = sDBPath + @"\\(print)song.mdb";
            //sDBPath = @"E:\\_HD_\\HD1\\_Projects_\\Homekara2\\keycapture\\keycapture\\bin\\Release\\test.mdb";

            //// Start a new instance of Access for Automation:
            //oAccess = new Access.ApplicationClass();

            // Open a database in exclusive mode:
            oAccess.OpenCurrentDatabase(
               "E:\\_HD_\\HD1\\_Projects_\\Homekara2\\keycapture\\keycapture\\bin\\Release\\test.mdb", //filepath
               false, //Exclusive
               null
               );


//            oAccess.DoCmd.OpenForm(
//   "Form2", //FormName
//   Access.AcFormView.acNormal, //View
//   System.Reflection.Missing.Value, //FilterName
//   System.Reflection.Missing.Value, //WhereCondition
//   Access.AcFormOpenDataMode.acFormPropertySettings, //DataMode
//   Access.AcWindowMode.acWindowNormal, //WindowMode
//   System.Reflection.Missing.Value //OpenArgs
//   );

//             // Show a form named Employees:
//oAccess.DoCmd.OpenForm(
//   "run", //FormName
//   Access.AcFormView.acNormal, //View
//   System.Reflection.Missing.Value, //FilterName
//   System.Reflection.Missing.Value, //WhereCondition
//   Access.AcFormOpenDataMode.acFormPropertySettings, //DataMode
//   Access.AcWindowMode.acWindowNormal, //WindowMode
//   System.Reflection.Missing.Value //OpenArgs
//   );


      //      MessageBox.Show(sDBPath);
      //      // Open Northwind.mdb in shared mode:
      //      //oAccess.OpenCurrentDatabase(sDBPath, false, "");
      //      // If using Access 10.0 object library, use this instead:
      //     oAccess.OpenCurrentDatabase(sDBPath, false, null);

      //      // Close any forms that Northwind may have opened:
      //      while(oAccess.Forms.Count > 0)
      //      {   
      //         oForm = oAccess.Forms[0];
      //         oAccess.DoCmd.Close(Access.AcObjectType.acForm,
      //            oForm.Name, Access.AcCloseSave.acSaveNo);
      //         NAR(oForm);
      //         oForm = null;
      //      }

      //      // Select the form name in the database window and give focus
      //      // to the database window:
      //      oAccess.DoCmd.SelectObject(Access.AcObjectType.acForm, sForm, true);

      //      // Show the form:
      //      oAccess.DoCmd.OpenForm(sForm, Access.AcFormView.acNormal, moMissing,
      //         moMissing, Access.AcFormOpenDataMode.acFormPropertySettings,
      //         Access.AcWindowMode.acWindowNormal, moMissing);

      //      // Use Controls collection to edit the form:

      //      oForm = oAccess.Forms[sForm];
      //      oCtls = oForm.Controls;

      //      // Set PrintLabelsFor option group to Specific Country:

      //      oCtl = (Access.Control)oCtls["PrintLabelsFor"];
      //      object[] Parameters = new Object[1];
      //      Parameters[0] = 2; //second option in option group
      //      oCtl.GetType().InvokeMember("Value", BindingFlags.SetProperty,
      //         null, oCtl, Parameters);
      //      NAR(oCtl);
      //      oCtl = null;

      //      // Put USA in the SelectCountry combo box:
      //      oCtl = (Access.Control)oCtls["SelectCountry"];
      //      Parameters[0] = true;
      //      oCtl.GetType().InvokeMember("Enabled", BindingFlags.SetProperty,
      //         null, oCtl, Parameters);
      //      oCtl.GetType().InvokeMember("SetFocus", BindingFlags.InvokeMethod,
      //         null, oCtl, null);
      //      Parameters[0] = "USA";
      //      oCtl.GetType().InvokeMember("Value", BindingFlags.SetProperty,
      //         null, oCtl, Parameters);
      //      NAR(oCtl);
      //      oCtl = null;

      //      // Hide the Database Window:
      //      oAccess.DoCmd.SelectObject(Access.AcObjectType.acForm, sForm, true);
      //      oAccess.RunCommand(Access.AcCommand.acCmdWindowHide);

      //      // Set focus back to the form:
      //      oForm.SetFocus();

      //      // Release Controls and Form objects:       
      //      NAR(oCtls);
      //      oCtls = null;
      //      NAR(oForm);
      //      oForm = null;

      //      // Release Application object and allow Access to be closed by user:
      //      if(!oAccess.UserControl) oAccess.UserControl = true;
      //      NAR(oAccess);
      //      oAccess = null;
      //   }
      //   catch(Exception ei)
      //   {
      //      MessageBox.Show(ei.Message);
      //      // Release any Access objects and quit Access due to error:
      //      NAR(oCtl);
      //      oCtl = null;
      //      NAR(oCtls);
      //      oCtls = null;
      //      NAR(oForm);
      //      oForm = null;
      //      try // use try..catch in case oAccess is not set
      //      {
      //         oAccess.Quit(Access.AcQuitOption.acQuitSaveNone);
      //      }
      //      catch{}
      //      NAR(oAccess);
      //      oAccess = null;
         
      //}

        }
 





        //delegate void SetTextCallback2(String text);

        //private void SetText2(String text)
        //{
        //    // InvokeRequired required compares the thread ID of the
        //    // calling thread to the thread ID of the creating thread.
        //    // If these threads are different, it returns true.

        //    if (this.spell1TextBox.InvokeRequired)
        //    {
        //        SetTextCallback d = new SetTextCallback2(SetText);
        //        this.Invoke(d, new object[] { text });
        //    }
        //    else
        //    {
        //        this.spell1TextBox.Text = text;
        //    }
        //}

        //public void OnRecievedData(IAsyncResult ar)
        //{
        //    // Get The connection socket from the callback
        //    Socket sock = (Socket)ar.AsyncState;
        //    // Get The data , if any
        //    int nBytesRec = sock.EndReceive(ar);
        //    if (nBytesRec > 0)
        //    {
        //        string sRecieved = Encoding.ASCII.GetString(m_byBuff, 0, nBytesRec);
        //        string m_strLine = "";
        //        for (int i = 0; i < nBytesRec; i++)
        //        {
        //            Char ch = Convert.ToChar(m_byBuff[i]);
        //            switch (ch)
        //            {
        //                case '\r':
        //                    m_strLine += Convert.ToString("\r\n");
        //                    break;
        //                case '\n':
        //                    break;
        //                default:
        //                    m_strLine += Convert.ToString(ch);
        //                    break;
        //            }
        //        }
        //        try
        //        {
        //            int strLinelen = m_strLine.Length;
        //            if (strLinelen == 0)
        //            {
        //                m_strLine = Convert.ToString("\r\n");
        //            }

        //            Byte[] mToProcess = new Byte[strLinelen];
        //            for (int i = 0; i < strLinelen; i++)
        //                mToProcess[i] = Convert.ToByte(m_strLine[i]);
        //            // Process the incoming data
        //            string mOutText = ProcessOptions(mToProcess);
        //            if (mOutText != "")
        //                textBox1.AppendText(mOutText);

        //            // Respond to any incoming commands
        //            RespondToOptions();
        //        }
        //        catch (Exception ex)
        //        {
        //            Object x = this;
        //            MessageBox.Show(ex.Message, "Information!");
        //        }
        //    }
        //    else
        //    {
        //        // If no data was recieved then the connection is probably dead
        //        Console.WriteLine("Disconnected", sock.RemoteEndPoint);
        //        sock.Shutdown(SocketShutdown.Both);
        //        sock.Close();
        //        Application.Exit();
        //    }
        //}

        //private string ProcessOptions(byte[] m_strLineToProcess)
        //{
        //    string m_DISPLAYTEXT = "";
        //    string m_strTemp = "";
        //    string m_strOption = "";
        //    string m_strNormalText = "";
        //    bool bScanDone = false;
        //    int ndx = 0;
        //    int ldx = 0;
        //    char ch;
        //    try
        //    {
        //        for (int i = 0; i < m_strLineToProcess.Length; i++)
        //        {
        //            Char ss = Convert.ToChar(m_strLineToProcess[i]);
        //            m_strTemp = m_strTemp + Convert.ToString(ss);
        //        }

        //        while (bScanDone != true)
        //        {
        //            int lensmk = m_strTemp.Length;
        //            ndx = m_strTemp.IndexOf(Convert.ToString(IAC));
        //            if (ndx > lensmk)
        //                ndx = m_strTemp.Length;

        //            if (ndx != -1)
        //            {
        //                m_DISPLAYTEXT += m_strTemp.Substring(0, ndx);
        //                ch = m_strTemp[ndx + 1];
        //                if (ch == DO || ch == DONT || ch == WILL || ch == WONT)
        //                {
        //                    m_strOption = m_strTemp.Substring(ndx, 3);
        //                    string txt = m_strTemp.Substring(ndx + 3);
        //                    m_DISPLAYTEXT += m_strTemp.Substring(0, ndx);
        //                    m_ListOptions.Add(m_strOption);
        //                    m_strTemp = txt;
        //                }
        //                else
        //                    if (ch == IAC)
        //                    {
        //                        m_DISPLAYTEXT = m_strTemp.Substring(0, ndx);
        //                        m_strTemp = m_strTemp.Substring(ndx + 1);
        //                    }
        //                    else
        //                        if (ch == SB)
        //                        {
        //                            m_DISPLAYTEXT = m_strTemp.Substring(0, ndx);
        //                            ldx = m_strTemp.IndexOf(Convert.ToString(SE));
        //                            m_strOption = m_strTemp.Substring(ndx, ldx);
        //                            m_ListOptions.Add(m_strOption);
        //                            m_strTemp = m_strTemp.Substring(ldx);
        //                        }
        //            }
        //            else
        //            {
        //                m_DISPLAYTEXT = m_DISPLAYTEXT + m_strTemp;
        //                bScanDone = true;
        //            }
        //        }
        //        m_strNormalText = m_DISPLAYTEXT;
        //    }
        //    catch (Exception eP)
        //    {
        //        MessageBox.Show(eP.Message, "Application Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        //        Application.Exit();
        //    }
        //    return m_strNormalText;
       //}

    }
}