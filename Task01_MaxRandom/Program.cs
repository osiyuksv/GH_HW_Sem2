// вывести большую цифру из двухзначного числа [10, 99]

int number = new Random().Next(10, 100); // указываем правое число +1 от заданного диапазона
Console.WriteLine(number);

int num1 = number / 10;
int num2 = number % 10;

if(num1 > num2)
{
  Console.WriteLine(num1);
}
else
{
   Console.WriteLine(num2);
}

