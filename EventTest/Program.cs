using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest
{
    class Program
    {
        public delegate int AddDelegate(int a, int b);

        static void Main(string[] args)
        {
            Adder a = new Adder();
            a.OnMultiplesOfFiveReached += A_OnMultiplesOfFiveReached;

            int answer = a.Add(5, 23);
            Console.WriteLine("anser = {0}", answer);

            int answer2 = a.Add(5, 5);
            Console.WriteLine("anser = {0}", answer2);

            int answer3 = a.Add(5, 10);
            Console.WriteLine("anser = {0}", answer3);


        }

        private static void A_OnMultiplesOfFiveReached(object ender, MultipleEventArgs e)
        {
            Console.WriteLine("EventFired");
            Console.WriteLine("Five multiple reached ({0})", e.Sum);
            Console.WriteLine("EventComplete");
        }
    }

    public class MultipleEventArgs : EventArgs
    {
        public int Sum { get; set; }

        public MultipleEventArgs(int sum)
        {
            Sum = sum;
        }
    }

    public class Adder
    {

        public event EventHandler<MultipleEventArgs> OnMultiplesOfFiveReached;

        public int Add(int a, int b)
        {
            int sum = a + b;
            if (sum % 5 == 0 && OnMultiplesOfFiveReached != null)
            {
                OnMultiplesOfFiveReached(this, new MultipleEventArgs(sum));
            }

            return sum;
        }
    }
}
