// вывести среди двух рандомных чисел
// кратность певрого числа второму или нет с отстатком

int num1= new Random().Next(1, 100); // указываем правое число +1 от заданного диапазона
Console.WriteLine(num1);

int num2= new Random().Next(1, 100); // указываем правое число +1 от заданного диапазона
Console.WriteLine(num2);

if(num1 % num2 == 0)
{
  Console.WriteLine("кратно");
}
else
{
    Console.Write("не кратно, остаток ");
    Console.Write(num1 % num2);
}

