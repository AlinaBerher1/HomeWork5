class Task2
{
    /* Задание 2
Известно, что у четных чисел младший бит имеет значение 0.
Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу, которая будет выполнять проверку чисел на четность.
Предложите два варианта решения поставленной задачи.  */

    static void Main()
    {
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            int number;
            do
            {
                Console.WriteLine("Пожалуйста введите число: ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine("Число {0} четное", number);
                }
                else
                {
                    Console.WriteLine("Число {0} нечетное", number);
                }
            }
            while (true);
        }
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            int number1;
            Console.WriteLine("Пожалуйста введите число: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            if ((number1 & 1) != 1)
            {
                Console.WriteLine("Число {0} четное", number1);
            }
            else
            {
                Console.WriteLine("Число {0} нечетное", number1);
            }
        }
    }
}