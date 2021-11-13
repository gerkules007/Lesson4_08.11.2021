// int CountLetterInIntMethod(string inputString, char inputValue)
// {
//     int resultChar = 0;
//     for (int i = 0; i < inputString.Length - 1; i++)
//     {
//         int countChar = 0;
//         while (inputString[i] != inputValue && inputString[i] == inputString[i + 1]) {countChar++; i++;}
//         if (resultChar < countChar) resultChar = countChar;
//     }
//     return resultChar;
// }

int CountLetterInIntMethod(string inputString, char inputValue)
{
    int resultChar = 0;
    int countChar;
    for (int i = 0; i < inputString.Length; i++)
    {
        if (inputString[i] == inputValue)
        {
            countChar = 0;
            while ( i < inputString.Length && inputString[i] == inputValue) {countChar++;i++;}
            if (resultChar < countChar) resultChar = countChar;
        }
    }
    return resultChar;
}



string ImportStringArrayToString(string place)
{
    string output = System.IO.File.ReadAllText(place);
    return output;
}

// string text = "CCCCBAACCCCCBAABCCC";
string directory = @"C:\Users\ovcse\Desktop\РАЗРАБОТЧИК\СЕМИНАРЫ\in CS\Lesson4\24.2.txt";
string text = ImportStringArrayToString(directory);
char[] cursymbols = { 'C' };
int result = CountLetterInIntMethod(text, cursymbols[0]);
Console.WriteLine($"{Convert.ToString(cursymbols[0])} {result}");