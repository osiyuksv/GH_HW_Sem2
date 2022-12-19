// вывести случайно выведенное трёхзначного число без средней цифры


int number = new Random().Next(100, 1000); // указываем правое число +1 от заданного диапазона
Console.WriteLine(number);

int num1 = number / 100;
int num2 = number % 100 / 10;
int num3 = number % 10;

Console.Write(num1);
Console.Write(num3);
