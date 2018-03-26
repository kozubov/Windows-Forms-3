using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    //Задание 3
    //Разработайте приложение, которое состоит из двух форм.
    //Первая форма содержит TextBox доступный только для чтения и две кнопки
    //«загрузить файл» и «редактировать». Кнопка «редактировать» изначально неактивна.
    //При нажатии на первую кнопку, открывается диалог и пользователю предлагают выбрать текстовый файл.
    //Выбранный файл загружается в TextBox и кнопка «редактировать» становится активной.
    //При нажатии на вторую кнопку открывается вторая форма (не модально), которая содержит TextBox доступный
    //для редактирования и две кнопки «Сохранить» и «Отменить».
    //При нажатии на первую кнопку изменения отображаются в TextBox первой формы.

namespace WF_3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public TextBox getTextBox_loadedFile()
        {
            return this.textBox1__LoadFileWindow;
        }
        public void setTextBox_loadedFile(TextBox text)
        {
            this.textBox1__LoadFileWindow.Text = text.Text;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "TXT Files (.txt)|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader openedFile = new StreamReader(openFile.FileName);
                textBox1__LoadFileWindow.BackColor = Color.White;
                textBox1__LoadFileWindow.Clear();
                textBox1__LoadFileWindow.Text = openedFile.ReadToEnd();
                openedFile.Close();
                bunifuFlatButton1_EditFile.Enabled = true;
            }
        }

        private void bunifuFlatButton1_EditFile_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);
            form.Show();
        }
    }
}
