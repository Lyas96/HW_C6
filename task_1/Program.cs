/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */



Console.Clear();
Console.Write("Введите числа через пробел: ");
string[] StrNumbs = Console.ReadLine().Split(" ");

int[] numbers = StrToInt(StrNumbs);
Console.WriteLine($"Количество чисел > 0 равно; {PositiveNumbers(numbers)}");


int[] StrToInt(string[] array)
{
  int[] res = new int[array.Length];
  for (int i = 0; i < array.Length; i++)
  {
    res[i] = int.Parse(array[i]);
  }
  return res;
}

int PositiveNumbers(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0) count += 1;
  }
  return count;
}
