using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abramyan2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(textBox1.Text);
            string C = Convert.ToString(textBox2.Text);

            string res = "";

            for (int i = 1; i <= N; i++)
            {
                res = res + C;
            }


            textBox3.Text = res;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
