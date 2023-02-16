// // Программа, которая принимает на вход два числа и проверяет,
// // является ли одно из них квадратом другого.

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

  if (Math.Abs(a) == Math.Sqrt(b) || Math.Abs(b) == Math.Sqrt(a))
  {
    Console.WriteLine("Да!");
  }
  else
  {
    Console.WriteLine("Нет!"); 
  }



// Вывести в консоль квадрат из звездочек

// Console.WriteLine(@"* * * * *");
// Console.WriteLine(@"*       *");
// Console.WriteLine(@"*       *");
// Console.WriteLine(@"*       *");
// Console.WriteLine(@"* * * * *");
