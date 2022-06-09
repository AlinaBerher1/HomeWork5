class Task4
{
    /* Задание 4
Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу расчета начисления премий сотрудникам.
Премии рассчитываются согласно выслуге лет.
Если выслуга до 5 лет, премия составляет 10% от заработной платы.
Если выслуга от 5 лет (включительно) до 10 лет, премия составляет 15% от заработной платы.
Если выслуга от 10 лет (включительно) до 15 лет, премия составляет 25% от заработной платы.
Если выслуга от 15 лет (включительно) до 20 лет, премия составляет 35% от заработной платы.
Если выслуга от 20 лет (включительно) до 25 лет, премия составляет 45% от заработной платы.
Если выслуга от 25 лет (включительно) и более, премия составляет 50% от заработной платы.
Результаты расчета, выведите на экран. */

    static void Main()
    {
        double bonus = 0;
        Console.WriteLine("Please enter work experience: ");
        double experience = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter salary amount: ");
        double salary = Convert.ToDouble(Console.ReadLine());
        if (experience <= 0)
        {
            Console.WriteLine("Incorrect experience input");
        }
        else if (salary <= 0)
        {
            Console.WriteLine("Incorrect salary input");
        }
        else
        {
            if (experience < 5)
            {
                bonus = salary * 0.1;
                Console.WriteLine("Bonus is " + bonus);
            }
            else if (experience >= 5 && experience < 10)
            {
                bonus = salary * 0.15;
                Console.WriteLine("Bonus is " + bonus);
            }
            else if (experience >= 10 && experience < 15)
            {
                bonus = salary * 0.25;
                Console.WriteLine("Bonus is " + bonus);
            }
            else if (experience >= 15 && experience < 20)
            {
                bonus = salary * 0.35;
                Console.WriteLine("Bonus is " + bonus);
            }
            else if (experience >= 20 && experience < 25)
            {
                bonus = salary * 0.45;
                Console.WriteLine("Bonus is " + bonus);
            }
            else if (experience >= 25)
            {
                bonus = salary * 0.5;
                Console.WriteLine("Bonus is " + bonus);
            }
        }
    }
}
