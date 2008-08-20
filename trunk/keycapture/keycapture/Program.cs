using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace keycapture
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        private static void Form1thread()
        {
            Application.Run(new Form1());
           // fm1 = new Form1();
          //  fm1.Show();
        }

       public static Form2 fm2;
       public static Form1 fm1;

        private static void Form2thread()
        {
            //fm2 = new Form2();
           // fm2.ShowDialog();
         //   Application.Run(new Form2());
            fm2 = new Form2();
            fm2.Show(); 
        }


        public static void showForm2()
        {
            //fm2 = new Form2();
            //fm2.ShowDialog();

        }

        public static void hideForm2()
        {
            
        }

        public static void Form2Label()
        {
           // tdForm2.la
        }


        public static void startProcessBarForm()
        {
           
            ThreadStart ts2 = new ThreadStart(Form2thread);
            tdForm2 = new Thread(ts2);
            tdForm2.Start();
            //fm2.Show();   
        }

        public static void startMianForm()
        {
            ThreadStart td1 = new ThreadStart(Form1thread);
            tdForm1 = new Thread(td1);
           // Thread td2 = new Thread();

            
            tdForm1.Start();  

            
        }


        public static Thread tdForm1 ;
        public static Thread tdForm2;

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
         // startMianForm();
          //  mutilthreadingTest();
           // startProcessBarForm();
          // Form1thread();
           // startProcessBarForm();
         // startProcessBarForm();
            Application.Run(new Form1());
         
        }






        static void mutilthreadingTest()
        {
            //ThreadStart job = new ThreadStart(ThreadJob);
            //Thread thread = new Thread(job);
            //thread.Start();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Main thread: {0}", i);
            //    Thread.Sleep(1000);
            //}

            ThreadStart ts2 = new ThreadStart(Form2thread);
            tdForm2 = new Thread(ts2);
            tdForm2.Start();

            Form1thread();
            //fm2.Show();   


        }

        static void ThreadJob()
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Other thread: {0}", i);
            //    Thread.Sleep(500);
            //}


        }



    }
}