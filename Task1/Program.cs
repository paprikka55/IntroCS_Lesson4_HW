// Задача 1: Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.

bool CheckQuitString(string inputStr)
{
  bool quit = false;
  bool convert_ok = true;
  int num = new int();
  if (inputStr.ToLower() == "q")
  {
    quit = true;
    convert_ok = false;
  }
  else
  {
    try
    { num = Convert.ToInt32(inputStr); }
    catch
    {
      quit = false;
      convert_ok = false;
      PrintInputErr(inputStr);
    }
    if (convert_ok == true)
    {
      if (CheckParityForSumOfDigits(num) == true)
        quit = true;
      else
        quit = false;
    }
  }
  return quit;
}

bool CheckParityForSumOfDigits(int number)
{
  bool parity = false;
  int sum = 0;
  while (number > 0)
  {
    sum += number % 10;
    number /= 10;
  }
  if (sum % 2 == 0)
  { parity = true; }
  return parity;
}

void PrintInputErr(string InputStr)
{
  Console.WriteLine($"Вы ввели неверные данные: {InputStr}.");
}

void SayByeBye()
{
  Console.Write("Для выхода нажмите Enter...");
  Console.ReadLine();
}

while(true)
{
  string inputStr;
  Console.WriteLine("!!Для выхода из программы наберите символ q или число, сумма цифр которого будет четной!!");
  Console.Write("Введите целое число: ");
  inputStr = Console.ReadLine();
  if (CheckQuitString(inputStr) == true)
  { 
    SayByeBye(); 
    break;
  }
  
}