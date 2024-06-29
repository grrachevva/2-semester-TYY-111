using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuadraticEquationSolver
{
    public partial class MainForm : Form
    {
        private List<QuadraticEquation> equationsList = new List<QuadraticEquation>();

        public MainForm()
        {
            InitializeComponent();
        }

        // Обработчик нажатия кнопки "Решить уравнение"
        private void solveButton_Click(object sender, EventArgs e)
        {
            double a = double.Parse(coeffATextBox.Text);
            double b = double.Parse(coeffBTextBox.Text);
            double c = double.Parse(coeffCTextBox.Text);

            QuadraticEquation equation = new QuadraticEquation(a, b, c);
            equation.Solve();

            if (equation.IsSolved)
            {
                statusLabel.Text = "Решено";
                discriminantLabel.Text = $"Дискриминант: {equation.Discriminant}";
                root1Label.Text = $"Корень 1: {equation.Root1}";
                root2Label.Text = $"Корень 2: {equation.Root2}";

                // Добавление уравнения в список и в ListBox
                equationsList.Add(equation);
                equationsListBox.Items.Add($"Уравнение {equationsList.Count}"); // Можно задать другое отображение в ListBox
            }
            else
            {
                statusLabel.Text = "Не решено";
                discriminantLabel.Text = "";
                root1Label.Text = "";
                root2Label.Text = "";
            }
        }

        // Обработчик нажатия кнопки "Очистить"
        private void clearButton_Click(object sender, EventArgs e)
        {
            equationsList.Clear();
            equationsListBox.Items.Clear();
        }

        // Обработчик выбора элемента в списке уравнений
        private void equationsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = equationsListBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < equationsList.Count)
            {
                QuadraticEquation selectedEquation = equationsList[selectedIndex];
                statusLabel.Text = selectedEquation.IsSolved ? "Решено" : "Не решено";
                discriminantLabel.Text = $"Дискриминант: {selectedEquation.Discriminant}";
                root1Label.Text = $"Корень 1: {selectedEquation.Root1}";
                root2Label.Text = $"Корень 2: {selectedEquation.Root2}";
            }
        }
    }
}