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

namespace WF_3
{
    public partial class Form2 : Form
    {
        public Form2(int counter)
        {
            InitializeComponent();
            Text = $"Форма поиска: {counter}";
        }
        
        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //проверка на пустое значение и маску "*."
                if (!string.IsNullOrWhiteSpace(textBox2_Mask_Search_Input.Text) &&
                    textBox2_Mask_Search_Input.ToString().Contains("*."))
                {
                    listBox1.Items.Clear();
                    FolderBrowserDialog chooseFolderPath = new FolderBrowserDialog();
                    if (chooseFolderPath.ShowDialog() == DialogResult.OK)
                    {
                        //массив найденых файлов
                        string[] foundFiles =
                            Directory.GetFiles(chooseFolderPath.SelectedPath, textBox2_Mask_Search_Input.Text, SearchOption.AllDirectories);
                        if (foundFiles.Length == 0)
                        {
                            //если длина массива = 0, т.е. файлы не найдены
                            label2_ShowCountFind_Files.ForeColor = Color.Red;
                            label2_ShowCountFind_Files.Text = $"Файлы по маске: {textBox2_Mask_Search_Input.Text} - не найдены";
                        }
                        else
                        {
                            //если файлы найдены
                            label2_ShowCountFind_Files.ForeColor = Color.White;
                            label2_ShowCountFind_Files.Text = $"Найдено: {foundFiles.Length} файлов";

                            foreach (string file in foundFiles)
                            {
                                //выводим построчно все найденный файлы
                                listBox1.Items.Add(file);
                            }
                        }
                    }
                }
                else
                {
                    //сообщение об ошибке при проверке на содержание в расширении "*."
                    MessageBox.Show("Вводите расширение файла по указанной маске!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2_Mask_Search_Input.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так!\nПовторите", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
