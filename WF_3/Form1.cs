using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    //Задание 1
    //Разработайте программу, которая позволяет пользователю осу-
    //ществлять поиск файлов по заданному критерию.Приложение состо-
    //ит из двух форм – главное окно и окно поиска.Пользователь может
    //открыть сколько угодно окон для поиска. Окно поиска запускается
    //немодально. В окне поиска пользователь выбирает папку, в которой
    //будет идти поиск и вводит маску поиска, например «*.doc». Найден-
    //ные файлы отображаются в списке.

namespace WF_3
{
    public partial class Form1 : Form
    {
        private int counter = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2 (counter);
            form.Show();
            counter++;
        }
    }
}
