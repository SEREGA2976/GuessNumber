using System;

using System.Text;

/// <summary>
/// Данная программа реализует игру угадай число
/// </summary>
namespace guessnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(866);
            Console.InputEncoding = Encoding.GetEncoding(866);
            char again = 'y';
            Random rand = new Random();
            while (again == 'y')
            {
                int i = rand.Next(50);
                Console.WriteLine("Компьютер загадал число от 0 до 49");
                if (i < 25)
                    Console.WriteLine("Число меньше 25");
                else Console.WriteLine("Число больше или равно 25");
                int x = Convert.ToInt32(Console.ReadLine());
                if (i == x) Console.WriteLine("Вы угадали число!");
                else Console.WriteLine("К сожалению вы неугадали число! Компьютер загадал число {0}", i);
                Console.WriteLine("Вы хотите попробовать еще?(y = Да, n = Нет)");
                again = Convert.ToChar(Console.ReadLine());

            }
        }   
    }
}
