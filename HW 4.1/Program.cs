using System;

namespace HW_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Название первого человека:");
            string name1 = getName();
            Console.WriteLine("Возраст первого человека:");
            int age1 = getAge();

            Console.WriteLine("Название второго человека:");
            string name2 = getName();
            Console.WriteLine("Возраст второго человека:");
            int age2 = getAge();

            Console.WriteLine("Кто старше?");
            string elder = Convert.ToString(Console.ReadLine());

            while (age1 > age2)
            {
                if (name1 == elder)
                {
                    Console.WriteLine($"Вы правы, {name1} старше на {age1 - age2} года.");
                    break;
                }
                else
                {
                    Console.WriteLine("it is not right, who elder?");
                    elder = Convert.ToString(Console.ReadLine());

                }
            }

            while (age1 < age2)
            {
                if (name2 == elder)
                {
                    Console.WriteLine($"Вы правы, {name2} старше на {age2 - age1} года.");
                    break;
                }
                else
                {
                    Console.WriteLine("Не правильно, кто старше?");
                    elder = Convert.ToString(Console.ReadLine());

                }
            }

            if (age1 == age2)
            {
                Console.WriteLine("Не правильно, они ровестники.");
            }
        }

        static string getName()
        {
            string name = Convert.ToString(Console.ReadLine());
            return name;
        }

        static int getAge()
        {
            int age = Convert.ToInt32(Console.ReadLine());
            return age;
        }
    }
}
