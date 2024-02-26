// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

void FillRandomArray(int[] arr)
{
  Random rnd = new Random();
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.Next(-100, 101);
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

void ReverseArray(int[] arr)
{
  int temp = new int();
  for(int i = 0; i < arr.Length / 2; i++)
  {
    temp = arr[i];
    arr[i] = arr[arr.Length - i - 1];
    arr[arr.Length - i -1] = temp;
  }
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
Console.WriteLine($"Массив: {ConvertArrayToString(arr)}");
ReverseArray(arr);
Console.WriteLine($"Перевернутый массив: {ConvertArrayToString(arr)}");