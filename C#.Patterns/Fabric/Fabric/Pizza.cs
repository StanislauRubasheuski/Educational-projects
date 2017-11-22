using System;
using System.Collections;

namespace Fabric
{
    public abstract class Pizza
    {
        protected string name;
        protected string sauce;
        protected string dough;
        protected ArrayList topings = new ArrayList();

        public string Name
        {
            get { return name; }
        }

        public void Prepare()
        {
            Console.WriteLine("Начинаем готовку " + name);
            Console.WriteLine("Берем за основу" + dough);
            Console.WriteLine("Поливаем соусом " + sauce);
            Console.Write("Добавляем добавки: ");
            foreach (Object x in topings)
                Console.Write(x + " ");
            Console.WriteLine();
        }

        public void Bake()
        {
            Console.WriteLine("Ставим пиццу в печь на 25 минут с температурой 120 градусов");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Режем пиццу треугольниками");
        }

        public void Box()
        {
            Console.WriteLine("Кладем пиццу в фирменную упаковку");
        }


    }
}
