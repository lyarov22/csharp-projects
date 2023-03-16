using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kontrolnaya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] mas = { { 34, 44, 68, 14, 100},
                           { 44, 18, 90, 16, 100},
                           { 90, 63, 13, 1, 100},
                           { 15, 29, 92, 10, 100,},
                           { 100, 100, 100, 100, 100} };

            dataGridView1.RowCount = 4;
            dataGridView1.ColumnCount = 4;

            string res = "";

            int i, j;
            for (i = 0; i < 4; ++i)
                for (j = 0; j < 4; ++j)
                    dataGridView1.Rows[i].Cells[j].Value = mas[i, j];

            for (i = 0; i < 4; ++i)
            {
                for (j = 0; j < 4; ++j)
                {
                    if (mas[i, j] < mas[i + 1, j] && mas[i, j] < mas[i, j + 1])
                    {
                            res += mas[i, j] + " ";
                    }
                }
            }

            string result = res.Remove(res.LastIndexOf(" "));

            int index = 0;

            for (int m = result.Length - 4; m >= 0; m--)
            {
                if (result[m] == ' ')
                {
                    index = m;
                    break;
                }
            }

            result = result.Remove(index);
            textBox2.Text = result;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        
    }
}
