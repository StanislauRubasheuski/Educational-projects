using System;
using System.Collections;

namespace LongersClass
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = "125";
            UHugeInt a = new UHugeInt();
            UHugeInt b = new UHugeInt(975);
            UHugeInt c = new UHugeInt(b);
            UHugeInt d = new UHugeInt(527);
            UHugeInt str = new UHugeInt(s);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(b + d);
            Console.WriteLine(str);

            UHugeInt val1 = new UHugeInt(1060);
            UHugeInt val2 = new UHugeInt(10);
            Console.WriteLine(val1 + val2);
        }
    }
}
