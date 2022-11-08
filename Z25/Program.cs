Console.WriteLine("Введите число, которое нужно возвести в степень");
double numA;
while (!double.TryParse(Console.ReadLine()!, out numA))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine ("Неверный ввод");
    Console.ResetColor(); 
    Console.WriteLine("Введите число, которое нужно возвести в степень");   
}

Console.WriteLine("Введите натуральную степень");
int numB;
while (!int.TryParse(Console.ReadLine()!, out numB) || numB<=0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine ("Неверный ввод");
    Console.ResetColor(); 
    Console.WriteLine("Введите натуральную степень");   
}

double Pow(double numA, double numB)
{
    double pow = Math.Pow(numA, numB);
    return pow;
}

double result = Pow(numA, numB);

Console.WriteLine($"{numA} ^ {numB} = " + result);
