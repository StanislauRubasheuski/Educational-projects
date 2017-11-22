using System;
using System.Collections;
namespace LongersClass
{
    public class UHugeInt
    {
        ArrayList a = new ArrayList();

        public UHugeInt()
        {
            //a.Add(0);
        }

        public UHugeInt(int value)
        {
            int c = value;
            while (c > 0)
            {
                a.Add(c % 10);
                c /= 10;
            }
            a.Reverse();
        }

        public UHugeInt(string s)
        {
            for (int i = 0; i < s.Length; i++)
                a.Add((int)s[i] - '0');
        }

        public UHugeInt(UHugeInt b)
        {
            for (int i = 0; i < b.a.Count; i++)
            {
                a.Add(b.a[i]);
            }
        }

        public override string ToString()
        {
            string s = "";
            foreach (int x in a)
                s += x;
            return s;
        }

        public static UHugeInt operator +(UHugeInt a, UHugeInt b)
        {
            if (a.a.Count < b.a.Count)
            {
                int razn = b.a.Count - a.a.Count;
                for (int i = 0; i < razn; i++)
                   // a.a.Add(0);
                a.a.Insert(0, 0);
            }

            if (a.a.Count > b.a.Count)
            {
                int razn = a.a.Count - b.a.Count;
                for (int i = 0; i < razn; i++)
                    //b.a.Add(0);
                b.a.Insert(0, 0);
            }


            UHugeInt c = new UHugeInt();
            int perenos = 0;
            for (int i = a.a.Count - 1; i >= 0; i--)
            {
                int buffer = (int)a.a[i] + (int)b.a[i] + perenos;
                if (buffer > 9)
                {
                    c.a.Add(buffer - 10);
                    perenos = 1;
                }
                else
                {
                    c.a.Add(buffer);
                    perenos = 0;
                }
            }
            if (perenos > 0)
                c.a.Add(perenos);
            
            c.a.Reverse();
            return c;
        }
    }
}
