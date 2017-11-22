using System;
namespace CallEncapsulation
{
    public interface Command
    {
        void Execute();
        void Undo();
    }
}
