using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_3_2
{
    public partial class Form2 : Form
    {
        private Good good2;
        public Form2(Good g, bool flag)
        {
            InitializeComponent();
            good2 = g;
            if (!flag)
            {
                textBox2_NameGood.Text = g.Name;
                textBox2_GoodDescription.Text = g.Description;
                textBox2_GoodPrice.Text = g.Price.ToString();
                button_Ok.Text = "Изменить";
            }
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            if (textBox2_NameGood.Text == "" || textBox2_GoodDescription.Text == "" || textBox2_GoodPrice.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (Convert.ToDouble(textBox2_GoodPrice.Text) < 0)
                {
                    MessageBox.Show("Цена не может быть меньше 0", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                good2.Name = textBox2_NameGood.Text;
                good2.Description = textBox2_GoodDescription.Text;
                good2.Price = Convert.ToDouble(textBox2_GoodPrice.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Введите цену корректно!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
