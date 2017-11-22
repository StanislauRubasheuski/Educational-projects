using System;

namespace Singleton
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Single single = Single.GetSingle();
            single.Show();
            Single2 single2 = Single2.GetSingle();
            single2.Show();
            Single3 single3 = Single3.GetSingle();
            single3.Show();
        }
    }
}
