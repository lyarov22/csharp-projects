using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using System.IO;
using System.Drawing.Printing;

namespace simpleNotepad3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }




        /// <summary>
        /// Установка отметки строк меню Font->CharacterStyle
        /// </summary>
        private void CheckMenuFontCharacterStyle()
        {
            if (richTextBox1.SelectionFont.Bold == true)
            {
                menuFormatFontCharacterStyleBold.Checked = true;
            }
            else
            {
                menuFormatFontCharacterStyleBold.Checked = false;
            }

            if (richTextBox1.SelectionFont.Italic == true)
            {
                menuFormatFontCharacterStyleItalic.Checked = true;
            }
            else
            {
                menuFormatFontCharacterStyleItalic.Checked = false;
            }

            if (richTextBox1.SelectionFont.Underline == true)
            {
                menuFormatFontCharacterStyleUnderline.Checked = true;
            }
            else
            {
                menuFormatFontCharacterStyleUnderline.Checked = false;
            }

            if (richTextBox1.SelectionFont.Strikeout == true)
            {
                зачеркнутый.Checked = true;
            }
            else
            {
                зачеркнутый.Checked = false;
            }
        }


        /// <summary>
        /// Установка стиля символов Bold
        /// </summary>
        private void SetBold()
        {
            if (richTextBox1.SelectionFont != null)
            {
                System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (richTextBox1.SelectionFont.Bold == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Bold;
                }

                richTextBox1.SelectionFont = new Font(
                  currentFont.FontFamily, currentFont.Size, newFontStyle);

                CheckMenuFontCharacterStyle();
            }
        }

        /// <summary>
        /// Установка стиля символов Italic
        /// </summary>
        private void SetItalic()
        {
            if (richTextBox1.SelectionFont != null)
            {
                System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                System.Drawing.FontStyle newFontStyle;
                CheckMenuFontCharacterStyle();

                if (richTextBox1.SelectionFont.Italic == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Italic;
                }

                richTextBox1.SelectionFont = new Font(
                  currentFont.FontFamily, currentFont.Size, newFontStyle);

                CheckMenuFontCharacterStyle();
            }
        }

        /// <summary>
        /// Установка стиля символов Underline
        /// </summary>
        private void SetUnderline()
        {
            if (richTextBox1.SelectionFont != null)
            {
                System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                System.Drawing.FontStyle newFontStyle;
                CheckMenuFontCharacterStyle();

                if (richTextBox1.SelectionFont.Underline == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Underline;
                }

                richTextBox1.SelectionFont = new Font(
                  currentFont.FontFamily, currentFont.Size, newFontStyle);

                CheckMenuFontCharacterStyle();
            }
        }

        /// <summary>
        /// Установка стиля символов Strikeout
        /// </summary>
        private void SetStrikeout()
        {
            if (richTextBox1.SelectionFont != null)
            {
                System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                System.Drawing.FontStyle newFontStyle;

                if (richTextBox1.SelectionFont.Strikeout == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Strikeout;
                }

                richTextBox1.SelectionFont = new Font(
                  currentFont.FontFamily, currentFont.Size, newFontStyle);

                CheckMenuFontCharacterStyle();
            }
        }


        /// <summary>
        /// StringReader для печати содержимого редактора текста
        /// </summary>
        private StringReader m_myReader;

        /// <summary>
        /// Номер текущей распечатываемой страницы документа
        /// </summary>
        private uint m_PrintPageNumber;
        private bool m_DocumentChanged = false;

        private void richTextBox1_TextChanged(object sender, System.EventArgs e)
        {
            m_DocumentChanged = true;
        }

        private void видToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_DocumentChanged)
                if (saveFileDialog1.ShowDialog() ==
                System.Windows.Forms.DialogResult.OK &&
                saveFileDialog1.FileName.Length > 0)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                    this.Text = "Файл [" + saveFileDialog1.FileName + "]";

                }
            richTextBox1.Clear();


        }

        private void открытToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() ==
                System.Windows.Forms.DialogResult.OK &&
                openFileDialog1.FileName.Length > 0)
            {
                try
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName,
                       RichTextBoxStreamType.RichText);
                }
                catch (System.ArgumentException ex)
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName,
                       RichTextBoxStreamType.PlainText);
                }

                this.Text = "Файл [" + openFileDialog1.FileName + "]";
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() ==
                 System.Windows.Forms.DialogResult.OK &&
                 saveFileDialog1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                this.Text = "Файл [" + saveFileDialog1.FileName + "]";

            }

            if (saveFileDialog1.ShowDialog() ==
                 System.Windows.Forms.DialogResult.OK &&
                 saveFileDialog1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                m_DocumentChanged = false;
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() ==
                System.Windows.Forms.DialogResult.OK &&
                saveFileDialog1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                this.Text = "Файл [" + saveFileDialog1.FileName + "]";

            }


        }

        private void параметрыСтраницыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuFilePrint();
        }

        private void предпросмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuFilePrintPreview();
        }

        /// <summary>
        /// Предварительный просмотр перед печатью документа
        /// </summary>
        private void MenuFilePrintPreview()
        {
            m_PrintPageNumber = 1;

            string strText = this.richTextBox1.Text;
            m_myReader = new StringReader(strText);
            Margins margins = new Margins(100, 50, 50, 50);

            printDocument1.DefaultPageSettings.Margins = margins;
            printPreviewDialog1.ShowDialog();

            m_myReader.Close();
        }

        /// <summary>
        /// Печать документа
        /// </summary>
        private void MenuFilePrint()
        {
            m_PrintPageNumber = 1;

            string strText = this.richTextBox1.Text;
            m_myReader = new StringReader(strText);

            Margins margins = new Margins(100, 50, 50, 50);
            printDocument1.DefaultPageSettings.Margins = margins;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
            m_myReader.Close();
        }

        /// <summary>
        /// Обработка события PrintPage
        /// </summary>
        private void PrintPageEventHandler(object sender,
          System.Drawing.Printing.PrintPageEventArgs e)
        {
            int lineCount = 0;       // счетчик строк
            float linesPerPage = 0;  // количество строк на одной странице
            float yLinePosition = 0; // текущая позиция при печати по
                                     // вертикальной оси
            string currentLine = null;  // текст текущей строки

            // Шрифт для печати текста
            Font printFont = this.richTextBox1.Font;

            // Кисть для печати текста
            SolidBrush printBrush = new SolidBrush(Color.Black);

            // Размер отступа слева
            float leftMargin = e.MarginBounds.Left;

            // Размер отступа сверху
            float topMargin = e.MarginBounds.Top +
               3 * printFont.GetHeight(e.Graphics);

            // Вычисляем количество строк на одной странице с учетом отступа
            linesPerPage = (e.MarginBounds.Height -
               6 * printFont.GetHeight(e.Graphics)) /
               printFont.GetHeight(e.Graphics);

            // Цикл печати всех строк страницы
            while (lineCount < linesPerPage &&
               ((currentLine = m_myReader.ReadLine()) != null))
            {
                // Вычисляем позицию очередной распечатываемой строки
                yLinePosition = topMargin + (lineCount *
                  printFont.GetHeight(e.Graphics));

                // Печатаем очередную строку
                e.Graphics.DrawString(currentLine, printFont, printBrush,
                  leftMargin, yLinePosition, new StringFormat());

                // Переходим к следующей строке
                lineCount++;
            }

            // Печать колонтитулов страницы

            // Номер текущей страницы
            string sPageNumber = "Page " + m_PrintPageNumber.ToString();

            // Вычисляем размеры прямоугольной области, занимаемой верхним
            // колонтитулом страницы
            SizeF stringSize = new SizeF();
            stringSize = e.Graphics.MeasureString(sPageNumber, printFont,
               e.MarginBounds.Right - e.MarginBounds.Left);

            // Печатаем номер страницы
            e.Graphics.DrawString(sPageNumber, printFont, printBrush,
               e.MarginBounds.Right - stringSize.Width, e.MarginBounds.Top,
               new StringFormat());

            // Печатаем имя файла документа
            e.Graphics.DrawString(this.Text, printFont, printBrush,
               e.MarginBounds.Left, e.MarginBounds.Top, new StringFormat());

            // Кисть для рисования горизонтальной линии,
            // отделяющей верхний колонтитул
            Pen colontitulPen = new Pen(Color.Black);
            colontitulPen.Width = 2;

            // Рисуем верхнюю линию
            e.Graphics.DrawLine(colontitulPen,
               leftMargin,
               e.MarginBounds.Top + printFont.GetHeight(e.Graphics) + 3,
               e.MarginBounds.Right, e.MarginBounds.Top +
               printFont.GetHeight(e.Graphics) + 3);

            // Рисуем линию, отделяющую нижний колонтитул документа
            e.Graphics.DrawLine(colontitulPen,
               leftMargin, e.MarginBounds.Bottom - 3,
               e.MarginBounds.Right, e.MarginBounds.Bottom - 3);

            // Печатаем текст нижнего колонтитула
            e.Graphics.DrawString(
            "SimpleNotepad, (c) Александр Фролов, http://www.frolov.pp.ru",
               printFont, printBrush,
               e.MarginBounds.Left, e.MarginBounds.Bottom, new StringFormat());

            // Если напечатаны не все строки документа,
            // переходим к следующей странице
            if (currentLine != null)
            {
                e.HasMorePages = true;
                m_PrintPageNumber++;
            }

            // Иначе завершаем печать страницы
            else
                e.HasMorePages = false;

            // Освобождаем ненужные более ресурсы
            printBrush.Dispose();
            colontitulPen.Dispose();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (m_DocumentChanged)
                if (saveFileDialog1.ShowDialog() ==
                System.Windows.Forms.DialogResult.OK &&
                saveFileDialog1.FileName.Length > 0)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                    this.Text = "Файл [" + saveFileDialog1.FileName + "]";

                }

            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_DocumentChanged)
                if (saveFileDialog1.ShowDialog() ==
                System.Windows.Forms.DialogResult.OK &&
                saveFileDialog1.FileName.Length > 0)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                    this.Text = "Файл [" + saveFileDialog1.FileName + "]";

                }
            this.Close();
        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void вернутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void очиститьВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void выбратьВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void подчёркнутыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetUnderline();
        }

        private void стильСимволовToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void жирныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBold();
        }

        private void наклонныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetItalic();
        }

        private void зачёркнутыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStrikeout();
        }

        private void слеваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void справаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void поЦентруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form dlgAbout = new Form2();
            dlgAbout.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical | RichTextBoxScrollBars.Horizontal;


        }



        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void включитьПереносToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = true;
        }

        private void отключитьПереносToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = false;
        }
    } 
}
