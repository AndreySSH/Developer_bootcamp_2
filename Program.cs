// using static ArrayCreator;
// using static ArrayMath;
using System.Diagnostics;


int[] array = 10_000.Create()
                .Fill(1, 10);

// array.ConvertToStringAndPrintToTerminal();

Stopwatch sw = new Stopwatch();
int m = 1_000;
int max;

sw.Start();
max = array.BadGetSum(m);
sw.Stop();
Console.WriteLine($"BadGetSum: {max} => {sw.ElapsedMilliseconds}");

sw.Reset();

sw.Start();
max = array.GoodGetSum(m);
sw.Stop();
Console.WriteLine($"GoodGetSum: {max} => {sw.ElapsedMilliseconds}");