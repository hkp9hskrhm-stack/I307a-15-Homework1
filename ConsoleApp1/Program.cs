using ConsoleApp1;

var gui = new GuiConsoleApp();
var clsMath = new MyMath();

double[] nums = { };
nums = gui.GetArray(nums);

Console.WriteLine(clsMath.Sum(nums));
Console.WriteLine(clsMath.Count(nums));
Console.WriteLine(clsMath.Max(nums));
Console.WriteLine(clsMath.Min(nums));
