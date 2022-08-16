Console.WriteLine ("Ввведите координаты по X");
int x = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите координаты по Y");
int y = Convert.ToInt32 (Console.ReadLine());

if(x > 0 && y > 0)
{
    Console.WriteLine ("Точка находится в первой координатной четверти");
}
else if(x < 0 && y > 0)
{
    Console.WriteLine ("Точка находится вo второй координатной четверти");
}
else if(x < 0 && y < 0)
{
    Console.WriteLine ("Точка находится в третьей координатной четверти");
}
else if(x > 0 && y < 0)
{
    Console.WriteLine ("Точка находится в четвертой координатной четверти");
}
else 
{
    Console.WriteLine ("Точка не находится ни  в одной координатной четверти");
}