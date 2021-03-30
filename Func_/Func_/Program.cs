using System;
using System.Text;

namespace Func_
{
    class Program
    {
        static int x;

        static int y;

        static int r;

        static int f;

        public static void Main(string[] args)
        {

            int k;

            Console.OutputEncoding = Encoding.UTF8;


        Nachalo:

            Console.WriteLine("1 = +");
            Console.WriteLine("2 = -");
            Console.WriteLine("3 = *");
            Console.WriteLine("4 = /");

            Console.Write("Вводите числа больше 1 и меньше 4: ");

            r = Convert.ToInt32(Console.ReadLine()); // vibor




            if (r > 0 && r < 5) // proverka
            {
                switch (r)
                {
                    case 1:
                        k = Plus();
                        break;

                    case 2:
                        k = Minus();
                        break;

                    case 3:
                        k = Umnojeniye();
                        break;

                    case 4:
                        k = Deleniye();
                        break;
                }
            }
            else if (r <= 1)
            {
                Console.WriteLine("нет");
            }
            else if (r >= 4)
            {
                Console.WriteLine("нет");
            }

            Console.Write("хотите продолжить?: ");
            Console.Write("\nесли да напиши - 1\n");
            Console.WriteLine("если нет напиши - 0");

            f = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (f == 1) // goto_label
            {
                goto Nachalo;
            }


        }

        static int Plus() // function_plus
        {

            Console.Write("введите первое значение:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("введите второе значение:");
            y = Convert.ToInt32(Console.ReadLine());


            int summa = x + y;



            Console.WriteLine("Ответ: " + summa);

            return summa;



        }

        static int Minus()
        {
            Console.Write("введите первое значение:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("введите второе значение:");
            y = Convert.ToInt32(Console.ReadLine());

            int otvet = x - y;

            Console.WriteLine("Ответ: " + otvet);
            return otvet;
        }

        static int Umnojeniye()
        {
            Console.Write("введите первое значение:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("введите второе значение:");
            y = Convert.ToInt32(Console.ReadLine());

            int otvet = x * y;

            Console.WriteLine("Ответ: " + otvet);
            return otvet;

        }

        static int Deleniye()
        {
            Console.Write("введите первое значение:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("введите второе значение:");
            y = Convert.ToInt32(Console.ReadLine());

            int otvet = x / y;

            Console.WriteLine("Ответ: " + otvet);

            return otvet;
        }
    }
}
