string ImportStringArrayToString(string place)
{
    string output = System.IO.File.ReadAllText(place);
    return output;
}

int CountMethod(string inputChar)
{
    int resCM;
    string compareChar = inputChar;
    switch (compareChar.ToUpper())
    {
        case "A":
            resCM = 2;
            break;
        case "B":
            resCM = 3;
            break;
        case "C":
            resCM = 5;
            break;
        default:
            resCM = 0;
            break;
    }
    return resCM;
}

string OverCountMethod(int kindofChar)
{
    string outputChar = string.Empty;
    switch (kindofChar)
    {
        case 2:
            outputChar = "A";
            break;
        case 3:
            outputChar = "B";
            break;
        case 5:
            outputChar = "C";
            break;
        default:
            Console.WriteLine("Error");
            break;
    }
    return outputChar;
}

(int max, int numberofChar) MaxCountCharFromCount(int chrCount, int[] rule)
{
    int numberofChar = 0;
    int max = 0;
    for (int i = 0; i < rule.Length; i++)
    {
        int count = 0;
        for (int ratio = chrCount; ratio % rule[i] == 0; count++) ratio = ratio / rule[i];
        if (max < count) { max = count; numberofChar = rule[i]; }
    }
    return (max, numberofChar);
}

string CountLetterInStringMethod(string inputString, char inputValue)
{
    // int countChar = 1;
    string resultChar = string.Empty;
    for (int i = 0; i < inputString.Length - 2; i++)
    {
        if (inputString[i] == inputString[i + 1] && inputString[i + 2] == inputValue) resultChar += $"{inputString[i + 2]}";
        // countChar *= CountMethod(resultChar);
    }
    return resultChar;
}

// string text = "CCCCBAABAABCCCC";
string directory = @"C:\Users\ovcse\Desktop\РАЗРАБОТЧИК\СЕМИНАРЫ\in CS\Lesson4\24.1.txt";
string text = ImportStringArrayToString(directory);
char[] cursymbols = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
// var countResult = MaxCountCharFromCount(CountLetterInStringMethod(text), cursymbols);
// string resultChar = OverCountMethod(countResult.numberofChar);
// Console.WriteLine($"Max char from {countResult.max} is {resultChar}");
int max = 0;
char numberofChar = ' ';
int countResult = 0;
foreach (char symbolChar in cursymbols)
{
    string result = CountLetterInStringMethod(text, symbolChar);
    countResult = result.Length;
    Console.WriteLine($"{Convert.ToString(symbolChar)} {countResult}");
    if (max < countResult) { max = countResult; numberofChar = symbolChar; }
}
Console.WriteLine($"Max {numberofChar} {max}");

