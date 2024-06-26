using System;
using System.Drawing;
using System.Windows.Forms;

namespace A_N_1
{
    public partial class BlockingButtonsForm : Form
    {
        public BlockingButtonsForm()
        {
            InitializeComponent();
        }

        private void Knopka1_Click(object sender, EventArgs e)
        {

        }

        private void Knopka1_MouseDown(object sender, MouseEventArgs e)
        {
            //проверяем, была ли нажата правая кнопка мыши
            if (e.Button == MouseButtons.Right)
            {
                //была нажата правая кнопка мыши
                Lower.Enabled = true; //делаем доступной нижнюю кнопку
                Upper.Enabled = false; //делаем недоступной верхнюю кнопку
            }
        }

        private void Knopka2_MouseDown(object sender, MouseEventArgs e)
        {
            //проверяем, была ли нажата правая кнопка мыши
            if (e.Button == MouseButtons.Right)
            {
                //была нажата правая кнопка мыши
                Upper.Enabled = true; //делаем доступной верхнюю кнопку
                Lower.Enabled = false; //делаем недоступной нижнюю кнопку
            }
        }

        private void Lower_Click(object sender, EventArgs e)
        {

        }
    }
}
