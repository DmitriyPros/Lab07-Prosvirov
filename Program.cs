/*Задание 1.1
string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };

for (int i = days.Length - 1; i>= 0; i--)
{
    Console.WriteLine($"{i}: {days[i]}");
}

Задание 1.2 
double[] temps = { 14, 2, -3, -10, 5, 16, 20 };
string l = "";

foreach (int t in temps)
{
    l += t + " ";
}

Console.WriteLine(l);

Задание 2 
int[] prices = { 120, 45, 300, 80, 15, 210 };
int sum = 0;
int c = 0;

foreach (int p in prices)
{
    sum += p;
    if (p > 100)
    {
        c += 1;
    }
}

double average = (double)sum / prices.Length;

Console.WriteLine($"Общая сумма цен: {sum}, Средняя цена: {average}, Товаров дороже 100: {c}");

Задание 3
using System.Globalization;

int[] prices = { 120, 45, 300, 80, 15, 210 };
int min = prices[0];
int max = 0;
int c = 0;

for (int i = 1; i < prices.Length; i++)
{
    if (prices[i] < min)
    {
        min = prices[i];
    }
    if (prices[i] > max)
    {
        max = prices[i];
        c = i;
    }
}
Console.WriteLine($"Минимальная цена: {min}, Самый дорогой товар: {max}, его индекс: {c}");

Задание 4
using System.Security;

int[] balance = { 100, -50, 20, -5, 0, 75 };

for (int i = 0; i < balance.Length; i++)
{
    if (balance[i] < 0)
    {
        balance[i] = 0;
    }
}
foreach (int n in balance)
{
    Console.Write(n + " ");
}

Задание 5
using System.Globalization;

int[] numbers = new int[5];
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.WriteLine(numbers[i]);
}

int c = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        c += 1;
    }
}
Console.WriteLine($"Количество чётных чисел в массиве: {c}");

Задание 6
string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };
Console.Write("Введите имя: ");
string name = Console.ReadLine();
bool flag = false;

for (int i = 0; i < names.Length; i++)
{
    if (name == names[i])
    {
        Console.WriteLine($"Позиция введённого имени: {i}");
        flag = true;
        break;
    }
}

if (!flag)
{
    Console.WriteLine("Не найдено");
}

Итоговая задача. «Журнал оценок»
int[] grades = { 2, 3, 4, 4, 5, 5, 2, 3, 4, 5, 5 };
int min = grades[0];
int max = 0;
int c2 = 0;
int c5 = 0;

for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine($"{i}: {grades[i]}");
    if (grades[i] < min)
    {
        min = grades[i];
    }
    if (grades[i] > max)
    {
        max = grades[i];
    }
    if (grades[i] == 2)
    {
        c2 += 1;
    }
    if (grades[i] == 5)
    {
        c5 += 1;
    }
}
int sum = 0;

foreach (int g in grades)
{
    sum += g;
}

double average = (double)sum / grades.Length;
Console.WriteLine($"Средняя оценка: {average}");
Console.WriteLine($"Наибольшая оценка: {max}, Наименьшая оценка: {min}");
Console.WriteLine($"Количество двоек: {c2}, Количество пятёрок: {c5}");
if (average >= 4.5)
{
    Console.WriteLine("Отличник");
}
if (average >= 3.5)
{
    Console.WriteLine("Хорошист");
}
if (average < 3.5)
{
    Console.WriteLine("Есть над чем поработать");
}

Дополнительное задание ★★★
int[] arr = { 1, 2, 3, 4, 5, 6 };

for (int i = 0; i < arr.Length / 2; i++)
{
    int temp = arr[i];

    arr[i] = arr[5 - i];

    arr[5 - i] = temp;
}

string l = "";

foreach (int a in arr)
{
    l += a + " ";
}

Console.WriteLine(l);
*/