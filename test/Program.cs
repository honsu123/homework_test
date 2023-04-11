string[] M;
Console.WriteLine("Введите массив строк через пробел");
string text = Console.ReadLine();
M = text.Split(" ");
int filter = 3;
var result = new string[M.Length];
var realSize = 0;
foreach (var value in M)
{
    if (value.Length <= filter)
    {
        result[realSize] = value;
        realSize++;
    }
}
Console.WriteLine(string.Join(" " , result));