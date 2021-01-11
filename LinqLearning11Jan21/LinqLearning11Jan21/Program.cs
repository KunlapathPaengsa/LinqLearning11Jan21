using System; 
using System.Linq;

namespace LinqLearning11Jan21
{
    class Program
    {
        static void Main(string[] args)
        {
            //EvenNum();
            //MoreThanFour();
            //MintoMax();
            //MaxtoMin();
            Filtering();
        }

        public static void EvenNum()
        {
            var numbers = new int[] {1,2,3,4,5,6,7,8};//data sourse all in collection from IEnumerable
            var evenNumbers = from it in numbers//Query
                              where it % 2 == 0
                              select it;
            var shortEven = numbers.Where(it => it % 2 == 0);//Short Quety
            
            foreach(int item in evenNumbers)//Query Execution
            {
                //Console.WriteLine(item);
                Console.WriteLine(item);
            }           
        }

        public static void MoreThanFour()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var MoreFore = numbers.Where(it => it > 4 );
            foreach (int item in MoreFore)
            {
                Console.WriteLine(item);
            }
        }

        public static void MintoMax()
        {
            var numbers = new int[] { 7, 5, 3, 1, 6, 2, 4 };
            for (int i = 0 ; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine("\nForm Min to Max");

            var min2max = numbers.OrderBy(it => it);
            foreach (int item in min2max)
            {
                Console.Write($"{item} ");
            }
        }

        public static void MaxtoMin()
        {
            var numbers = new int[] { 7, 5, 3, 1, 6, 2, 4 };
            for(int i = 0 ; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine("\nForm Max to Min");

            var max2min = numbers.OrderByDescending(it => it);
            foreach( int item in max2min)
            {
                Console.Write($"{item} ");
            }
        }

        public static void Filtering()
        {
            var numbers = Enumerable.Range(1, 100);
            var qry = numbers.Where(it => it % 5 == 0 && it % 7 == 0); /*.Where(it => it % 5 == 0)
                .Where(it => it % 7 == 0);*/
            foreach (int qqq in qry)
            {
                Console.WriteLine(qqq);
            }
            



        

        }
        

    }

    public class DataElon
    {
        public int Elon { get; set;}
    }

}
