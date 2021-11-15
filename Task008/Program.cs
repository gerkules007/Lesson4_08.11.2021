// Метод импорта данных
int[] ImportStringArrayToInt(string place)
{
    // Console.WriteLine("Укажите место импорта данных:");
    // string place = Console.ReadLine()!;
    // double[] arr = File.ReadAllLines(@"").Select(i => double.Parse(i)).ToArray();
    string[] input = System.IO.File.ReadAllLines(place);
    int[] newarray = Array.ConvertAll(input, Int32.Parse);
    return newarray;
}
// Метод сортировки от min к max
void MergeMethod(int[] numbers, int left, int mid, int right)
{
    int[] temp = new int[numbers.Length];
    int i, left_end, num_elements, tmp_pos;
    left_end = (mid - 1);
    tmp_pos = left;
    num_elements = (right - left + 1);
    while ((left <= left_end) && (mid <= right))
    {
        if (numbers[left] <= numbers[mid])
            temp[tmp_pos++] = numbers[left++];
        else
            temp[tmp_pos++] = numbers[mid++];
    }
    while (left <= left_end)
        temp[tmp_pos++] = numbers[left++];
    while (mid <= right)
        temp[tmp_pos++] = numbers[mid++];
    for (i = 0; i < num_elements; i++)
    {
        numbers[right] = temp[right];
        right--;
    }
}
void SortMethod(int[] numbers, int left, int right)
{
    int mid;
    if (right > left)
    {
        mid = (right + left) / 2;
        SortMethod(numbers, left, mid);
        SortMethod(numbers, (mid + 1), right);
        MergeMethod(numbers, left, (mid + 1), right);
    }
}

void MethodMerge(int[] numbers)
{
    int len = numbers.Length;
    // Console.WriteLine("Before Merge Sort:");
    // foreach (int item in numbers)
    // {
    //     Console.Write(item + " ");
    // }
    // Console.WriteLine();
    // Console.WriteLine("After Merge Sort");
    SortMethod(numbers, 0, len - 1);
    // foreach (int item in numbers)
    // {
    //     Console.Write(item + " ");
    // }
    Console.WriteLine("Done");
    Console.Read();
}

// void PrintArray(int[] inputArr)
// {
//     foreach (int input in inputArr) Console.Write($"{input} ");
// }

// Метод суммирования числа
(int i, int maxValue) SummMethod(int[] inputArr, int SummMax, int MaxSize)
{

    int i = 0, maxValue = 0;
    for (int SummFor = inputArr[i]; i < inputArr.Length; i++)
    {
        SummFor += inputArr[i];
        // Метод проверки максимального
        if (MaxSize - 1 == i || SummFor >= SummMax) { maxValue = inputArr[i]; break; }
    }
    i++;
    return (i, maxValue);
}
// PrintArray(currArr);
// Main, где будет проверятся каждое число
// int[] currArr = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
string directory = @"C:\Users\ovcse\Desktop\РАЗРАБОТЧИК\СЕМИНАРЫ\in CS\Lesson4\26.1.txt";
int[] currArr = ImportStringArrayToInt(directory);
MethodMerge(currArr);
//int max = 15, maxsz = 10;
int max = 99990, maxsz = 9999;
var result = SummMethod(currArr, max, maxsz);
Console.WriteLine($"Колич {result.i}  Максимальное число {result.maxValue}");


