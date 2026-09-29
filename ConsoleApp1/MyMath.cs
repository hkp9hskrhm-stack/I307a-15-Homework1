namespace ConsoleApp1;

public class MyMath
{
    public double Sum(double[] numbers)
    {
        double sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }

        return sum;
    }

    public double Count(double[] numbers)
    {
        return numbers.Length;
    }

    public double Max(double[] numbers)
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

    public double Min(double[] numbers)
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
}