Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine());
if (A>B)
{ 
    Console.WriteLine($"{A} наибольшее значение");
}
else
{
   Console.WriteLine($"{B} наибольшее значение"); 
}