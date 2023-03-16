namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 15; //��������� ���������� �����

            dataGridView1.ColumnCount = 15; //��������� ���������� ��������

            int[,] a = new int[15, 15]; //�������������� ������

            int i, j;

            //��������� ������� ���������� �������

            Random rand = new Random();

            for (i = 0; i < 15; i++)

                for (j = 0; j < 15; j++)

                    a[i, j] = rand.Next(-100, 100);

            //������� ������� � dataGridView1

            for (i = 0; i < 15; i++)

                for (j = 0; j < 15; j++)

                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);

            //���������� ����� ������������� �������� �� �������������� ���������

            int m = int.MinValue;

            for (i = 0; i < 15; i++)

                if (a[i, 14 - i] > m) m = a[i, 14 - i];

            // ������� ���������

            textBox1.Text = Convert.ToString(m);



            
            for (int k = 0; k < dataGridView1.Columns.Count; k++)
            {
                dataGridView1.Columns[k].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView2.Columns[k].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView3.Columns[k].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}