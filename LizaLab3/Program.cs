using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizaLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //создадим счетчик c данными по умолчанию
            Counter counter = new Counter();

            //Демонстрируем вывод текущего состояния счетчика
            Console.WriteLine(counter.Current);

            //Мы можем получить range и пользоваться его методами для реализации счетчика
            Range range = counter.GetRange;
          
            while(range.inRange(counter.Current +1))
            {
                counter.Increment();
                Console.WriteLine(counter.Current);
            }
            Console.WriteLine();



            //Создадим счетчик со своими данными

            //демонстрируем объявление диапазона, по умолчанию значения {0, 15}, но мы передадим значения в перегрузку
            Range range1 = new Range(10, 30);

            //создадим счетчик со своими данными
            Counter counter1 = new Counter(10, range1);
            while (range1.inRange(counter1.Current + 1))
            {
                counter1.Increment();
                Console.WriteLine(counter1.Current);
            }

            Console.WriteLine();
            //затем покажем уменьшение
            while (range1.inRange(counter1.Current - 1))
            {
                counter1.Decrement();
                Console.WriteLine(counter1.Current);
            }

            //раскомментируйте этот код, чтобы посмотреть, как вывыодятся исключения при выходе за диапазон!

            /*
            for(int i = 0; i < 100; i++)
            {
          
                counter1.Increment();
                Console.WriteLine(counter1.Current);
            }
            */

            //раскомментируйте этот код, чтобы посмотреть, что мы не можем передать значение, выходящее за диапазон!

            /*
            Range range2 = new Range(0, 10);
            Counter counter2 = new Counter(15, range2);
            */

            Console.ReadLine();



        }
    }
}
