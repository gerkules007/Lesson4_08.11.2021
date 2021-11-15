// Рассмотрим произвольное натуральное число, представим его всеми возможными способами в виде произведения 
// двух натуральных чисел и найдём для каждого такого произведения разность сомножителей. Например, для 
// числа 16 получим: 16 = 16*1 = 8*2 = 4*4, множество разностей содержит числа 15, 6 и 0. Найдите все 
// натуральные числа, принадлежащие отрезку [1 000 000; 2 000 000], у которых составленное описанным 
// способом множество разностей будет содержать не меньше трёх элементов, не превышающих 100. В ответе 
// перечислите найденные числа в порядке возрастания.

// int[] CreateIntArray(int minValue, int maxValue)
// {
//     int[] tempArr = new int[maxValue - minValue + 1];
//     for (int i = 0; i < tempArr.Length; i++) tempArr[i] = minValue++;
//     return tempArr;
// }

// int[] TakeRatioFor(int compareNumber)
// {
//     int count = 1;
//     int[] plusArr = new int[count];
//     int num = 1;
//     for (int i = 0; i < compareNumber; i++, num++)
//     {
//         if (compareNumber % (num) == 0)
//         {
//             Array.Resize(ref plusArr, count);
//             plusArr[count - 1] = num;
//             count++;
//         }
//     }
//     int max = plusArr.Length;
//     int[] diffArr = new int[max];
//     int index = 0;
//     for (int maxElement = plusArr[max - 1], needArgument; index < max; index++)
//     {
//         needArgument = maxElement / plusArr[index];
//         diffArr[index] = needArgument - plusArr[index];
//         if (diffArr[index] < 0) break;
//     }
//     Array.Resize(ref diffArr, index);
//     return diffArr;
// }

// int[] CompareArr(int[] inputArr2)
// {
//     Array.Reverse(inputArr2);
//     int lengthArr = inputArr2.Length / 4;
//     int[] takeArr = new int[lengthArr];
//     int ni = 0;
//     int count2 = 0;
//     for (; ni < lengthArr; ni++)
//     {
//         if (inputArr2[ni] < 100)
//         {
//             takeArr[ni] = inputArr2[ni];
//             count2++;
//         }
//     }
//     Array.Resize(ref takeArr, count2);
//     return takeArr;
// }

// void PrintArray(int[] inputArr)
// {
//     foreach (int input in inputArr) Console.Write($"{input} ");
// }

// int firstnumb = 1000000;
// int secondnumb = 2000000;
// // int secondnumb = 1001000;
// int[] newArr1 = CreateIntArray(firstnumb, secondnumb);
// for (int n = 0; n < newArr1.Length; n++)
// {
//     int[] x1 = CompareArr(TakeRatioFor(newArr1[n]));
//     if (x1.Length > 2 && x1[2] != 0 && x1[1] != 0) { Console.Write($"{newArr1[n]} "); PrintArray(x1); Console.WriteLine(); }
// }

void FindNumber(int fN, int sN)
{
    double sqrtN = 0;
    int count = 0;
    for (int i = fN; i < sN + 1; i++)
    {
        sqrtN = Math.Sqrt(i);
        for (int j = 1; j < sqrtN; j++)
        {
            if (i % j == 0)
            {
                if ((i / j) - j <= 100) count++;
            }
        }
        if (count > 2) Console.WriteLine(i);
        count = 0;
    }
}

int firstnumb = 1000000;
int secondnumb = 2000000;
FindNumber(firstnumb, secondnumb);




/*
int firstnumb = 1000000;
int secondnumb = 2000000;
int[] newArr1 = CreateIntArray(firstnumb, firstnumb*1/10 + firstnumb);
int[] newArr2 = CreateIntArray(firstnumb*1/10 + firstnumb + 1, firstnumb*2/10 + firstnumb);
int[] newArr3 = CreateIntArray(firstnumb*2/10 + firstnumb + 1, firstnumb*3/10 + firstnumb);
int[] newArr4 = CreateIntArray(firstnumb*3/10 + firstnumb + 1, firstnumb*4/10 + firstnumb);
int[] newArr5 = CreateIntArray(firstnumb*4/10 + firstnumb + 1, firstnumb*5/10 + firstnumb);
int[] newArr6 = CreateIntArray(firstnumb*5/10 + firstnumb + 1, firstnumb*6/10 + firstnumb);
int[] newArr7 = CreateIntArray(firstnumb*6/10 + firstnumb + 1, firstnumb*7/10 + firstnumb);
int[] newArr8 = CreateIntArray(firstnumb*7/10 + firstnumb + 1, firstnumb*8/10 + firstnumb);
int[] newArr9 = CreateIntArray(firstnumb*8/10 + firstnumb + 1, firstnumb*9/10 + firstnumb);
int[] newArr10 = CreateIntArray(firstnumb*9/10 + firstnumb + 1, secondnumb);
int[][] newArr = {newArr1, newArr2, newArr3, newArr4, newArr5, newArr6, newArr7, newArr8, newArr9, newArr10};
// int[] newArr = CreateIntArray(1000000, 1001000);
for (int n = 0; n < newArr[n].Length; n++)
{
    for (int j = 0; j < newArr.Length; j++) newArr[j] = CompareArr(TakeRatioFor(newArr[j][n]));
    // int[] x2 = CompareArr(TakeRatioFor(newArr2[n]));
    // int[] x3 = CompareArr(TakeRatioFor(newArr3[n]));
    // int[] x4 = CompareArr(TakeRatioFor(newArr4[n]));
    // int[] x5 = CompareArr(TakeRatioFor(newArr5[n]));
    // int[] x6 = CompareArr(TakeRatioFor(newArr6[n]));
    // int[] x7 = CompareArr(TakeRatioFor(newArr7[n]));
    // int[] x8 = CompareArr(TakeRatioFor(newArr8[n]));
    // int[] x9 = CompareArr(TakeRatioFor(newArr9[n]));
    // int[] x10 = CompareArr(TakeRatioFor(newArr10[n]));    
    for (int k = 0; k < newArr.Length; k++) if ( newArr[k][2] != 0 && newArr[k][1] != 0) {Console.Write($"{newArr[k][n]} "); PrintArray(newArr[k]); Console.WriteLine();}
    // if ( x2[2] != 0 && x2[1] != 0) {Console.Write($"{newArr2[n]} "); PrintArray(x2); Console.WriteLine();}
    // if ( x3[2] != 0 && x3[1] != 0) {Console.Write($"{newArr3[n]} "); PrintArray(x3); Console.WriteLine();}
    // if ( x4[2] != 0 && x4[1] != 0) {Console.Write($"{newArr4[n]} "); PrintArray(x4); Console.WriteLine();}
    // if ( x5[2] != 0 && x5[1] != 0) {Console.Write($"{newArr5[n]} "); PrintArray(x5); Console.WriteLine();}
    // if ( x6[2] != 0 && x6[1] != 0) {Console.Write($"{newArr6[n]} "); PrintArray(x6); Console.WriteLine();}
    // if ( x7[2] != 0 && x7[1] != 0) {Console.Write($"{newArr7[n]} "); PrintArray(x7); Console.WriteLine();}
    // if ( x8[2] != 0 && x8[1] != 0) {Console.Write($"{newArr8[n]} "); PrintArray(x8); Console.WriteLine();}
    // if ( x9[2] != 0 && x9[1] != 0) {Console.Write($"{newArr9[n]} "); PrintArray(x9); Console.WriteLine();}
    // if ( x10[2] != 0 && x10[1] != 0) {Console.Write($"{newArr10[n]} "); PrintArray(x10); Console.WriteLine();}
}
*/
// .TakeRatioFor(firstargument) - ищет делители и разность, убирает нули идущие после
// . - переворачивает массив и ищет все числа меньше ста
// - если чисел меньше ста не менее три, то выводит это число на печать