// Напишите программу, которая ищет среди целых чисел, принадлежащих числовому отрезку [210 235; 210 300], 
// числа, имеющие ровно четыре различных натуральных делителя, не считая единицы и самого числа. 
// Для каждого найденного числа запишите эти четыре делителя в четыре соседних столбца на экране с новой 
// строки. Делители в строке должны следовать в порядке возрастания.
// Например, в диапазоне [10; 16] ровно четыре различных натуральных делителя имеет число 12, 
// поэтому для этого диапазона вывод на экране должна содержать следующие значения:
// 2 3 4 6

int[] CreateIntArray(int minValue, int maxValue)
{
    int[] tempArr = new int[maxValue-minValue+1];
    for (int i = 0; i < tempArr.Length; i++) tempArr[i] = minValue++;
    return tempArr;
}

int[] TakeRatioFor(int compareNumber)
{
    int count = 1;
    int[] plusArr = new int[count];
    int num = 2;
    for(int i = 0; i < compareNumber; i++, num++)
    {
        if (compareNumber%(num) == 0) {Array.Resize(ref plusArr, count); plusArr[count-1] = num; count++;}
    }
    return plusArr;
}

void PrintArray(int[] inputArr)
{
    foreach (int input in inputArr) Console.Write($"{input} "); Console.WriteLine();
}
int[] newArr  = CreateIntArray(210235,210300);
// int[] newArr = CreateIntArray(10,16);
foreach (int numbArr in newArr) 
{
    int[] x = TakeRatioFor(numbArr);
    if (x.Length == 5) PrintArray(x);
}
// PrintArray(TakeRatioFor(newArr[0]));