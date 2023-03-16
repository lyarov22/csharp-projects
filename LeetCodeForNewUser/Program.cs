Console.WriteLine("Калькулятор");

double a;
double b;
double result;
string operation;

Console.Write("Введите первое число: ");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите знак операции (+, -, *, /): ");
operation = Console.ReadLine();

Console.Write("Введите второе число: ");
b = Convert.ToDouble(Console.ReadLine());

switch (operation)
{
    case "+":
        result = Sum(a, b);
        Console.WriteLine($"Результат: {result}");
        break;
    case "-":
        result = Sub(a, b);
        Console.WriteLine($"Результат: {result}");
        break;
    case "*":
        result = Mult(a, b);
        Console.WriteLine($"Результат: {result}");
        break;
    case "/":
        result = Div(a, b);
        Console.WriteLine($"Результат: {result}");
        break;
}

Console.ReadKey();

    static double Sum(double a, double b)
{
    return a + b;
}

static double Sub(double a, double b)
{
    return a - b;
}

static double Mult(double a, double b)
{
    return a * b;
}

static double Div(double a, double b)
{
    return a / b;
}
