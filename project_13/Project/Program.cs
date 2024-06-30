using System;

class Program
{
    static Polynomial G, R; 
    static string fileG = "poly1.txt"; 
    static string fileR = "poly2.txt";

    static void Main()

    {
        CreatePoly(); 
        int choice = -1; //номер пункта меню заведомо ложный,
                         //после выбора пользователя здесь будет корректный номер

        
        while (choice != 22)
        {
            DisplayMenu();
            choice = GetUserChoice(); 
            ProcessChoice(choice); 
            Console.WriteLine(); 
        }
    }

    static void CreatePoly()
    
    {
        G = new Polynomial(new int[] { 1, 7, -2, 1 }, "x", "G");
        R = new Polynomial(new int[] { 0, -1, 0, 9, 0, -1 }, "z", "R");
    }

    static void DisplayMenu()
    
    {
        
        Console.WriteLine("Текущее состояние полиномов:");
        Console.WriteLine(G);
        Console.WriteLine(R);
        Console.WriteLine();

        //пункты меню
        Console.WriteLine("Выберите операцию:");
        Console.WriteLine("1. Сложение полиномов");
        Console.WriteLine("2. Вычитание полиномов");
        Console.WriteLine("3. Умножение полиномов");
        Console.WriteLine("4. Увеличение степени полинома #1");
        Console.WriteLine("5. Уменьшение степени полинома #1");
        Console.WriteLine("6. Увеличение степени полинома #2");
        Console.WriteLine("7. Уменьшение степени полинома #2");
        Console.WriteLine("8. Сравнение полиномов");
        Console.WriteLine("9. Вывести хэш-коды полиномов");
        Console.WriteLine("10. Вывести вектор коэффициентов полинома #1");
        Console.WriteLine("11. Вывести вектор коэффициентов полинома #2");
        Console.WriteLine("12. Смена имени переменной аргумента полинома #1");
        Console.WriteLine("13. Смена имени переменной аргумента полинома #2");
        Console.WriteLine("14. Смена имени функции полинома #1");
        Console.WriteLine("15. Смена имени функции полинома #2");
        Console.WriteLine("16. Переназначение всех коэффициентов полинома #1");
        Console.WriteLine("17. Переназначение всех коэффициентов полинома #2");
        Console.WriteLine("18. Переназначение коэффициента при указанной степени в полиноме #1");
        Console.WriteLine("19. Переназначение коэффициента при указанной степени в полиноме #2");
        Console.WriteLine("20. Сохранить полиномы в файлы");
        Console.WriteLine("21. Загрузить полиномы из файлов");
        Console.WriteLine("22. Выход");
    }

    static int GetUserChoice()
    {
        Console.Write("Введите номер операции: ");
        return int.Parse(Console.ReadLine());
    }

    static void ProcessChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                PerformAddition(); //сложение
                break;
            case 2:
                PerformSubtraction(); //вычитание
                break;
            case 3:
                PerformMultiplication(); //умножение
                break;
            case 4:
                IncreaseDegreeG(); //увеличение степени полином #1
                break;
            case 5:
                DecreaseDegreeG(); //уменьшение степени полином #1
                break;
            case 6:
                IncreaseDegreeR(); //увеличение степени полином #2
                break;
            case 7:
                DecreaseDegreeR(); //уменьшение степени полином #2
                break;
            case 8:
                ComparePolynomials(); //сравнение полиномов
                break;
            case 9:
                PrintHashCodes(); //печать hash-кодов
                break;
            case 10:
                PrintCoefficientsG(); //печать коэффициентов (векторов) полинома #1
                break;
            case 11:
                PrintCoefficientsR(); //печать коэффициентов (векторов) полинома #2
                break;
            case 12:
                ChangeVariableNameG(); //изменение переменной полинома #1
                break;
            case 13:
                ChangeVariableNameR(); //изменение переменной полинома #2
                break;
            case 14:
                ChangeFunctionNameG(); //изменение функции полинома #1
                break;
            case 15:
                ChangeFunctionNameR(); //изменение функции полинома #2
                break;
            case 16:
                ResetCoefficientsG(); //переназначение (сброс) всех коэффициентов полинома #1
                break;
            case 17:
                ResetCoefficientsR(); //переназначение (сброс) всех коэффициентов полинома #2
                break;
            case 18:
                SetCoefficientG(); //установка коэффициента для указанной степени полинома #1
                break;
            case 19:
                SetCoefficientR(); //установка коэффициента для указанной степени полинома #2
                break;
            case 20:
                SavePolynomialsToFile(); //сохранение полиномов в файлы
                break;
            case 21:
                LoadPolynomialsFromFile(); //чтение полиномов из файлов
                break;
            case 22:
                break; //выход из программы
            default:
                Console.WriteLine("Неверный выбор!"); //если ввели меньше 1 или больше 22, 
                                            //выводится сообщение об ошибке
                break;
        }
    }


    static void PerformAddition()
    //сложение полиномов
    {
        Polynomial result = G + R;
        Console.WriteLine("Результат сложения: " + result);
    }

    static void PerformSubtraction()
    //вычитание полиномов
    {
        Polynomial result = G - R;
        Console.WriteLine("Результат вычитания: " + result);
    }

    static void PerformMultiplication()
    //умножние полиномов
    {
        Polynomial result = G * R;
        Console.WriteLine("Результат умножения: " + result);
    }

    static void IncreaseDegreeG()
    //увеличение степени полинома
    {
        G++;
        Console.WriteLine("Результат увеличения степени: " + G);
    }

    static void DecreaseDegreeG()
    //уменьшение степени полинома
    {
        G--;
        Console.WriteLine("Результат уменьшения степени: " + G);
    }

    static void IncreaseDegreeR()
    //увеличение степени полинома
    {
        R++;
        Console.WriteLine("Результат увеличения степени: " + R);
    }

    static void DecreaseDegreeR()
    //уменьшение степени полинома
    {
        R--;
        Console.WriteLine("Результат уменьшения степени: " + R);
    }

    static void ComparePolynomials()
    //сравнение полиномов
    {
        if (G.Equals(R))
        {
            Console.WriteLine("Полиномы G и R равны по степени.");
        }
        else
        {
            Console.WriteLine("Полиномы G и R не равны по степени.");
        }
    }

    static void PrintHashCodes()
    //печать hash-кодов
    {
        Console.WriteLine($"HashCode G(x) = {G.GetHashCode()}");
        Console.WriteLine($"HashCode R(z) = {R.GetHashCode()}");
    }

    static void PrintCoefficientsG()
    //печать векторов полинома #1
    {
        Console.WriteLine("Вектор коэффициентов полинома G(x):");
        PrintArray(G.GetCoefficients());
    }

    static void PrintCoefficientsR()
    //печать векторов полинома #2
    {
        Console.WriteLine("Вектор коэффициентов полинома R(z):");
        PrintArray(R.GetCoefficients());
    }

    static void ChangeVariableNameG()
    //изменение названия переменной полинома #1
    {
        Console.Write("Введите новое имя переменной аргумента для полинома G: ");
        string newVarG = Console.ReadLine();
        G.ChangeVariableName(newVarG);
    }

    static void ChangeVariableNameR()
    //изменение названия переменной полинома #2
    {
        Console.Write("Введите новое имя переменной аргумента для полинома R: ");
        string newVarR = Console.ReadLine();
        R.ChangeVariableName(newVarR);
    }

    static void ChangeFunctionNameG()
    //изменение названия функции полинома #1
    {
        Console.Write("Введите новое имя функции для полинома G: ");
        string newFuncG = Console.ReadLine();
        G.ChangeFunctionName(newFuncG);
    }

    static void ChangeFunctionNameR()
    //изменение названия функции полинома #2
    {
        Console.Write("Введите новое имя функции для полинома R: ");
        string newFuncR = Console.ReadLine();
        R.ChangeFunctionName(newFuncR);
    }

    static void ResetCoefficientsG()
    //ввод всех новых коэффициентов для полинома #1
    {
        Console.Write("Введите новые коэффициенты через пробел для полинома G(x) (начиная с самой высокой степени): ");
        int[] newCoeffsG = Console.ReadLine().Split().Select(int.Parse).Reverse().ToArray();
        G.ResetCoefficients(newCoeffsG);
    }

    static void ResetCoefficientsR()
    //ввод всех новых коэффициентов для полинома #2
    {
        Console.Write("Введите новые коэффициенты через пробел для полинома R(z) (начиная с самой высокой степени): ");
        int[] newCoeffsR = Console.ReadLine().Split().Select(int.Parse).Reverse().ToArray();
        R.ResetCoefficients(newCoeffsR);
    }

    static void SetCoefficientG()
    //ввод коэффициента для определенной степени для полинома #1
    {
        Console.Write("Введите степень для изменения коэффициента в полиноме G(x): ");
        int degreeG = int.Parse(Console.ReadLine());
        Console.Write($"Введите новый коэффициент для степени {degreeG}: ");
        int coeffG = int.Parse(Console.ReadLine());
        G.SetCoefficient(degreeG, coeffG);
    }

    static void SetCoefficientR()
    //ввод коэффициента для определенной степени для полинома #2
    {
        Console.Write("Введите степень для изменения коэффициента в полиноме R(z): ");
        int degreeR = int.Parse(Console.ReadLine());
        Console.Write($"Введите новый коэффициент для степени {degreeR}: ");
        int coeffR = int.Parse(Console.ReadLine());
        R.SetCoefficient(degreeR, coeffR);
    }

    static void SavePolynomialsToFile()
    //сохранение полиномов в файлы
    {
        G.SaveToFile(fileG); 
        R.SaveToFile(fileR); 
        Console.WriteLine("Полиномы сохранены в файлы.");
    }

    static void LoadPolynomialsFromFile()
    //загрузка полиномов из файлов
    {
        G = Polynomial.LoadFromFile(fileG);
        R = Polynomial.LoadFromFile(fileR);
        Console.WriteLine("Полиномы загружены из файлов.");
    }

    static void PrintArray(int[] array)
    //печать коэффициентов (векторов) полиномов
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        Console.ReadKey(true);
    }

}
