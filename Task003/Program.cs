// Первая задача
// int x, a, b;
// x = Convert.ToInt32(Console.ReadLine());
// a = 0;
// b = 0;
// while (x > 0)
// {
//     if (x % 2 == 0) a = a + 1;
//     else b = b + 1;
//     x = x / 10;
// }
// Console.WriteLine(a);
// Console.WriteLine(b);

// Вторая задача
// int x, a, b;
// x = Convert.ToInt32(Console.ReadLine());
// a = 0;
// b = 1;
// while (x > 0)
// {
//     if (x % 2 > 0) a += x % 12;
//     else b *= x % 12;
//     x = x / 12;
// }
// Console.WriteLine(a);
// Console.WriteLine(b);

// Рабочая программа для первой задачи
// int x, a, b;
// int i = 11;
// do
// {
//     x = i;
//     a = 0;
//     b = 0;
//     while (x > 0)
//     {
//         if (x % 2 == 0) a = a + 1;
//         else b = b + 1;
//         x = x / 10;
//     }
//     Console.WriteLine($"i = {i}");
//     ++i;
// } while (!(a == 3 && b == 2));

// вторая рабочая программа
// int x, a, b;
// int i = 11;
// do
// {
//     x = i;
//     a = 0;
//     b = 1;
//     while (x > 0)
//     {
//         if (x % 2 > 0) a += x%12;
//         else b *= x%12;
//         x = x / 12;
//     }
//     Console.WriteLine($"{i}");
//     ++i;
// } while (!(a == 3 && b == 12));