using System;
using System.Threading;

namespace MultithreadingFun
{
    public class A
    {
        public virtual void Print1()
        {
            Console.Write("A");
        }
        public void Print2()
        {
            Console.Write("A");
        }
    }
    public class B : A
    {
        public override void Print1()
        {
            Console.Write("B");
        }
    }
    public class C : B
    {
        new public void Print2()
        {
            Console.Write("C");
        }
    }

    class ThreadTest
    {
        bool done;

        static void FMain()
        {
            var c = new C();
            A a = c;

            a.Print2();
            a.Print1();
            c.Print2();

            //var s = "Strings are immutable";
            //int length = s.Length;
            //unsafe
            //{
            //    fixed (char* c = s)
            //    {
            //        for (int i = 0; i < length / 2; i++)
            //        {
            //            var temp = c[i];
            //            c[i] = c[length - i - 1];
            //            c[length - i - 1] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine("Strings are immutable");

            //ThreadTest tt = new ThreadTest();   // Создание общего экземпляра
            //new Thread(tt.Go).Start();
            //tt.Go();
        }

        // Обратите внимание, что Go теперь метод экземпляра:
        void Go()
        {
            if (!done)
            {
                //Thread.Sleep(10);
                done = true;
                Console.WriteLine("Done");
            }
        }
    }

    class PriorityTest
    {
        static void FMain(string[] args)
        {
            Thread worker = new Thread(() => Console.ReadLine());
            if (args.Length > 0)
                worker.IsBackground = true;
            worker.Start();
            Console.WriteLine("Hello world");
        }
    }
}
