public class Calculator
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
    public double Divide(int a, int b) => b != 0 ? (double)a / b : throw new DivideByZeroException();

    // Новые расширенные методы
    public int Power(int baseNum, int exponent) => (int)Math.Pow(baseNum, exponent);
    public int Factorial(int n) => n <= 1 ? 1 : n * Factorial(n - 1);
    public bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
            if (number % i == 0) return false;
        return true;
    }
}

public class StatisticsCalculator
{
    public double CalculateAverage(params double[] numbers)
    {
        if (numbers.Length == 0) throw new ArgumentException("Массив не может быть пустым");
        return numbers.Average();
    }

    public double FindMax(params double[] numbers)
    {
        if (numbers.Length == 0) throw new ArgumentException("Массив не может быть пустым");
        return numbers.Max();
    }
}