using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public static class MemoryManagement
    {
        public static void FMain()
        {
            Console.Beep(200, 5000);
            Test();
            //GC.Collect();
            Console.ReadKey();
        }

        public static void Test()
        {
            var someClass = new SomeClassWithDesctructor();
            Console.WriteLine(someClass);
            someClass = null;
        }
    }

    public class SomeClassWithDisposablePattern : IDisposable
    {
        private bool disposed = false;

        public SomeClassWithDisposablePattern()
        {
        }

        // реализация интерфейса IDisposable.
        public void Dispose()
        {
            Dispose(true);
            // подавляем финализацию
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Освобождаем управляемые ресурсы
                }
                // освобождаем неуправляемые объекты
                disposed = true;
            }
        }

        // Деструктор
        ~SomeClassWithDisposablePattern()
        {
            Console.Beep(200, 5000);
            Console.WriteLine("Yes");
            Dispose(false);
        }
    }

    public class SomeClassWithDesctructor
    {
        public SomeClassWithDesctructor()
        {
        }

        // Деструктор
        ~SomeClassWithDesctructor()
        {
            Console.Beep(200, 5000);
            Console.WriteLine("Yes");
        }
    }
}
