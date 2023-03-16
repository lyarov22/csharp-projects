using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encryption
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


        public string alphabet_rus_small = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public string alphabet_rus_big = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public string alphabet_eng_small = "zyxwvutsrqponmlkjihgfedcba";
        public string alphabet_eng_big = "ZYXWVUTSRQPONMLKJIHGFEDCBA";

        char[] alfavit = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

        char[] characters = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
                                         'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 
                                         'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
                                         'Э', 'Ю', 'Я', ' ', '1', '2', '3', '4', '5', '6', 
                                         '7', '8', '9', '0' };

        private void atbash()
        {
            char[] characters = textBox1.Text.ToCharArray();

            string temp_word = "";

            for (int i = 0; i < characters.Length; i++)
            {
                if (alphabet_rus_small.Contains(characters[i])) temp_word += alphabet_rus_small[32 - alphabet_rus_small.IndexOf(characters[i])];
                if (alphabet_rus_big.Contains(characters[i])) temp_word += alphabet_rus_big[32 - alphabet_rus_big.IndexOf(characters[i])];
                if (alphabet_eng_small.Contains(characters[i])) temp_word += alphabet_eng_small[25 - alphabet_eng_small.IndexOf(characters[i])];
                if (alphabet_eng_big.Contains(characters[i])) temp_word += alphabet_eng_big[25 - alphabet_eng_big.IndexOf(characters[i])];
            }

            textBox5.Text = temp_word;
        }



        private void caesar()
        {
            char[] massage = textBox1.Text.ToCharArray();

            string s = "";
            int d;
            try
            {
                d = Convert.ToInt16(textBox2.Text);
            }
            catch(FormatException)
            {
                textBox2.Text = "Ошибка формата. Введите цифру";
            }
           
            int nomer; // Номер в алфавите
         
            int j; // Переменная для циклов

            // Перебираем каждый символ сообщения
            for (int i = 0; i < massage.Length; i++)
            {
                // Ищем индекс буквы
                for (j = 0; j < alfavit.Length; j++)
                {
                    if (massage[i] == alfavit[j])
                    {
                        break;
                    }
                }

                if (j != 33) // Если j равно 33, значит символ не из алфавита
                {
                    nomer = j; // Индекс буквы
                    d = nomer + 3; // Делаем смещение

                    // Проверяем, чтобы не вышли за пределы алфавита
                    if (d > 32)
                    {
                        d = d - 33;
                    }

                    massage[i] = alfavit[d]; // Меняем букву
                }
            }

            s = new string(massage); // Собираем символы обратно в строку.
            textBox5.Text = s;
        }


        string caesarDecode(string word, int key)
        {
            word = word.ToLower();
            StringBuilder sb = new StringBuilder();
            foreach (char character in word)
            {
                char ch = character;
                ch = (char)((int)ch - key);
                if (ch >= 'я')
                    ch = (char)(ch + 32);
                sb.Append(ch.ToString().ToLower());
            }
            textBox5.Text = sb.ToString();
            return sb.ToString();
        }

        private string vijinerEncode(string input, string keyword)
        {
            int N = characters.Length;

            input = input.ToUpper();
            keyword = keyword.ToUpper();

            string result = "";

            int keyword_index = 0;

            foreach (char symbol in input)
            {
                int c = (Array.IndexOf(characters, symbol) +
                    Array.IndexOf(characters, keyword[keyword_index])) % N;

                result += characters[c];

                keyword_index++;

                if ((keyword_index + 1) == keyword.Length)
                    keyword_index = 0;
            }

            textBox5.Text = result;
            return result;
        }

        private string vijinerDecode(string input, string keyword)
        {
            int N = characters.Length;
            input = input.ToUpper();
            keyword = keyword.ToUpper();

            string result = "";

            int keyword_index = 0;

            foreach (char symbol in input)
            {
                int p = (Array.IndexOf(characters, symbol) + N -
                    Array.IndexOf(characters, keyword[keyword_index])) % N;

                result += characters[p];

                keyword_index++;

                if ((keyword_index + 1) == keyword.Length)
                    keyword_index = 0;
            }

            textBox5.Text = result;
            return result;
        }

        public string skitalaEncrypt(string text, int d)
        {
            var k = text.Length % d;
            if (k > 0)
            {
                //дополняем строку пробелами
                text += new string(' ', d - k);
            }

            var column = text.Length / d;
            var result = "";

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    result += text[i + column * j].ToString();
                }
            }

            textBox5.Text = result;
            return result;
        }

        public string skitalaDecrypt(string text, int d)
        {
            var column = text.Length / d;
            var symbols = new char[text.Length];
            int index = 0;
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    symbols[i + column * j] = text[index];
                    index++;
                }
            }

            return string.Join("", symbols);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            textBox2.Visible = false;
            textBox3.Text = "Атбаш";
            
            atbash();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "Цезаря (N)";

            caesar();




        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "Вижинера Зашифровка";

            textBox5.Text = vijinerEncode(textBox1.Text, textBox2.Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = "Табличный Зашифровка";

            textBox5.Text = skitalaEncrypt(textBox1.Text, Convert.ToInt16(textBox2.Text));



            
            


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            caesarDecode(textBox1.Text, Convert.ToInt32(textBox2.Text));

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = "Вижинера Расшифровка";
            vijinerDecode(textBox1.Text, textBox2.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Text = "Табличный Расшифровка";
            textBox5.Text = skitalaDecrypt(textBox1.Text, Convert.ToInt16(textBox2.Text));

        }
    }
}
