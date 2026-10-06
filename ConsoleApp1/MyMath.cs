namespace ConsoleApp1;

public class MyMath
{
    public double Plus(double num1, double num2)
    {
        return num1 + num2;
    }

    public double Minus(double num1, double num2)
    {
        return num1 - num2;
    }

    public double Div(double num1, double num2)
    {
        return num1 / num2;
    }

    public double Per(double num)
    {
        return num / 100;
    }

    public double Mul(double num1, double num2)
    {
        return num1 * num2;
    }

    public double Sum(params double[] numbers)
    {
        double sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }

        return sum;
    }

    public double Min(params double[] numbers)
    {
        double min = numbers[0];
        foreach (var num in numbers)
        {
            if (num < min)
            {
                min = num;
            }
        }

        return min;
    }

    public double Max(params double[] numbers)
    {
        double max = numbers[0];
        foreach (var num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        return max;
    }

    public double Factorial(double number)
    {
        if (number == 0)
            return 1;

        return number * Factorial(number - 1);
    }

    public double Count(double[] numbers)
    {
        return numbers.Length;
    }

    public double[] Sort(double[] numbers, bool descending = false)
    {
        numbers.Sort((x, y) =>
        {
            if (descending)
                return y.CompareTo(x);
            else
                return x.CompareTo(y);
        });
        return numbers;
    }

    public double Per(double number, double basic)
    {
        return (number / basic) * 100;
    }

    public double Deper(short percent, double number)
    {
        return number * percent / 100;
    }

    public double SquarePow(double number)
    {
        return number * number;
    }

    public double CubePow(double number)
    {
        return number * number * number;
    }

    public double SquareRoot(double number)
    {
        if (number < 1) return number;

        double start = 0;
        double end = (number < 1) ? 1 : number;
        double lastMid = 0;

        while (true)
        {
            double mid = (start + end) / 2;
            if (mid == lastMid) break;

            if (mid * mid > number)
                end = mid;
            else
                start = mid;

            lastMid = mid;
        }

        return lastMid;
    }

    public double CubeRoot(double number)
    {
        if (number < 1) return number;

        double start = 0;
        double end = (number < 1) ? 1 : number;
        double lastMid = 0;

        while (true)
        {
            double mid = (start + end) / 2;
            if (mid == lastMid) break;

            if (mid * mid * mid > number)
                end = mid;
            else
                start = mid;

            lastMid = mid;
        }

        return lastMid;
    }
}