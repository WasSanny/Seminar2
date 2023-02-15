// Программа, которая на вход принимает число и проверяет, кратно ли оно 7 и 23! ++++
// ++ добавляем цикл для первых пяти кратных чисел и считаем их сумму.! 

int index = 0;
int sum = 0;
int number = 5;

while (index < number)
{
  Console.WriteLine("Введите число: ");
  int.TryParse(Console.ReadLine(), out int a);
 
  if ((a % 7 == 0) && (a % 23 == 0))
  {
    Console.WriteLine("Число кратное и 7 и 23");
    sum = sum + a;
    index++;
  }
  else
  {
    Console.WriteLine("Число не кратное и 7 и 23");
  }
}
Console.WriteLine(sum);