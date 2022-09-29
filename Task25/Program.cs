//№25 Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.   
//3, 5 -> 243 (3⁵)  2, 4 -> 16 
//* Написать калькулятор с операциями +, -, /, * и возведение в степень 

int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine()??"0");
    return number;
}
void PrintData(string msg, int value)
{
    Console.WriteLine(msg + value);
}
int PowMathAoB( int A, int B)
{
    int res = Convert.ToInt32(Math.Pow(A, B));
    return res;
}

int nuumA = ReadData("Введите число А: ");
int nuumB = ReadData("Введите число B: ");
PrintData("Число А в степени В = ", PowMathAoB(nuumA, nuumB));



