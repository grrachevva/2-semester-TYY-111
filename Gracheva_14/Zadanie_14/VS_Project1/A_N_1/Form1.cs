using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_N_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
            //нажатие клавиши мыши на кнопке Button1
        {
            //проверяем, была ли нажата правая кнопка мыши
            if (e.Button == MouseButtons.Right)
            {
                //была нажата правая кнопка мыши
                button2.Enabled = true; //делаем доступной вторую кнопку
                button1.Enabled = false; //делаем недоступной первую кнопку
            }
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        //нажатие клавиши мыши на кнопке Button2
        {
            //проверяем, была ли нажата правая кнопка мыши
            if (e.Button == MouseButtons.Right)
            {
                //была нажата правая кнопка мыши
                button1.Enabled = true; //делаем доступной первую кнопку
                button2.Enabled = false; //делаем недоступной вторую кнопку
            }
        }
    }
}
