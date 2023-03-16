using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labirint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void buttonLVL1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);

            //start1
            Cursor.Position = new Point(this.Location.X + 45, this.Location.Y + 180);

        }

        private void buttonLVL2_Click(object sender, EventArgs e)
        {
            
            Cursor.Position = new Point(this.Location.X + 45, this.Location.Y + 130);

        }

        private void buttonLVL3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
            Cursor.Position = new Point(this.Location.X + 45, this.Location.Y + 130);
        }

        private void buttonLVL4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
            Cursor.Position = new Point(this.Location.X + 45, this.Location.Y + 130);
        }

        private void buttonLVL5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
            Cursor.Position = new Point(this.Location.X + 45, this.Location.Y + 130);
        }

        private void buttonLVL6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
            Cursor.Position = new Point(this.Location.X + 45, this.Location.Y + 130);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        //fail1
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Position = new Point(this.Location.X + 45, this.Location.Y + 130);
        }



        //finish1
        private void labelFinish_MouseEnter(object sender, EventArgs e)
        {

            if (tabControl1.SelectedIndex == 1)
            {
                DialogResult res = MessageBox.Show("Вы спасли овцу! Продолжить?", "Уровень 1", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes) tabControl1.SelectTab(2);
                if (res == DialogResult.No) tabControl1.SelectTab(1);

            }

            else if (tabControl1.SelectedIndex == 2)
            {
                DialogResult res = MessageBox.Show("Продолжить?", "Уровень 2", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes) tabControl1.SelectTab(3);
                if (res == DialogResult.No) tabControl1.SelectTab(2);

            }

            else if (tabControl1.SelectedIndex == 3)
            {
                DialogResult res = MessageBox.Show("Продолжить?", "Уровень 3", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes) tabControl1.SelectTab(4);
                if (res == DialogResult.No) tabControl1.SelectTab(3);

            }

            else if (tabControl1.SelectedIndex == 4)
            {
                DialogResult res = MessageBox.Show("Продолжить?", "Уровень 4", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes) tabControl1.SelectTab(5);
                if (res == DialogResult.No) tabControl1.SelectTab(4);

            }

            else if (tabControl1.SelectedIndex == 5)
            {
                DialogResult res = MessageBox.Show("Продолжить?", "Уровень 5", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes) tabControl1.SelectTab(6);
                if (res == DialogResult.No) tabControl1.SelectTab(5);

            }


        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        //включить рычаг
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;

            pictureBox3.Visible = false;
            pictureBox4.Visible = false;

            pictureBox5.Visible = true;
            pictureBox6.Visible = true;



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;

            pictureBox3.Visible = true;
            pictureBox4.Visible = true;

            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //GhostWhite color для хардкорной сложности
        //SkyBlue для нормальной сложности
        //Gray - лёгкая
        //
        //Crimson - импассибл
    }
}
