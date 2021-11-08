// В файле содержится последовательность из 10 000 целых положительных чисел. Каждое число не превышает 10 000.
// Определите и запишите в ответе сначала количество пар элементов последовательности, у которых разность элементов кратна 60, 
// затем максимальную из разностей элементов таких пар. В данной задаче под парой подразумевается два различных элемента 
// последовательности. Порядок элементов в паре не важен.

string[] input = System.IO.File.ReadAllLines(@"C:\Users\ovcse\Desktop\РАЗРАБОТЧИК\СЕМИНАРЫ\in CS\Lesson4\17.txt");
// double[] arr = File.ReadAllLines(@"C:\Users\ovcse\Desktop\РАЗРАБОТЧИК\СЕМИНАРЫ\in CS\Lesson4\17.txt").Select(i => double.Parse(i.Trim(),NumberFormatInfo.InvariantInfo )).ToArray();

int CountNumbers(int[] array1)
{
    int i = 0;
    int count = 0;
    int a = array1[i];
    int b = array1[i + 1];
    for (i = 0; i < array1.Length; i++)
    {
        a = array1[i];
        for (int j = i + 1; j < array1.Length; j++)
        {
            if ((a - array1[j]) % 60 == 0)
            {
                count++;
            }
        }
    }
    return count;
}

int[] newarray = Array.ConvertAll(input, Int32.Parse);
int result = CountNumbers(newarray);
Console.WriteLine(result);