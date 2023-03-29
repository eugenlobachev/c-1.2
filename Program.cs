//Задание 2
Console.WriteLine("Введите число один");
string OneNum = Console.ReadLine();
int One = Convert.ToInt32(OneNum);

Console.WriteLine("Введите число два");
string TwoNum = Console.ReadLine();
int Two = Convert.ToInt32(TwoNum);

if (One > Two) {
    Console.WriteLine($"Большее число равно: {One}");
}
else {
    Console.WriteLine($"Большее число равно: {Two}");
}

//Задание 4

Console.WriteLine("Введите первое число: ");
OneNum = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
TwoNum = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
ThreeNum = int.Parse(Console.ReadLine());

int max = OneNum

if (max < TwoNum)
{
    max = TwoNum;
}
if (max < ThreeNum)
{
    max = ThreeNum;
}

Console.WriteLine($"Максимальное число = {max} {OneNum} {TwoNum} {ThreeNum} ");


//Задание 6

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else 
{
    Console.WriteLine("Число нечетное");
}


//Задание 8

Console.Write("Введите N: ");
int numberN = int.Parse(Console.ReadLine());

int i = 1;
while (i <= numberN)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i}");
    }

    i++;

}
Console.WriteLine();