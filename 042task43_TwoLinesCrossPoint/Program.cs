/*Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1; k1; b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 0,15)
*/
Console.WriteLine("Введите значение параметра b1 координаты первой прямой: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение параметра k1 координаты первой прямой: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение параметра b2 координаты второй прямой: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение параметра k2 координаты второй прямой: ");
double k2 = Convert.ToInt32(Console.ReadLine());
//x=(y-b1)/k1; y=(b2k1-b1k2)/k1-k2;
//x*k1=y-b1; x*k1=((b2*k1-b1*k2)/(k1-k2))-b1;
//(x*k1)*(k1-k2)=b2*K1-b1*k1
             
double x = (b2 - b1) / (k1 - k2); 
double y = k1 * x + b1;   
Console.WriteLine($"Прямые пересекеутся в точке ({Math.Round(x,2)};{Math.Round(y,2)})");
                                   