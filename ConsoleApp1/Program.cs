using Math = ConsoleApp1.Math;

Console.Write("Enter count of numbers: ");

int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

Math clsMath = new Math();
Console.WriteLine(clsMath.Sum(nums));
Console.WriteLine(clsMath.Count(nums));
Console.WriteLine(clsMath.Max(nums));
Console.WriteLine(clsMath.Min(nums));