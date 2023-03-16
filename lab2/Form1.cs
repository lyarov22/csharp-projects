namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double l = Convert.ToDouble(textBox1.Text);

            double m = Convert.ToDouble(textBox2.Text);

            double x = Convert.ToDouble(textBox3.Text);


            int n = 0;

            if (radioButton2.Checked) n = 1;

            else if (radioButton3.Checked) n = 2;

            double j = 0;



            switch (n)

            {

                case 0:

                    if (-l < m && -l < x)
                    {
                        j = Math.Sin(5 * Math.Sinh(x) + 3 * m * Math.Abs(Math.Sinh(x)));

                    }

                    else if (x > m)
                    {
                        j = Math.Cos(3 * Math.Sinh(x) + 5 * m * Math.Abs(Math.Sinh(x)));

                    }

                    else
                    {
                        Math.Pow((Math.Sinh(x) + m), 2);

                    }

                    textBox4.Text = Convert.ToString(j);

                    break;

                case 1:

                    if (-l < m && -l < x)
                    {
                        j = Math.Sin(5 * x * x + 3 * m * Math.Abs(x * x));

                    }

                    else if (x > m)
                    {
                        j = Math.Cos(3 * x * x + 5 * m * Math.Abs(x * x));

                    }

                    else
                    {
                        Math.Pow((x * x + m), 2);

                    }

                    textBox4.Text = Convert.ToString(j);

                    break;

                case 2:

                    if (-l < m && -l < x)
                    {
                        j = Math.Sin(5 * Math.Exp(x) + 3 * m * Math.Abs(Math.Exp(x)));

                    }

                    else if (x > m)
                    {
                        j = Math.Cos(3 * Math.Exp(x) + 5 * m * Math.Abs(Math.Exp(x)));

                    }

                    else
                    {
                        Math.Pow((Math.Exp(x) + m), 2);

                    }

                    textBox4.Text = Convert.ToString(j);

                    break;






                default:

                    textBox4.Text += "Решение не найдено" + Environment.NewLine;

                    break;

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}