namespace ConsoleApp1;

public class Math
{
    public double Sum(int[] numbers)
    {
        var sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }

        return sum;
    }

    public double Count(int[] numbers)
    {
        return numbers.Length;
    }

    public double Max(int[] numbers)
    {
        var max = numbers[0];
        foreach (var num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        return max;
    }

    public double Min(int[] numbers)
    {
        var min = numbers[0];
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