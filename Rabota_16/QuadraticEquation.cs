using System;

namespace QuadraticEquationSolver
{
    public class QuadraticEquation
    {
        // Коэффициенты квадратного уравнения
        private readonly double a;
        private readonly double b;
        private readonly double c;

        // Расчетные свойства
        private double discriminant;
        private double? root1;
        private double? root2;

        // Флаг, указывающий на наличие решения
        private bool isSolved;

        // Конструктор для инициализации коэффициентов
        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            isSolved = false;
        }

        // Свойство для доступа к дискриминанту (только чтение)
        public double Discriminant
        {
            get { return discriminant; }
        }

        // Свойство для доступа к первому корню (только чтение)
        public double? Root1
        {
            get { return root1; }
        }

        // Свойство для доступа ко второму корню (только чтение)
        public double? Root2
        {
            get { return root2; }
        }

        // Свойство для доступа к флагу решения
        public bool IsSolved
        {
            get { return isSolved; }
            set { isSolved = value; }
        }

        // Метод для решения квадратного уравнения
        public void Solve()
        {
            discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                isSolved = false;
            }
            else
            {
                isSolved = true;
                root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            }
        }
    }
}