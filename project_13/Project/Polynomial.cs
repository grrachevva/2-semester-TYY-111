using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Polynomial
{
    private int Id; //Id
    private List<int> coefficients; //список коэффициентов полинома, начиная с младшего члена
    private string variable; //имя переменной аргумента
    private string functionName; //имя функции полинома

    public Polynomial(IEnumerable<int> coefficients, string variable = "x", string functionName = "f")
    {
        this.coefficients = coefficients.ToList();
        this.variable = variable;
        this.functionName = functionName;
    }

    public void SaveToFile(string fileName)
    //метод для сохранения полинома в файл
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(this.variable);
            writer.WriteLine(this.functionName);
            writer.WriteLine(string.Join(" ", this.coefficients));
        }
    }

    public static Polynomial LoadFromFile(string fileName)
    //метод для загрузки полинома из файла
    {
        string[] lines = File.ReadAllLines(fileName);
        string variable = lines[0];
        string functionName = lines[1];
        int[] coefficients = lines[2].Split().Select(int.Parse).ToArray();
        return new Polynomial(coefficients, variable, functionName);
    }

    public static Polynomial operator +(Polynomial p1, Polynomial p2)
    //сложение двух полиномов
    {
        int maxDegree = Math.Max(p1.coefficients.Count, p2.coefficients.Count);
        List<int> resultCoefficients = new List<int>(new int[maxDegree]);

        // Если у какого-то полинома нет определенной степени, дополняем нулем
        for (int i = 0; i < maxDegree; i++)
        {
            int thisCoeff = i < p1.coefficients.Count ? p1.coefficients[i] : 0;
            int otherCoeff = i < p2.coefficients.Count ? p2.coefficients[i] : 0;
            resultCoefficients[i] = thisCoeff + otherCoeff;
        }

        return new Polynomial(resultCoefficients, p1.variable, p1.functionName);
    }

    public static Polynomial operator -(Polynomial p1, Polynomial p2)
    //вычитание двух полиномов
    {
        int maxDegree = Math.Max(p1.coefficients.Count, p2.coefficients.Count);
        List<int> resultCoefficients = new List<int>(new int[maxDegree]);

        // Если у какого-то полинома нет определенной степени, дополняем нулем
        for (int i = 0; i < maxDegree; i++)
        {
            int thisCoeff = i < p1.coefficients.Count ? p1.coefficients[i] : 0;
            int otherCoeff = i < p2.coefficients.Count ? p2.coefficients[i] : 0;
            resultCoefficients[i] = thisCoeff - otherCoeff;
        }

        return new Polynomial(resultCoefficients, p1.variable, p1.functionName);
    }

    public static Polynomial operator *(Polynomial p1, Polynomial p2)
    //умножение двух полиномов
    {
        int newDegree = p1.coefficients.Count + p2.coefficients.Count - 1;
        List<int> resultCoefficients = new List<int>(new int[newDegree]);

        for (int i = 0; i < p1.coefficients.Count; i++)
        {
            for (int j = 0; j < p2.coefficients.Count; j++)
            {
                resultCoefficients[i + j] += p1.coefficients[i] * p2.coefficients[j];
            }
        }

        return new Polynomial(resultCoefficients, p1.variable, p1.functionName);
    }

    public static Polynomial operator ++(Polynomial p)
    //увеличение степени полинома
    {
        List<int> resultCoefficients = new List<int> { 0 };
        resultCoefficients.AddRange(p.coefficients);
        return new Polynomial(resultCoefficients, p.variable, p.functionName);
    }

    public static Polynomial operator --(Polynomial p)
    //уменьшение степени полинома
    {
        if (p.coefficients.Count == 1)
            throw new InvalidOperationException("Cannot decrease the degree of a zero polynomial.");

        List<int> resultCoefficients = p.coefficients.Skip(1).ToList();
        return new Polynomial(resultCoefficients, p.variable, p.functionName);
    }

    public void ChangeVariableName(string newVariable)
    //метод для изменения имени переменной полинома
    {
        this.variable = newVariable;
    }

    public void ChangeFunctionName(string newFunctionName)
    //метод для изменения имени функции полинома
    {
        this.functionName = newFunctionName;
    }

    public int[] GetCoefficients()
    //получение массива коэффициентов
    {
        // Возвращаем массив коэффициентов, начиная с младшего члена (степени 0)
        return this.coefficients.ToArray();
    }

    public void ResetCoefficients(IEnumerable<int> newCoefficients)
    {
        this.coefficients = newCoefficients.ToList();
    }

    public void SetCoefficient(int degree, int coefficient)
    //метод: установка коэффициентов полинома
    {
        if (degree < 0 || degree >= this.coefficients.Count)
            throw new ArgumentOutOfRangeException(nameof(degree), "Degree out of range.");

        this.coefficients[degree] = coefficient;
    }

    public override string ToString()
    //перегрузка метода ToString - вывод полинома на экран
    {
        var terms = new List<string>();

        for (int i = this.coefficients.Count - 1; i >= 0; i--)
        {
            if (this.coefficients[i] == 0) continue;

            string term = this.coefficients[i].ToString();
            if (i > 0) term += this.variable;
            if (i > 1) term += "^" + i;

            if (terms.Count > 0 && this.coefficients[i] > 0)
            {
                term = "+" + term;
            }

            terms.Add(term);
        }

        return $"{this.functionName}({this.variable}) = " + string.Join(" ", terms);
    }

    public override bool Equals(object obj)
    //метод сравнения двух полиномов
    //полиномы считаются равными, если их степени равны
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Polynomial other = (Polynomial)obj;

        // Проверяем равенство степеней полиномов
        return this.coefficients.Count == other.coefficients.Count;
    }

    public override int GetHashCode()
    //метод получения hash-кода полинома
    {
        int hash = this.coefficients.Sum(c => Math.Abs(c));
        hash += char.ToUpper(this.variable[0]) - 'A' + 1;
        hash += char.ToUpper(this.functionName[0]) - 'A' + 1;
        return hash;
    }
}
