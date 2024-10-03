Console.WriteLine("eded daxil et");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = 0;
for (int i = 2; i <= num; i *= 2)
{
    if (i == num)
    {
        num2 = num / i;
    }
}
if (num2 != 0)
{
    Console.WriteLine("quvvetdir");
}
else
{
    Console.WriteLine("deyil");
}

