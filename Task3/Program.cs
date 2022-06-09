class Task3
{
    /* Задание 3
Имеется 3 переменные типа int x = 5, y = 10, и z = 15;
Выполните и рассчитайте результат следующих операций для этих переменных:
x += y >> x++ * z;
z = ++x & y * 5;
y /= x + 5 | z;
z = x++ & y * 5;
x = y << x++ ^ z; */

    static void Main()
    {
        {
            int x = 5;
            int y = 10;
            int z = 15;
            int a = x += y >> x++ * z;
            Console.WriteLine("Equation 1: " + a);
        }
        {
            int x = 5;
            int y = 10;
            int z = 15;
            int b = z = ++x & y * 5;
            Console.WriteLine("Equation 2: " + b);
        }
        {
            int x = 5;
            int y = 10;
            int z = 15;
            int c = y /= x + 5 | z;
            Console.WriteLine("Equation 3: " + c);
        }
        {
            int x = 5;
            int y = 10;
            int z = 15;
            int d = z = x++ & y * 5;
            Console.WriteLine("Equation 4: " + d);
        }
        {
            int x = 5;
            int y = 10;
            int z = 15;
            int e = x = y << x++ ^ z;
            Console.WriteLine("Equation 5: " + e);
        }
    }
}