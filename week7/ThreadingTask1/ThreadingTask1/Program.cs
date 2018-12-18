using System;
using System.Diagnostics;
using System.Threading;

namespace ThreadingTask1
{
    class Program
    {
        private static readonly int randomListMaxLenth = 100000000;
        private static int[] randomNumberList = new int[randomListMaxLenth];

        private static int sum = 0;
        private static int sum1 = 0;

        private static object syncObject = new object();
        static void Main(string[] args)
        {
            GenerateRandomNumbers();
            Stopwatch stopwatch1 = new Stopwatch();
            Thread thread1 = new Thread(SumInGroup1);
            Thread thread2 = new Thread(SumInGroup1);
            Thread thread3 =new Thread(SumInGroup1);
            thread1.Name = "thread #1";
            thread2.Name = "thead #2";
            stopwatch1.Start();
            thread1.Start();
            thread2.Start();
            thread3.Start();


            thread1.Join();
            thread2.Join();
            thread3.Join();
            stopwatch1.Stop();
            Console.WriteLine($"The thread calculated sum is {sum}");
            Console.WriteLine($"used {stopwatch1.ElapsedMilliseconds}ms");

            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();
            sum1 += Sum(randomNumberList, 0, randomListMaxLenth / 2);
            sum1 += Sum(randomNumberList, randomListMaxLenth / 2, randomListMaxLenth / 2);
            stopWatch2.Stop();
            Console.WriteLine($"Main thread calculated sum is {sum1}");
            Console.WriteLine($"used {stopWatch2.ElapsedMilliseconds}ms");
        }

        public static void GenerateRandomNumbers()
        {
            var random = new Random();

            for (int i = 0; i < randomNumberList.Length; i++)
            {
                randomNumberList[i] = random.Next(1, 5);
            }

        }

        public static int Sum(int[] array, int from, int count)
        {
            var tempSum = 0;
            
            


                for (int i = from; i < from + count; i++)
                {
                    lock (syncObject)
                    {


                        tempSum = tempSum + array[i];
                       // Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}");
                    }
                }
            

            return tempSum;
        }

        public static void SumInGroup1()
        {

            sum += Sum(randomNumberList, 0, randomListMaxLenth / 2);
            sum += Sum(randomNumberList, randomListMaxLenth / 2, randomListMaxLenth / 2);


        }


    }
}
