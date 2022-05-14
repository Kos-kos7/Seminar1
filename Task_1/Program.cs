// Принимает 2 числа и проверяет является ли одно квадратом другого
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int numResult = a * a;

Console.WriteLine(numResult);

if(numResult == b) Console.WriteLine("Число b является квадратом числа a");
elseConsole.WriteLine("Число b не является квадратом числа a");
