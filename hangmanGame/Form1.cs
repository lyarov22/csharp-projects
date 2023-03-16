using hangmanGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangmanGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuGame_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Задаем колво окошек = колво букв

            

            pictureBox0.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;

            
        }

    
        public string word;

        private void fileScript()
        {
            string[] mas = new string[5] {"ПРИВЕТ", "САЛАМ", "ЗДАРОВА", "КУ", "ДРАТУТИ"};

            
            Random rand = new Random();

            int ran = rand.Next(0, mas.Length);

            word = mas[ran];

            wordVisible(mas[ran]);

        }

        
       




        //Меню верхнее

        //Игра

        //Новая игра...
        private void menuGameNewGame_Click(object sender, EventArgs e)
        {

        }

        //Продолжить...
        private void menuGameContinue_Click(object sender, EventArgs e)
        {

        }

        //Звуки
        private void menuGameSounds_Click(object sender, EventArgs e)
        {

        }

        //Статистика...
        private void menuGameStatistics_Click(object sender, EventArgs e)
        {

        }

        //Настройки...
        private void menuGameSettings_Click(object sender, EventArgs e)
        {

        }

        //Выход
        private void menuGameExit_Click(object sender, EventArgs e)
        {

        }


        //Справка

        //Центр справки и поддержки
        private void menuHelpHelpAndAboutCenter_Click(object sender, EventArgs e)
        {

        }

        //Поддержать проект...
        private void menuHelpSupport_Click(object sender, EventArgs e)
        {

        }

        //Сообщить об ошибке...
        private void menuHelpReportAtBug_Click(object sender, EventArgs e)
        {

        }

        //О программе...
        private void menuHelpAbout_Click(object sender, EventArgs e)
        {
            FormAbout newForm = new FormAbout();
            newForm.Show();

        }

        //Проверить обновление...
        private void menuHelpSearchUpdates_Click(object sender, EventArgs e)
        {

        }


       
        //Слово
         

        //Счётчик всех введённых букв
        public int all = 0;

        //Счётчик ошибок
        public int incorrect = 0;

        //Счётчик на конец слова и победу
        public int i = 0;

        public bool res = false;

        //Проверка введённых букв

        private void keyboard(string letter)
        {
            res = false;
            

            if (0 < word.Length && Convert.ToString(word[0]).Contains(letter) && labelW1.Text == "_")
            {
                labelW1.Text = Convert.ToString(letter);
                i++;
                res = true;
            }

            if (1 < word.Length && Convert.ToString(word[1]).Contains(letter) && labelW2.Text == "_")
            {
                labelW2.Text = Convert.ToString(letter);
                i++;
                res = true;
            }

            if (2 < word.Length && Convert.ToString(word[2]).Contains(letter) && labelW3.Text == "_")
            {
                labelW3.Text = Convert.ToString(letter);
                i++;
                res = true;
            }

            if (3 < word.Length && Convert.ToString(word[3]).Contains(letter) && labelW4.Text == "_")
            {
                labelW4.Text = Convert.ToString(letter);
                i++;
                res = true;
            }

            if (4 < word.Length && Convert.ToString(word[4]).Contains(letter) && labelW5.Text == "_")
            {
                labelW5.Text = Convert.ToString(letter);
                i++;
                res = true;
            }

            if (5 < word.Length && Convert.ToString(word[5]).Contains(letter) && labelW6.Text == "_")
            {
                labelW6.Text = Convert.ToString(letter);
                i++;
                res = true;
            }

            if (6 < word.Length && Convert.ToString(word[6]).Contains(letter) && labelW7.Text == "_")
            {
                labelW7.Text = Convert.ToString(letter);
                i++;
                res = true;
            }

            if (7 < word.Length && Convert.ToString(word[7]).Contains(letter) && labelW8.Text == "_")
            {
                labelW8.Text = Convert.ToString(letter);
                i++;
                res = true;
            }

            if (8 < word.Length && Convert.ToString(word[8]).Contains(letter) && labelW9.Text == "_")
            {
                labelW9.Text = Convert.ToString(letter);
                i++;
                res = true;
            }

            if (9 < word.Length && Convert.ToString(word[9]).Contains(letter) && labelW10.Text == "_")
            {
                labelW10.Text = Convert.ToString(letter);
                i++;
                res = true;
            }

            if (10 < word.Length && Convert.ToString(word[10]).Contains(letter) && labelW11.Text == "_")
            {
                labelW11.Text = Convert.ToString(letter);
                i++;
                res = true;
            }


            //Счётчик нажатых кнопок
            all++;

            incorrect = all - i;

            if (incorrect > 0) pictureBox1.Visible = true; //pictureBox0.Visible = false;
            if (incorrect > 1) pictureBox2.Visible = true; //pictureBox1.Visible = false;
            if (incorrect > 2) pictureBox3.Visible = true; //pictureBox2.Visible = false;
            if (incorrect > 3) pictureBox4.Visible = true; //pictureBox3.Visible = false;
            if (incorrect > 4) pictureBox5.Visible = true; //pictureBox4.Visible = false;


            //Если выиграл
            if (i == word.Length)
            {
                MessageBox.Show("Win");
            }

            //Если проиграл
            if (incorrect > 4)
            {
                MessageBox.Show("Lose");
            }

        }


       //Окошек столько, сколько букв
       private void wordVisible(string word)
        {
            int length = word.Length;

            if (length < 1) labelW1.Visible = false;
            if (length < 2) labelW2.Visible = false;
            if (length < 3) labelW3.Visible = false;
            if (length < 4) labelW4.Visible = false;
            if (length < 5) labelW5.Visible = false;
            if (length < 6) labelW6.Visible = false;
            if (length < 7) labelW7.Visible = false;
            if (length < 8) labelW8.Visible = false;
            if (length < 9) labelW9.Visible = false;
            if (length < 10) labelW10.Visible = false;
            if (length < 11) labelW11.Visible = false;

            if (length > 1) labelW1.Visible = true;
            if (length > 2) labelW2.Visible = true;
            if (length > 3) labelW3.Visible = true;
            if (length > 4) labelW4.Visible = true;
            if (length > 5) labelW5.Visible = true;
            if (length > 6) labelW6.Visible = true;
            if (length > 7) labelW7.Visible = true;
            if (length > 8) labelW8.Visible = true;
            if (length > 9) labelW9.Visible = true;
            if (length > 10) labelW10.Visible = true;
            if (length > 11) labelW11.Visible = true;
        }


        //Нажатия кнопок клавиатуры

        private void buttonA_Click(object sender, EventArgs e)
        {
            keyboard("А");
            buttonA.BackColor= Color.LightGray;

            if (res == true) buttonA.BackColor = Color.YellowGreen; buttonA.Enabled = false;
        }

        private void buttonB_Click(object sender, EventArgs e)
        {           
            keyboard("Б");
            buttonB.BackColor = Color.LightGray;
            if (res == true) buttonB.BackColor = Color.YellowGreen; buttonB.Enabled = false;
        }

        private void buttonV_Click(object sender, EventArgs e)
        {            
            keyboard("В");
            buttonV.BackColor = Color.LightGray;
            if (res == true) buttonV.BackColor = Color.YellowGreen; buttonV.Enabled = false;
        }

        private void buttonG_Click(object sender, EventArgs e)
        {           
            keyboard("Г");
            buttonG.BackColor = Color.LightGray;
            if (res == true) buttonG.BackColor = Color.YellowGreen; buttonG.Enabled = false;
        }

        private void buttonD_Click(object sender, EventArgs e)
        {           
            keyboard("Д");
            buttonD.BackColor = Color.LightGray;
            if (res == true) buttonD.BackColor = Color.YellowGreen; buttonD.Enabled = false;
        }

        private void buttonE_Click(object sender, EventArgs e)
        {            
            keyboard("Е");
            buttonE.BackColor = Color.LightGray;
            if (res == true) buttonE.BackColor = Color.YellowGreen; buttonE.Enabled = false;
        }

        private void buttonYo_Click(object sender, EventArgs e)
        {            
            keyboard("Ё");
            buttonYo.BackColor = Color.LightGray;
            if (res == true) buttonYo.BackColor = Color.YellowGreen; buttonYo.Enabled = false;
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {           
            keyboard("Ж");
            buttonJ.BackColor = Color.LightGray;
            if (res == true) buttonJ.BackColor = Color.YellowGreen; buttonJ.Enabled = false;
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            keyboard("З");
            buttonZ.BackColor = Color.LightGray;
            if (res == true) buttonZ.BackColor = Color.YellowGreen; buttonZ.Enabled = false;
        }

        private void buttonI_Click(object sender, EventArgs e)
        {          
            keyboard("И");
            buttonI.BackColor = Color.LightGray;
            if (res == true) buttonI.BackColor = Color.YellowGreen; buttonI.Enabled = false;
        }

        private void buttonIK_Click(object sender, EventArgs e)
        {          
            keyboard("Й");
            buttonIK.BackColor = Color.LightGray;
            if (res == true) buttonIK.BackColor = Color.YellowGreen; buttonIK.Enabled = false;
        }

        private void buttonK_Click(object sender, EventArgs e)
        {          
            keyboard("К");
            buttonK.BackColor = Color.LightGray;
            if (res == true) buttonK.BackColor = Color.YellowGreen; buttonK.Enabled = false;
        }

        private void buttonL_Click(object sender, EventArgs e)
        {            
            keyboard("Л");
            buttonL.BackColor = Color.LightGray;
            if (res == true) buttonL.BackColor = Color.YellowGreen; buttonL.Enabled = false;
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            keyboard("М");
            buttonM.BackColor = Color.LightGray;
            if (res == true) buttonM.BackColor = Color.YellowGreen; buttonM.Enabled = false;
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            keyboard("Н");
            buttonN.BackColor = Color.LightGray;
            if (res == true) buttonN.BackColor = Color.YellowGreen; buttonN.Enabled = false;
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            keyboard("О");
            buttonO.BackColor = Color.LightGray;
        if (res == true) buttonO.BackColor = Color.YellowGreen; buttonO.Enabled = false;
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            keyboard("П");
            buttonP.BackColor = Color.LightGray;
            if (res == true) buttonP.BackColor = Color.YellowGreen; buttonP.Enabled = false;
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            keyboard("Р");
            buttonR.BackColor = Color.LightGray;
            if (res == true) buttonR.BackColor = Color.YellowGreen; buttonR.Enabled = false;
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            keyboard("С");
            buttonS.BackColor = Color.LightGray;
            if (res == true) buttonS.BackColor = Color.YellowGreen; buttonS.Enabled = false;
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            keyboard("Т");
            buttonT.BackColor = Color.LightGray;
            if (res == true) buttonT.BackColor = Color.YellowGreen; buttonT.Enabled = false;
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            keyboard("У");
            buttonY.BackColor = Color.LightGray;
            if (res == true) buttonY.BackColor = Color.YellowGreen; buttonY.Enabled = false;
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            keyboard("Ф");
            buttonF.BackColor = Color.LightGray;
            if (res == true) buttonF.BackColor = Color.YellowGreen; buttonF.Enabled = false;
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            keyboard("Х");
            buttonX.BackColor = Color.LightGray;
            if (res == true) buttonX.BackColor = Color.YellowGreen; buttonX.Enabled = false;
        }

        private void buttonTS_Click(object sender, EventArgs e)
        {
            keyboard("Ц");
            buttonTS.BackColor = Color.LightGray;
            if (res == true) buttonTS.BackColor = Color.YellowGreen; buttonTS.Enabled = false;
        }

        private void buttonCH_Click(object sender, EventArgs e)
        {
            keyboard("Ч");
            buttonCH.BackColor = Color.LightGray;
            if (res == true) buttonCH.BackColor = Color.YellowGreen; buttonCH.Enabled = false;
        }

        private void buttonSHE_Click(object sender, EventArgs e)
        {
            keyboard("Ш");
            buttonSHE.BackColor = Color.LightGray;
            if (res == true) buttonSHE.BackColor = Color.YellowGreen; buttonSHE.Enabled = false;
        }

        private void buttonSHEE_Click(object sender, EventArgs e)
        {
            keyboard("Щ");
            buttonSHEE.BackColor = Color.LightGray;
            if (res == true) buttonSHEE.BackColor = Color.YellowGreen; buttonSHEE.Enabled = false;
        }

        private void buttonTznak_Click(object sender, EventArgs e)
        {
            keyboard("Ъ");
            buttonTznak.BackColor = Color.LightGray;
            if (res == true) buttonTznak.BackColor = Color.YellowGreen; buttonTznak.Enabled = false;
        }

        private void buttonYI_Click(object sender, EventArgs e)
        {
            keyboard("Ы");
            buttonYI.BackColor = Color.LightGray;
            if (res == true) buttonYI.BackColor = Color.YellowGreen; buttonYI.Enabled = false;
        }

        private void buttonMZnak_Click(object sender, EventArgs e)
        {
            keyboard("Ь");
            buttonMZnak.BackColor = Color.LightGray;
            if (res == true) buttonMZnak.BackColor = Color.YellowGreen; buttonMZnak.Enabled = false;
        }

        private void buttonEE_Click(object sender, EventArgs e)
        {
            keyboard("Э");
            buttonEE.BackColor = Color.LightGray;
            if (res == true) buttonEE.BackColor = Color.YellowGreen; buttonEE.Enabled = false;
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            keyboard("Ю");
            buttonU.BackColor = Color.LightGray;
            if (res == true) buttonU.BackColor = Color.YellowGreen; buttonU.Enabled = false;
        }

        private void buttonYa_Click(object sender, EventArgs e)
        {
            keyboard("Я");
            buttonYa.BackColor = Color.LightGray;
            if (res == true) buttonYa.BackColor = Color.YellowGreen; buttonYa.Enabled = false;
        }


        //Продолжить
        private void buttonWordContinue_Click(object sender, EventArgs e)
        {
            fileScript();
            
            labelW1.Text = "_";
            labelW2.Text = "_";
            labelW3.Text = "_";
            labelW4.Text = "_";
            labelW5.Text = "_";
            labelW6.Text = "_";
            labelW7.Text = "_";
            labelW8.Text = "_";
            labelW9.Text = "_";
            labelW10.Text = "_";
            labelW11.Text = "_";
     
            all = 0;
            incorrect = 0;
            i = 0;
            res = false;

            



    }


    //Назвать слово целиком

    private void buttonWordSayFull_Click(object sender, EventArgs e)
        {

        }


        //Пропустить слово

        private void buttonWordSkip_Click(object sender, EventArgs e)
        {

        }


        //
    }
}
