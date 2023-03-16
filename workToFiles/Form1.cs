using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace workToFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int correct = 0;
        string s = "";
        double x, y;

        string path = "C:\\Users\\dyudy\\Desktop\\projects c#\\workToFiles\\Properties\\TextFile1.txt";
        StreamReader f1 = new StreamReader("C:\\Users\\dyudy\\Desktop\\projects c#\\workToFiles\\Properties\\TextFile1.txt", Encoding.GetEncoding("windows-1251"));

        
        int lines = System.IO.File.ReadAllLines("C:\\Users\\dyudy\\Desktop\\projects c#\\workToFiles\\Properties\\TextFile1.txt").Length;

        public int test = 0;

        int i1 = 1;
        int i2 = 2;
        int i3 = 3;

        private void testScript()
        {
            string[] mas = new string[lines];
            mas[0] = "0";

            for (int i = 0; i < lines; i++)
            {
                mas[i] = f1.ReadLine();
            }

            

            
            
            for (int i = 0; i < lines; i += 3)
            {
             label1.Text = mas[i];
     
            }

            for (int j = 0; j < lines; j++)
            {
                radioButton1.Text = mas[i1];
                radioButton2.Text = mas[i2];
                radioButton3.Text = mas[i3];
            }



            
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            testScript();

            tabControl1.SelectTab(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            f1.Close();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            testScript();
            test += 1;


            if (radioButton1.Checked == true)
            {
                correct += 1;
            }


           

        }
    }
}
