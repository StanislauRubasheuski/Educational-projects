using System;

namespace Adapter
{
    class MainClass
    {
        static void TestDuck(Duck duck)
        {
            duck.Fly();
            duck.Quack();
        }

        public static void Main(string[] args)
        {
            MallarDuck duck = new MallarDuck();
            WildTurkey turkey = new WildTurkey();
            Duck turkeyAdapter = new TurkeyAdapter(turkey);
            turkeyAdapter.Fly();
            turkeyAdapter.Quack();
            TestDuck(duck);
            Turkey duckAdapter = new DuckAdapter(duck);
            duckAdapter.Gobble();
            duckAdapter.Fly();
        }
    }
}
