using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_3_3
{
    public partial class Form2 : Form
    {
        Form1 fileData2;
        public Form2(Form1 fileData)
        {
            InitializeComponent();
            this.fileData2 = fileData;
            textBox2_EditFile.BackColor = Color.White;
            textBox2_EditFile.Text = fileData.getTextBox_loadedFile().Text;
            this.Text = "Редактирование текста файла";
        }
        
        private void bunifuFlatButton2_SaveFile_Click_1(object sender, EventArgs e)
        {
            try
            {
                fileData2.setTextBox_loadedFile(textBox2_EditFile);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bunifuFlatButton2_Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
