//Напишите программу, которая принимает на входе координаты двух точек и
//находит расстояние между ними в 3D пространстве.
//A(3,6,8); B(2,1,-7)->15,84
//A(7,-5,0); B(1,-1,9)->11,53
//            y
//            |  z
//            | /  
//          __|/_______x
//            0

Console.WriteLine("Введите x-координаты точки A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y-координаты точки A: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z-координаты точки A: ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x-координаты точки B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y-координаты точки B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z-координаты точки B: ");
int zB = Convert.ToInt32(Console.ReadLine());
double result = Math.Sqrt(((xA-xB)*(xA-xB)) + ((yA-yB)*(yA-yB)) + ((zA-zB)*(zA-zB)));
Console.WriteLine(Math.Round(result,2));