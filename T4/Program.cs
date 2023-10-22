Console.Write("Введите число- ");
int num = int.Parse(Console.ReadLine());
int s = 2;
while (num >= s)
{
    Console.Write(s + " ");
    s = s + 2;
}