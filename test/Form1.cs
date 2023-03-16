using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;

            listBox1.AllowDrop = true;

            //подписываемся на события
            listBox1.MouseMove += new MouseEventHandler(listBox1_MouseMove);
            listBox1.DragEnter += new DragEventHandler(listBox1_DragEnter);
            listBox1.DragDrop += new DragEventHandler(listBox1_DragDrop);

            textBox4.Text = "";



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ;
        }

        public double correct = 0;
        public double incorrect = 0;
     
        int indexToMove;

        
       

        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //если нажата левая кнопка мыши, начинаем Drag&Drop
            if (e.Button == MouseButtons.Left)
            {
                //индекс элемента, который мы перемещаем
                indexToMove = listBox1.IndexFromPoint(e.X, e.Y);
                listBox1.DoDragDrop(indexToMove, DragDropEffects.Move);
            }
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            //индекс, куда перемещаем
            //listBox1.PointToClient(new Point(e.X, e.Y)) - необходимо
            //использовать поскольку в e храниться
            //положение мыши в экранных коородинатах, а эта
            //функция позволяет преобразовать в клиентские
            int newIndex = listBox1.IndexFromPoint(listBox1.PointToClient(new Point(e.X, e.Y)));
            //если вставка происходит в начало списка
            if (newIndex == -1)
            {
                //получаем перетаскиваемый элемент
                object itemToMove = listBox1.Items[indexToMove];
                //удаляем элемент
                listBox1.Items.RemoveAt(indexToMove);
                //добавляем в конец списка
                listBox1.Items.Add(itemToMove);
            }
            //вставляем где-то в середину списка
            else if (indexToMove != newIndex)
            {
                //получаем перетаскиваемый элемент
                object itemToMove = listBox1.Items[indexToMove];
                //удаляем элемент
                listBox1.Items.RemoveAt(indexToMove);
                //вставляем в конкретную позицию
                listBox1.Items.Insert(newIndex, itemToMove);
            }
        }


      
        private void CloseButton()
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseButton();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CloseButton();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() ==
                System.Windows.Forms.DialogResult.OK)
            {
                correct += 1;
                

                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

                openFileDialog1.FileName = "text";
            }





        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CloseButton();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CloseButton();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CloseButton();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CloseButton();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            CloseButton();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                correct += 1;
            }

            else
            {
                incorrect += 1;
                textBox4.Text += " 1";
            }

            tabControl1.SelectTab(1);

            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "2022")
            {
                correct += 1;
            }
            else
            {
                incorrect += 1;
                textBox4.Text += " 2";
            }
            tabControl1.SelectTab(2);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                correct += 0.25;
            }

            if (comboBox2.SelectedIndex == 1)
            {
                correct += 0.25;
            }

            if (comboBox3.SelectedIndex == 2)
            {
                correct += 0.25;
            }

            if (comboBox4.SelectedIndex == 3)
            {
                correct += 0.25;
            }
            else
            {
                incorrect += 1;
                textBox4.Text += " 3";
            }
            tabControl1.SelectTab(3);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            correct = 0;
            incorrect = 0;

            tabControl1.SelectTab(0);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                correct += 0.5;
            }

            if (checkBox2.Checked == true)
            {
                correct += 0.5;
            }

            else
            {
                incorrect += 1;
                textBox4.Text += " 6";
            }

            tabControl1.SelectTab(6);

            textBox2.Text = Convert.ToString(correct + " из 6");
            textBox3.Text = Convert.ToString(incorrect + " из 6");

            if (correct >= 6.0)
            {
                label21.Text = "5";
                label21.ForeColor = Color.Green;

            }

            else if (correct >= 5.0)
            {
                label21.Text = "4";
                label21.ForeColor = Color.GreenYellow;

            }

            else if (correct >= 4.0)
            {
                label21.Text = "3";
                label21.ForeColor = Color.Yellow;

            }

            else if (correct >= 3.0)
            {
                label21.Text = "2";
                label21.ForeColor = Color.Red;

            }

            else if (correct >= 2.0)
            {
                label21.Text = "1";
                label21.ForeColor = Color.DarkRed;

            }

            else if (correct >= 1.0)
            {
                label21.Text = "1";
                label21.ForeColor = Color.IndianRed;

            }

            else if (correct == 0)
            {
                label21.Text = "0";
                label21.ForeColor = Color.OrangeRed;

            }
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listBox1.Items[0] == "1" &&
                listBox1.Items[1] == "2" &&
                listBox1.Items[2] == "3" &&
                listBox1.Items[3] == "4" &&
                listBox1.Items[4] == "5")
            {
                correct += 1;
            }

            else
            {
                incorrect += 1;
                textBox4.Text += " 4";
            }

            tabControl1.SelectTab(4);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName != "text")
            {
                textBox4.Text += " 5";
                incorrect += 1;
            }



            tabControl1.SelectTab(5);
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            
        }
    }
}

