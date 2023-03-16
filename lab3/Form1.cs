namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double x0 = 0.75;

            double xk = 2.05;

            double dx = 0.2;

            textBox1.Text = Convert.ToString(x0);
            textBox2.Text = Convert.ToString(xk);
            textBox3.Text = Convert.ToString(dx);
            textBox4.Text = "ilusha1" + Environment.NewLine;

           

            double x = x0;

            while (x <= (xk + dx / 2))

            {

                double y = 9 * x * x * x * x + Math.Sin(57.2 + x);

                textBox4.Text += "x=" + Convert.ToString(x) +

                "; y=" + Convert.ToString(y) + Environment.NewLine;

                x = x + dx;
                x = Math.Round(x, 1);


            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        

            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}