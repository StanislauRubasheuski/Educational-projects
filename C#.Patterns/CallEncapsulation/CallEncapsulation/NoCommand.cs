using System;
namespace CallEncapsulation
{
    public class NoCommand: Command
    {
        public void Execute()
        {
            Console.WriteLine("Ничего не происходит...");
        }

        public void Undo()
        {
            Console.WriteLine("Нечего отменять!");
        }
    }
}
