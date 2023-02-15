// Программа, которая на вход будет принимать 2 числа и выводить, является ли второе число кратным первому, а если нет, то выводить остаток!

Console.WriteLine("Введите первое число: ");
int.TryParse(Console.ReadLine(), out int first);
Console.WriteLine("Введите первое число: ");
int.TryParse(Console.ReadLine(), out int second);

if (first > second)
{
  int compare = first % second;
  if (compare == 0) Console.WriteLine($"Число {first} кратно {second}");
  else Console.WriteLine($"Остаток от деления = {compare}");
}
// else if (first == 0) ///////////////////// подробности деления на нольбудут укзаны далее!!!!!!
// {
//   int compare = first % second;
//   if (compare == 0) Console.WriteLine($"Число {first} кратно {second}");
//   else Console.WriteLine($"Остаток от деления = {compare}");
// }
// else if (second == 0)
// {
//   int compare = second  % first;
//   if (compare == 0) Console.WriteLine($"Число {second } кратно {first}");
//   else Console.WriteLine($"Остаток от деления = {compare}");
// }
else
{
  int compare = second  % first;
  if (compare == 0) Console.WriteLine($"Число {second } кратно {first}");
  else Console.WriteLine($"Остаток от деления = {compare}");
}
