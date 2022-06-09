class Task5
{
    /* Задание 5
Известно, что у чисел, которые являются степенью двойки, только один бит имеет значение 1.
Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, которая будет выполнять проверку – является ли указанное число степенью двойки или нет. */

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        int number;
        Console.WriteLine("Пожалуйста введите число: ");
        number = Convert.ToInt32(Console.ReadLine());
        if ((number & (number - 1)) == 0)
        {
            Console.WriteLine("Указанное число является степенью двойки");
        }
        else
        {
            Console.WriteLine("Указанное число не является степенью двойки");
        }
    }
}