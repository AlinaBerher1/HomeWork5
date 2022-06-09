class Task6
{
    /* Задание 6
Используя Visual Studio, создайте проект по шаблону Console Application.
Используя теорему Де Моргана, преобразуйте исходное выражение A | B, в эквивалентное выражение.*/

    static void Main()
    {
        bool A = true;
        bool B = false;

        if (!(!A & !B))
            Console.WriteLine($"!(!A & !B) = {!(!A & !B)}");
        else
            Console.WriteLine($"!(!A & !B) = {!(!A & !B)}");
    }
}