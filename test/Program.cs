string[] M;
Console.WriteLine("Введите массив строк через пробел");
string text = Console.ReadLine();
M = text.Split(" ");
var result = new string[M.Length];
var realSize = 0;
foreach (var value in M)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}
Console.WriteLine(string.Join(" " , result));