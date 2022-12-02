Console.WriteLine("Введите координату X: ");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y: ");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z: ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X2: ");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z2: ");
double z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)));