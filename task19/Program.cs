Console.WriteLine ("Ввведите координаты по X1");
double x1 = Convert.ToDouble (Console.ReadLine());
Console.WriteLine ("Введите координаты по Y1");
double y1 = Convert.ToDouble (Console.ReadLine());
Console.WriteLine ("Ввведите координаты по X2");
double x2 = Convert.ToDouble (Console.ReadLine());
Console.WriteLine ("Введите координаты по Y2");
double y2 = Convert.ToDouble (Console.ReadLine());



double res = Math.Sqrt(Math.Pow (x1 - x2, 2) + Math.Pow (y1 - y2, 2));
Console.WriteLine ($"{res:f2}"); //f2 - значит 2 цифры после запятой (f для вещественных чисел)