// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Text;

const int Count = 100_000;

string result = string.Empty;

Stopwatch stopwatch = Stopwatch.StartNew();
for (int i = 0; i < Count; i++)
{
    result += 'a';
}

stopwatch.Stop();
Console.WriteLine($"The elapsed time with string appending is {stopwatch.Elapsed}");

StringBuilder sb = new StringBuilder(Count);

stopwatch.Restart();
for (int i = 0; i < Count; i++)
{
    sb.Append('a');
}
stopwatch.Stop();

Console.WriteLine($"The elapsed time with string builder is {stopwatch.Elapsed}");
Console.WriteLine("Wow! This is fast!");
