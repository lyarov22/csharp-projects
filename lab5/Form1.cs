namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // �������� ����� ���������� ������

            int index = listBox1.SelectedIndex;
            

            // ��������� ������ � ��������� str

            string str = (string)listBox1.Items[index];

            // ������ ���������� �������� � ������

            int len = str.Length;

            // �������, ��� ���������� �������� ����� 0

            int count = 0;

            // ������������� ������� �������� � 0

            int i = 0;

            //���������� ���� �������� ���� �������� � ������

            while (i <= len - 1)

            {

                // ���� ����� ������, �� �����������

                // ������� �������� �� 1


                if (str[i] >= '�' && str[i] <= '�')

                    count++;

                i++;


            }

            label1.Text = "���������� c������� ���� = " +

            count.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}