// Задача 19. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double DistanceBetweenPoints(double X1, double X2, double Y1, double Y2, double Z1, double Z2)
{
    double distance = 0;
    {
        distance = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2) + Math.Pow((Z2 - Z1), 2));
        Console.WriteLine(distance);
    }
    return distance;
}
Console.Write("Введите координату X1 ");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X2 ");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y1 ");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y2 ");
double Y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z1 ");
double Z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z2 ");
double Z2 = Convert.ToDouble(Console.ReadLine());
double distance = DistanceBetweenPoints(X1,X2,Y1,Y2,Z1,Z2);