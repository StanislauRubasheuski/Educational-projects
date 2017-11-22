using System;
namespace CallEncapsulation
{
    public class Stereo
    {
        int volume;

        public int Volume
        {
            set { volume = value; }
            get { return volume; }
        }

        public void On()
        {
            Console.WriteLine("Стереопроигрыватель включен.");
        }

        public void Off()
        {
            Console.WriteLine("Стереопроигрыватель выключен.");
        }

        public void SetCD()
        {
            Console.WriteLine("Выбран запуск проигрывания CD");
        }
    }
}
