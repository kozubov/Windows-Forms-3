using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Задание 2
//Фирма продает составляющие компьютера.Первая форма отвечает за учет продаж, вторая за добавление и редактирование составляющих.
//Первая форма:
//Список, выпадающий список, текстовое поле, кнопка вызова второй формы. В выпадающем списке появляются наименования
//всех товаров, которые в наличие в магазине. Пользователь выбирает товар, в текстовом окне, которое нельзя редактировать,
//появляется цена. Пользователь нажимает «добавить» и товар добавляется в список продаж. Также должно быть окошко, которое выводит
//общую стоимость.
//Вторая форма:
//Информация о комплектующих (наименование, характеристика, описание и цена) вводится в текстовые поля; в список добавляется
//текстовая строка, содержащая информацию о товаре, кроме цены, цена в списке не видна, но содержится; также комплектующие можно
//редактировать.

namespace WF_3_2
{
    public partial class Form1 : Form
    {
        private List<Good> listGoods;
        private double Total = 0;
        public Form1()
        {
            InitializeComponent();
            listGoods = new List<Good>();
            this.comboBox1_ChooseGoodTo.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBox1_PriceChoosenGood.Text = listGoods[comboBox1_ChooseGoodTo.SelectedIndex].Price.ToString("F2");
        }
        private void bunifuFlatButton1_AddToSale_Click(object sender, EventArgs e)
        {
            if (comboBox1_ChooseGoodTo.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали товар!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listBox1_Saled_Goods.Items.Add(listGoods[comboBox1_ChooseGoodTo.SelectedIndex].ToString());
            Total += listGoods[comboBox1_ChooseGoodTo.SelectedIndex].Price;
            textBox1_TotalSalesInfo.Text = Total.ToString("F2");
        }

        private void bunifuFlatButton1_AddToWarehouse_Click(object sender, EventArgs e)
        {
            Good good = new Good();
            Form2 AddGood = new Form2(good, true);
            if (AddGood.ShowDialog() == DialogResult.OK)
            {
                listGoods.Add(good);
                comboBox1_ChooseGoodTo.Items.Add(good);
            }
        }

        private void bunifuFlatButton1_EditGood_Click(object sender, EventArgs e)
        {
            if (comboBox1_ChooseGoodTo.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали товар!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Form2 EditGood = new Form2(listGoods[comboBox1_ChooseGoodTo.SelectedIndex], false);
            int index = comboBox1_ChooseGoodTo.SelectedIndex;
            if (EditGood.ShowDialog() == DialogResult.OK)
            {
                comboBox1_ChooseGoodTo.Items.RemoveAt(index);
                comboBox1_ChooseGoodTo.Items.Insert(index, listGoods[index].Name);
                comboBox1_ChooseGoodTo.SelectedIndex = index;

            }
        }
    }
}
