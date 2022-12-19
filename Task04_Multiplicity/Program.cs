// проверяем кратность 7 и 23 
// одновременно для введённого числа (да / нет)

int num1= new Random().Next(100, 10000); // указываем правое число +1 от заданного диапазона
Console.WriteLine(num1);

if((num1 % 23 == 0) && (num1 % 7 == 0))
{
  Console.WriteLine("да");
}
else
{
       Console.Write("нет");
}

