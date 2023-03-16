namespace lab0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, z;
            double n, n1, n2, n3;
            

            x = -2.235 * Math.Pow(10, 2);
            y = 2.23;
            z = 15.221;

            textBox1.Text = Convert.ToString(x);
            textBox2.Text = Convert.ToString(y);
            textBox3.Text = Convert.ToString(z);

            n1 = Math.Pow(Math.E, Math.Abs(x - y)) * Math.Pow(Math.Abs(x - y), (x + y));
            n2 = Math.Atan(x) + Math.Atan(z);
            n3 = Math.Pow(Math.Pow(x, 6) + Math.Pow(Math.Log(y), 2), (1.0 / 3));
            n = n1 / n2 + n3;
           
            textBox4.Text = Convert.ToString(n);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}