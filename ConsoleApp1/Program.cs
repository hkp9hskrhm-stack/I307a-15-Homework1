using ConsoleApp1;

Console.Write("Enter count of numbers: ");

int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

MyMath clsMath = new MyMath();
Console.WriteLine(clsMath.Sum(nums));
Console.WriteLine(clsMath.Count(nums));
Console.WriteLine(clsMath.Max(nums));
Console.WriteLine(clsMath.Min(nums));