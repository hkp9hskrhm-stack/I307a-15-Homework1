using Math = ConsoleApp1.Math;

Console.WriteLine("Hello, World!");

int[] nums = [8, 5, 6, 7, 1, 9];

Math clsMath = new Math();
Console.WriteLine(clsMath.Sum(nums));
Console.WriteLine(clsMath.Count(nums));
Console.WriteLine(clsMath.Max(nums));
Console.WriteLine(clsMath.Min(nums));
