string[] input = System.IO.File.ReadAllLines(@"C:\Users\ovcse\Desktop\РАЗРАБОТЧИК\СЕМИНАРЫ\in CS\Lesson4\17.txt");
// double[] arr = File.ReadAllLines(@"C:\Users\ovcse\Desktop\РАЗРАБОТЧИК\СЕМИНАРЫ\in CS\Lesson4\17.txt").Select(i => double.Parse(i.Trim(),NumberFormatInfo.InvariantInfo )).ToArray();

int CountNumbers(double[] array1)
{
    int i = 0;
    int count = 0;
    for (; i < array1.Length-1; i++)
    {
        if ((array1[i] - array1[i+1]) % 60 == 0)
        {
            count++;
        }
    }
    return count;
}

double[] newarray = Array.ConvertAll(input, Double.Parse);
int result = CountNumbers(newarray);
Console.WriteLine(result);