using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace NotePad_Tarasov
{
    public partial class Form1 : Form
    {
        ColorDialog color_ = new ColorDialog();
        FontDialog font_ = new FontDialog();
        PrintDialog print_ = new PrintDialog();
        PrintPreviewDialog print_preview = new PrintPreviewDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void поЦентруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_main.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
            {
                richTextBox_main.Clear(); //Очищаем richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //Указываем что нас интересуют только текстовые файлы
                string fileName = openFileDialog1.FileName; //получаем наименование файл и путь к нему.
                richTextBox_main.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаем содержимое файла в richTextBox
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
            saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию 3
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтверждение сохранения информации.
            {
                var name = saveFileDialog1.FileName; //Задаем имя файлу
                File.WriteAllText(name, richTextBox_main.Text, Encoding.GetEncoding(1251)); //Записываем в файл содержимое textBox с кодировкой 1251
            }
            richTextBox_main.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBox_main.Clear();
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            richTextBox_main.Cut();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            richTextBox_main.SelectAll();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            richTextBox_main.Paste();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            richTextBox_main.Copy();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (color_.ShowDialog() == DialogResult.OK)
                richTextBox_main.SelectionColor = color_.Color;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (font_.ShowDialog() == DialogResult.OK)
                richTextBox_main.SelectionFont = font_.Font;
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (print_.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font myFont = new Font("Tahoma", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            string Hello = "Привет печать!";
            e.Graphics.DrawString(Hello, myFont, Brushes.Black, 20, 20);
        }

        private void левоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_main.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void правоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_main.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (font_.ShowDialog() == DialogResult.OK)
                richTextBox_main.SelectionFont = font_.Font;
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (color_.ShowDialog() == DialogResult.OK)
                richTextBox_main.SelectionColor = color_.Color;
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_main.Cut();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_main.Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_main.Paste();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_main.Clear();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
            {
                richTextBox_main.Clear(); //Очищаем richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //Указываем что нас интересуют только текстовые файлы
                string fileName = openFileDialog1.FileName; //получаем наименование файл и путь к нему.
                richTextBox_main.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаем содержимое файла в richTextBox
            }
        }

        private void сохронитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
            saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию 3
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтверждение сохранения информации.
            {
                var name = saveFileDialog1.FileName; //Задаем имя файлу
                File.WriteAllText(name, richTextBox_main.Text, Encoding.GetEncoding(1251)); //Записываем в файл содержимое textBox с кодировкой 1251
            }
            richTextBox_main.Clear();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void предварительныйПросмоотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            print_preview.ShowDialog();
        }
    }
}
