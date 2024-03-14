// Console.WriteLine("Number 1:");
// var str1 = Console.ReadLine();
// Console.WriteLine("Number 2:");
// var str2 = Console.ReadLine();

// if (str1 != null && str2 != null)
// {
//     var n1 = int.Parse(str1);
//     var n2 = int.Parse(str2);
//     Console.WriteLine(n1 + n2);
// }
// else
// {
//     Console.WriteLine("No dice!");
// }

Console.WriteLine("Enter expression:");
var exp = Console.ReadLine();
string[] elements = exp.Split(' ');

if (exp.Contains(' '))
{
    for (int i = 0; i < elements.Length; i++)
    {

        Console.WriteLine(elements[i]);
    }
}
