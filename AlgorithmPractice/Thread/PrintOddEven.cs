using System;
using System.Threading;
using System.Threading.Tasks;

namespace AlgorithmPractice.Thread
{
    public class ZeroEvenOdd
    {
        private int n;
        private volatile int CurrentCounter = 0;
     
        private static AutoResetEvent _evenLock = new AutoResetEvent(false);
        private static AutoResetEvent _oddLock = new AutoResetEvent(false);


        private Action<int> printNumber = (input) =>
        {
            if (input == 0)
            {
                Console.WriteLine(input);
            }
            else if (input % 2 == 0)
            {
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine(input);
            }
        };

        //public static void Main(string[] args)
        //{
        //    ZeroEvenOdd obj = new ZeroEvenOdd(10);           
        //    Task.Factory.StartNew(() => obj.Even(obj.printNumber));
        //    Task.Factory.StartNew(() => obj.Odd(obj.printNumber));
        //    _evenLock.Set();
        //    Console.ReadLine();
        //}

        public ZeroEvenOdd(int n)
        {
            this.n = n;
        }

        // printNumber(x) outputs "x", where x is an integer.
      

        public void Even(Action<int> printNumber)
        {
            while (CurrentCounter < n-1)
            {
                _oddLock.WaitOne();
                Console.WriteLine(CurrentCounter++);
                _evenLock.Set();
            }           
            
        }

        public void Odd(Action<int> printNumber)
        {
            while (CurrentCounter < n-1)
            {
                _evenLock.WaitOne();
                Console.WriteLine(CurrentCounter++);
                _oddLock.Set();
            }
        }

    }
}
