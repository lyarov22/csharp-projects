using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            




        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] P = new double[18];

            double[] F = new double[18];



            Random rand = new Random();

            textBox1.Text = "";

            for (int i = 0; i < 18; i++)
            {

                F[i] = rand.Next(0, 18);

                textBox1.Text += "Mas[" + Convert.ToString(i) + "] = "

                + Convert.ToString(F[i]) + Environment.NewLine;

            }

            for (int i = 0; i < 18; i++) //i<18
            {
                P[i] = 0.13 * Math.Pow(F[i], 3) - 2.5 * F[i] + 8.0;

                textBox2.Text += P[i] + Environment.NewLine;


            }

            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
    }
}