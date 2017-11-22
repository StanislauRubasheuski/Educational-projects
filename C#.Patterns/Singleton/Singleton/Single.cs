using System;
namespace Singleton
{
    public class Single
    {
        private  static Single single;

        private Single()
        {
        }

        public static Single GetSingle()
        {
            if (single == null)
                single = new Single();
            return single;
        }

        public void Show()
        {
            Console.WriteLine("Hello World!!!");
        }
    }
}
