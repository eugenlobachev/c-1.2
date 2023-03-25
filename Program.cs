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