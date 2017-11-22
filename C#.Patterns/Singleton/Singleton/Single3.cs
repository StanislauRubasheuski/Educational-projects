using System;
namespace Singleton
{
    public class Single3
    {
        private static Single3 single = new Single3();


        private Single3()
        {
        }

        public static Single3 GetSingle()
        {
                return single;
        }

        public void Show()
        {
            Console.WriteLine("Hello ALL HAPPY World!!!");
        }
    }
}
