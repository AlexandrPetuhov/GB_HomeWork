//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1) Console.WriteLine("День недели - понедельник, это не выходной день");
if (number == 2) Console.WriteLine("День недели - вторник, это не выходной день");
if (number == 3) Console.WriteLine("День недели - среда, это не выходной день");
if (number == 4) Console.WriteLine("День недели - четверг, это не выходной день");
if (number == 5) Console.WriteLine("День недели - пятница, это не выходной день");
if (number == 6) Console.WriteLine("День недели - суббота, это выходной день");
if (number == 7) Console.WriteLine("День недели - воскресенье, это выходной день");