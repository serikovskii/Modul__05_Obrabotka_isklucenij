using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkTryCatch
{
    public class Program
    {
        static public int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }
        public static void Exeption(int numOne, int numTwo)
        {
            try
            {
                Divide(numOne, numTwo);
                if (numOne == null)
                {
                    throw new ArgumentNullException("numOne");
                }
                
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("нет значении");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("деление на ноль");
            }
            
            
        }
            
        static void Main(string[] args)
        {
            // 1
            int numOne;
            int numTwo;
            Console.WriteLine("Введите 2 числа");
            int.TryParse(Console.ReadLine(), out numOne);
            int.TryParse(Console.ReadLine(), out numTwo);
            Exeption(numOne, numTwo);
            
            Console.ReadLine();
            
            // 2
            int size = 5;
            int sizeLong = 7;
            int[] array = new int[size];
            try
            {
                for (int i = 0; i < sizeLong; i++)
                {
                    array[i] = i + 2;
                }
                throw new IndexOutOfRangeException { };
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("оп! ошибка");
            }
            finally
            {
                Console.WriteLine("массив заполнен до границ");
                for (int i = 0; i < size; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }
            
            Console.ReadLine();

        }
    }
}
