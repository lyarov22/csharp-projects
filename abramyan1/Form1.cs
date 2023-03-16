using System.CodeDom;
using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace abr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a1 = Convert.ToInt32(textBox1.Text);
            int b1 = Convert.ToInt32(textBox2.Text);

            int res1 = (a1 + b1) / 2;

            textBox3.Text = Convert.ToString(res1);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int input2 = Convert.ToInt32(textBox6.Text);
            int res2 = 0;
            while (input2 > 0)
            {
                res2 *= 10;
                res2 += input2 % 10;
                input2 /= 10;
            }

            textBox4.Text = Convert.ToString(res2);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a3 = Convert.ToInt32(textBox7.Text);
            int b3 = Convert.ToInt32(textBox8.Text);



            if (a3 % 2 != 0 && b3 % 2 != 0)
            {
                textBox5.Text = "Верно";
            }

            else
            {
                textBox5.Text = "Неверно";
            }



        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a4 = Convert.ToInt32(textBox10.Text);
            int b4 = Convert.ToInt32(textBox11.Text);

            if (a4 > b4)
            {
                textBox9.Text = Convert.ToString(a4 + " " + b4);

            }

            else if (a4 < b4)
            {
                textBox9.Text = Convert.ToString(b4 + " " + a4);

            }

            else
            {
                textBox9.Text = Convert.ToString("Равны");
            }



            }

        private void button5_Click(object sender, EventArgs e)
        {
            int d5 = Convert.ToInt32(textBox13.Text);
            int m5 = Convert.ToInt32(textBox14.Text);

            int day5 = 0;
            int month5 = 0;
            
            switch (m5)
            {
                case 1:
                    if (d5 > 1 && d5 <= 31)
                    {
                        day5 = d5 - 1;
                        month5 = 1;
                    }

                    else if (d5 == 1)
                    {
                        day5 = 31;
                        month5 = 12;
                    }
                    
                    else
                    {
                        textBox12.Text = Convert.ToString("NaN");
                    }
                    break;

                case 2:
                    if (d5 > 1 && d5 <= 28)
                    {
                        day5 = d5 - 1;
                        month5 = 2;
                    }

                    else if (d5 == 1)
                    {
                        day5 = 31;
                        month5 = 01;
                    }

                    else
                    {
                        textBox12.Text = Convert.ToString("NaN");
                    }
                    break;

                case 3:
                    if (d5 > 1 && d5 <= 31)
                    {
                        day5 = d5 - 1;
                        month5 = 3;
                    }

                    else if (d5 == 1)
                    {
                        day5 = 28;
                        month5 = 02;
                    }

                    else
                    {
                        textBox12.Text = Convert.ToString("NaN");
                    }
                    break;

                case 4:
                    if (d5 > 1 && d5 <= 30)
                    {
                        day5 = d5 - 1;
                        month5 = 4;
                    }

                    else if (d5 == 1)
                    {
                        day5 = 31;
                        month5 = 03;
                    }

                    else
                    {
                        textBox12.Text = Convert.ToString("NaN");
                    }
                    break;

                case 5:
                    if (d5 > 1 && d5 <= 31)
                    {
                        day5 = d5 - 1;
                        month5 = 5;
                    }

                    else if (d5 == 1)
                    {
                        day5 = 30;
                        month5 = 04;
                    }

                    else
                    {
                        textBox12.Text = Convert.ToString("NaN");
                    }
                    break;

                case 6:
                    if (d5 > 1 && d5 <= 30)
                    {
                        day5 = d5 - 1;
                        month5 = 6;
                    }

                    else if (d5 == 1)
                    {
                        day5 = 31;
                        month5 = 05;
                    }

                    else
                    {
                        textBox12.Text = Convert.ToString("NaN");
                    }
                    break;

                case 7:
                    if (d5 > 1 && d5 <= 31)
                    {
                        day5 = d5 - 1;
                        month5 = 7;
                    }

                    else if (d5 == 1)
                    {
                        day5 = 30;
                        month5 = 06;
                    }

                    else
                    {
                        textBox12.Text = Convert.ToString("NaN");
                    }
                    break;

                case 8:
                    if (d5 > 1 && d5 <= 31)
                    {
                        day5 = d5 - 1;
                        month5 = 8;
                    }

                    else if (d5 == 1)
                    {
                        day5 = 31;
                        month5 = 07;
                    }

                    else
                    {
                        textBox12.Text = Convert.ToString("NaN");
                    }
                    break;

                case 9:
                    if (d5 > 1 && d5 <= 30)
                    {
                        day5 = d5 - 1;
                        month5 = 9;
                    }

                    else if (d5 == 1)
                    {
                        day5 = 31;
                        month5 = 12;
                    }

                    else
                    {
                        textBox12.Text = Convert.ToString("NaN");
                    }
                    break;

                case 10:
                    if (d5 > 1 && d5 <= 31)
                    {
                        day5 = d5 - 1;
                        month5 = 10;
                    }

                    else if (d5 == 1)
                    {
                        day5 = 30;
                        month5 = 09;
                    }

                    else
                    {
                        textBox12.Text = Convert.ToString("NaN");
                    }
                    break;

                case 11:
                    if (d5 > 1 && d5 <= 30)
                    {
                        day5 = d5 - 1;
                        month5 = 11;
                    }

                    else if (d5 == 1)
                    {
                        day5 = 31;
                        month5 = 10;
                    }

                    else
                    {
                        textBox12.Text = Convert.ToString("NaN");
                    }
                    break;

                case 12:
                    if (d5 > 1 && d5 <= 31)
                    {
                        day5 = d5 - 1;
                        month5 = 12;
                    }

                    else if (d5 == 1)
                    {
                        day5 = 30;
                        month5 = 11;
                    }

                    else
                    {
                        textBox12.Text = Convert.ToString("NaN");
                    }
                    break;

            }

            

            textBox12.Text = Convert.ToString(day5 + " " + month5);

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                int a6 = Convert.ToInt32(textBox16.Text);
                int b6 = Convert.ToInt32(textBox17.Text);

                BigInteger res6 = 1;

                for (int i = a6; i <= b6; i++)
                {
                    res6 *= i;
                }

                textBox15.Text = Convert.ToString(res6);
            }

            catch (DivideByZeroException)
            { MessageBox.Show("Ошибка деления на ноль !!!"); }
            catch (FormatException)
            { MessageBox.Show("Ошибка формата исходных данных!!!"); }
            catch (Exception)
            { MessageBox.Show("Ошибка !!!"); }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int n7= Convert.ToInt32(textBox19.Text);

            int k7 = 0;
            while ((k7 * k7) <= n7)
            {
                ++k7;
                textBox18.Text = Convert.ToString(k7);
            }

            
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            int n = int.Parse(textBox21.Text);
            int k = 0;

            int[] mas = new int[n];

            for (int i = 0; i < n; i++)
            {
                mas[i] = rand.Next(-100, 100);
                textBox20.Text += mas[i] + Environment.NewLine;
            }

            for (int i = 0; i < n; i++)
            {
                if (mas[i] % 2 == 0)
                {
                    textBox25.Text += mas[i] + Environment.NewLine;
                    k++;
                }
            }

            textBox24.Text += k.ToString();

            


            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int k9 = Convert.ToInt32(textBox23.Text);

            int d9 = 0;

            textBox22.Text = Convert.ToString(d9);
        }
    }
    }