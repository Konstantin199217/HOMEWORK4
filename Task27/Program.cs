// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.  
// 452 -> 11  82 -> 10  9012 -> 12 
// * Сделать оценку времени алгоритма через вещественные числа и строки 

int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
void PrintData(string msg, int value)
{
    Console.WriteLine(msg + value);
}

int SumNumbers(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}

int numA = ReadData("Введите число: ");
PrintData("Сумма всех цифр числа " + numA + " = ", SumNumbers(numA));
