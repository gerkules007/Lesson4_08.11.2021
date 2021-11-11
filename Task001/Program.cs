// В файле содержится последовательность из 10 000 целых положительных чисел. Каждое число не превышает 10 000.
// Определите и запишите в ответе сначала количество пар элементов последовательности, у которых разность элементов кратна 60, 
// затем максимальную из разностей элементов таких пар. В данной задаче под парой подразумевается два различных элемента 
// последовательности. Порядок элементов в паре не важен.

int[] ImportStringArrayToInt(string place)
{
    // Console.WriteLine("Укажите место импорта данных:");
    // string place = Console.ReadLine()!;
    // double[] arr = File.ReadAllLines(@"").Select(i => double.Parse(i)).ToArray();
    string[] input = System.IO.File.ReadAllLines(place);
    int[] newarray = Array.ConvertAll(input, Int32.Parse);
    return newarray;
}

int[] CountNumbers(int[] array1)
{
    int i = 0;
    int count = 0;
    int max = 0;
    for (i = 0; i < array1.Length - 1; i++)
    {
        //a = array1[i];
        for (int j = i + 1; j < array1.Length; j++)
        {
            if (((array1[i] * array1[j]) % 26 == 0))
            {
                count++;
                if ((array1[i] + array1[j]) > max)
                {
                    max = array1[i] + array1[j];
                }
            }
        }
    }
    int[] arr = {count, max};
    return (arr);
}

string directory = @"C:\Users\ovcse\Desktop\РАЗРАБОТЧИК\СЕМИНАРЫ\in CS\Lesson4\17.1.txt";
int[] newarray = ImportStringArrayToInt(directory);
int[] result = CountNumbers(newarray);
Console.WriteLine($"Про элементов кратна 26 = {result[0]} и максимальную из сумм элементов таких пар = {result[1]}");