using System;
namespace Singleton
{
    public class Single2
    {
        private static Single2 single;


        private Single2()
        {
        }

        public static Single2 GetSingle()
        {
            
            if (single == null)
                single = new Single2();
            lock (single) // Блокирует переменную сингле. Как в джаве синхронизация ?????????????????
            return single;
        }

        public void Show()
        {
            Console.WriteLine("Hello ALL World!!!");
        }
    }
}
