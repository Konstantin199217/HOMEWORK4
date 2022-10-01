// №29 Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран. 

// void FillArray(int[] collection)
// {
//     int Length = collection.Length;
//     int index = 0;
//     while (index < Length)
//     {
//         collection[index] = new Random().Next(1, 100);
//         index++;
//     }
// }
// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write(col[position] + ", ");
//         position++;
//     }
// }

// Console.WriteLine("Массив из 8 элементов: ");

// int [] array = new int[8];
// FillArray(array);
// PrintArray(array);

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

int n = ReadData("Введите размер массива: ");
int m = ReadData("Введите диапазон от 1 до ");
void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, m);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + ", ");
        position++;
    }
}
int [] array = new int[n];

FillArray(array);
PrintArray(array);
