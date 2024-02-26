// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
using System.Collections.Concurrent;

void FillRandomArray(int[] arr)
{
  Random rnd = new Random();
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.Next(100, 1000);
  }
}

int CheckCorrectLengthOfArray(string inputStr)
{
  int Length = new int();
  try
  {
    Length = Convert.ToInt32(inputStr);
  }
  catch
  {
    Length = -1;
    PrintInputError();
  }
  if (Length < 1)
  {
    PrintInputError();
  }
  return Length;
}

void PrintInputError()
{
  Console.WriteLine("Введён неверный формат данных!");
}

int InputLengthOfArray()
{
  int Length = new int();
  string inputStr = "";
  while (true)
  {
    Console.Write("Введите длинну массива (натуральное число): ");
    inputStr = Console.ReadLine();
    Length = CheckCorrectLengthOfArray(inputStr);
    if (Length > 1)
    {
      break;
    }
  }
  return Length;
}

int CheckEvenNumbersOfArray(int[] arr)
{
  int count = 0;
  foreach(var el in arr)
  { 
    if (el % 2 == 0)
    {
      count++;
    }
  }
  return count;
}

string ConvertArrayToString(int[] arr)
{
  string arrayStr = "";
  for(int i = 0; i < arr.Length; i++)
  {
    arrayStr += $"{arr[i]} ";
  }
  return arrayStr;
}

int Length = InputLengthOfArray();
int[] arr = new int[Length];
FillRandomArray(arr);
int count = CheckEvenNumbersOfArray(arr);
Console.WriteLine($"Массив: {ConvertArrayToString(arr)}");
Console.WriteLine($"Количество четных чисел в массиве: {count}");
