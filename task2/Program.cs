// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int getInt()
{
return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите координаты А и В:");
int x1 = getInt();
int y1 = getInt();
int z1 = getInt();
int x2 = getInt();
int y2 = getInt();
int z2 = getInt();
double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine(d);