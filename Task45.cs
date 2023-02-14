using System;
 
namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество чисел Фибоначчи: ");
            int n = int.Parse(Console.ReadLine());

            int a = 0;  // первое число Фибоначчи равно 0 
            int b = 1;  // второе число Фибоначчи равно 1

            Console.Write("{0} {1}", a, b);

            for (int i = 2; i < n; i++) // начиная с 3-го, каждый следующий элемент получаем, складывая 2 предыдущих: 0+1=1, 1+1=2, 1+2=3...  
            {  
                int c = a + b;   // c - 3-e, 4-e... N-oe элементы  

                Console.Write(" {0}", c);

                a = b;     // a - 2-e (1)  
                b = c;     // b - 3-e (2), 4-e (3)... N-oe (N)  
            }

            Console.WriteLine();

        }   
    }   
}
