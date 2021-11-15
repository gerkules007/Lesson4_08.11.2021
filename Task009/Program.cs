// Метод суммирования чисел и сравнение условий
// Сумма чисел должна делиться на 120
// первое число не должно быть дальше в ряду от первого
// первое число должно быть больше второго
// найти нужно максимальную сумму двух элементов.
int[] ImportStringArrayToInt(string place)
{
    // Console.WriteLine("Укажите место импорта данных:");
    // string place = Console.ReadLine()!;
    // double[] arr = File.ReadAllLines(@"").Select(i => double.Parse(i)).ToArray();
    string[] input = System.IO.File.ReadAllLines(place);
    int[] newarray = Array.ConvertAll(input, Int32.Parse);
    return newarray;
}

int[] SummAndCompare(int[] inputArr)
{
    // Двигаемся от первого числа к n, от второго числа к n и т.д
    int max = 0, summ = 0, index = 0;
    int[] findNumber = { 0, 0, 0};
    for (int i = 0, leng = inputArr.Length; i < leng; i++)
    {
        for (int j = i + 1; j < leng; j++)
        {
            // Сумма чисел должна делиться на 120 // первое число должно быть больше второго
            summ = inputArr[i] + inputArr[j];
            if (inputArr[i] > inputArr[j] && summ % 120 == 0 && summ > max)
            {
                max = summ;
                findNumber[findNumber.Length - 3] = inputArr[i];
                findNumber[findNumber.Length - 2] = inputArr[j];
                findNumber[findNumber.Length - 1] = max;
                PrintArray(findNumber);
                Console.WriteLine();
            }
        }
    }
    return findNumber;
}

void PrintArray(int[] inputArr)
{
    foreach (int input in inputArr) Console.Write($"{input} ");
}

// int[] currArr = { 60, 140, 61, 100, 300, 59 };
string directory1 = @"C:\Users\ovcse\Desktop\РАЗРАБОТЧИК\СЕМИНАРЫ\in CS\Lesson4\28131_A.txt";
string directory2 = @"C:\Users\ovcse\Desktop\РАЗРАБОТЧИК\СЕМИНАРЫ\in CS\Lesson4\28131_B.txt";
int[] currArr1 = ImportStringArrayToInt(directory1);
int[] newArr1 = SummAndCompare(currArr1);
PrintArray(newArr1);
Console.ReadKey();
Console.WriteLine();
int[] currArr2 = ImportStringArrayToInt(directory2);
int[] newArr2 = SummAndCompare(currArr2);