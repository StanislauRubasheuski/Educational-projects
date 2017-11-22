using System;
namespace Singleton
{
    public class Single4
    {
        private volatile static Single4 single;


        private Single4()
        {
        }

        public static Single4 GetSingle()
        {

            if (single == null)
                single = new Single4();
            
                return single;
        }

        public void Show()
        {
            Console.WriteLine("Hello ALL World!!!");
        }
    }
}
