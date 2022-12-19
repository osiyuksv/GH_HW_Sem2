// выводим является ли одно двухзначное 
// число квадратом другого

int num1= new Random().Next(1, 100); // указываем правое число +1 от заданного диапазона
Console.WriteLine(num1);
int num2= new Random().Next(1, 100); // указываем правое число +1 от заданного диапазона
Console.WriteLine(num2);

if((num1 == num2 * num2) || (num2 == num1 * num1))
{
  Console.WriteLine("да");
}
else
{
       Console.Write("нет");
}