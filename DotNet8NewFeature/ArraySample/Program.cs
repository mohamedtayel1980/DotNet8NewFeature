using System.Collections;

int[] ar1 = [1, 2, 3];
int[] ar2 = [4, 5, 6];
int[] ar3 = [7, 8, 9];
int[] bigArr1 = [.. ar1, .. ar2, .. ar3];

Console.WriteLine("bigArr1");
foreach (var item in bigArr1)
{
    Console.WriteLine(item.ToString());
}
Console.WriteLine("bigArr1");
int[] bigArr2 = [.. ar1, 20, .. ar2, .. ar3];
Console.WriteLine("bigArr2");
foreach (var item in bigArr2)
{
    Console.WriteLine(item.ToString());
}
Console.WriteLine("bigArr2");