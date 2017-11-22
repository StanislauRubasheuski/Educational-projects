//Морской бой - расстановка кораблей в случайном порядке
using System;


namespace SeaBattle
{
    class Program
    {
        static int[,] sea = new int[10, 10];

        static void Init() //Инициализация матрицы
        {
            for (int i = 0; i < sea.GetLength(0); i++)
                for (int j = 0; j < sea.GetLength(1); j++)
                    sea[i, j] = 0;
        }

        static void Output() // Вывод матрицы на экран
        {
            for (int i = 0; i < sea.GetLength(0); i++)
            {
                for (int j = 0; j < sea.GetLength(1); j++)
                    Console.Write(sea[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void ShipArrangement() // Главный метод, занимается расстановкой кораблей
        {
            Random rand = new Random();
            int count = 0;
            int mod = 5;
            int countLast = 0;

            while (count < 19)
            {
                int key = rand.Next(0, 1);
                int row = rand.Next(0, 9);
                int column = rand.Next(0, 9);

                if (key == 0)
                    if (ShipRow(row, column, mod))
                    {
                        ShipBuildingRow(row, column, mod);
                        count++;
                    }
                    else
                        if (ShipColumn(row, column, mod))
                    {
                        ShipBuildingColumn(row, column, mod);
                        count++;
                    }

                if (count == 1)
                {
                    mod--;
                    count++;
                }
                    
                
                if (count == 4)
                {
                    mod--;
                    count++;
                }
                    
                if (count == 8)
                {
                    mod--;
                    count++;
                }
                    
                if (count == 13)
                {
                    mod--;
                    count++;
                }
                countLast++;
                if (countLast > 1000)
                {
                    Init();
                    mod = 5;
                    count = 0;
                    countLast = 0;
                }
            }
        }

        static void ShipBuildingRow(int row, int column, int mod) //Строит корабль горизонтально
        {
            for (int i = row, j = column, m = 0; m < mod; m++, j++)
                sea[i, j] = 1;

        }

        static void ShipBuildingColumn(int row, int column, int mod) // Строит корабль вертикально
        {
            for (int i = row, j = column, m = 0; m < mod; m++, i++)
                sea[i, j] = 1;
        }

        static bool ShipRow(int row, int column, int mod) // Проверяет по горизонтали, есть ли корабли на этих клетках
        {
            if (column > sea.GetLength(1) - mod)
                return false;
            if (column != 0 && column != sea.GetLength(1) - mod)
                for (int i = row, j = column - 1, m = 0; m < mod + 2; m++, j++)
                    if (sea[i, j] == 1)
                        return false;
            if (column == 0)
                for (int i = row, j = column, m = 0; m < mod + 1; m++, j++)
                    if (sea[i, j] == 1)
                        return false;
            if (column == sea.GetLength(1) - mod)
                for (int i = row, j = column - 1, m = 0; m < mod + 1; m++, j++)
                    if (sea[i, j] == 1)
                        return false;

            if (row != 0 && column != 0 && column != sea.GetLength(1) - mod)
                for (int i = row - 1, j = column - 1, m = 0; m < mod + 2; m++, j++)
                    if (sea[i, j] == 1)
                        return false;
            if (row != 0 && column == 0)
                for (int i = row - 1, j = column, m = 0; m < mod + 1; m++, j++)
                    if (sea[i, j] == 1)
                        return false;
            if (row != 0 && column == sea.GetLength(1) - mod)
                for (int i = row - 1, j = column - 1, m = 0; m < mod + 1; m++, j++)
                    if (sea[i, j] == 1)
                        return false;

            if (row != 9 && column != 0 && column != sea.GetLength(1) - mod)
                for (int i = row + 1, j = column - 1, m = 0; m < mod + 2; m++, j++)
                    if (sea[i, j] == 1)
                        return false;
            if (row != 9 && column == 0)
                for (int i = row + 1, j = column, m = 0; m < mod + 1; m++, j++)
                    if (sea[i, j] == 1)
                        return false;
            if (row != 9 && column == sea.GetLength(1) - mod)
                for (int i = row + 1, j = column - 1, m = 0; m < mod + 1; m++, j++)
                    if (sea[i, j] == 1)
                        return false;

            return true;
        }

        static bool ShipColumn(int row, int column, int mod) // Проверяет по вертикали наличие кораблей на клетках
        {
            if (row > sea.GetLength(0) - mod)
                return false;

            if (row != 0 && row != sea.GetLength(0) - mod)
                for (int i = row - 1, j = column, m = 0; m < mod + 2; m++, i++)
                    if (sea[i, j] == 1)
                        return false;
            if (row == 0)
                for (int i = row, j = column, m = 0; m < mod + 1; m++, i++)
                    if (sea[i, j] == 1)
                        return false;
            if (row == sea.GetLength(0) - mod)
                for (int i = row - 1, j = column, m = 0; m < mod + 1; m++, i++)
                    if (sea[i, j] == 1)
                        return false;

            if (column != 0 && row != 0 && row != sea.GetLength(0) - mod)
                for (int i = row - 1, j = column - 1, m = 0; m < mod + 2; m++, i++)
                    if (sea[i, j] == 1)
                        return false;
            if (column != 0 && row == 0)
                for (int i = row, j = column - 1, m = 0; m < mod + 1; m++, i++)
                    if (sea[i, j] == 1)
                        return false;
            if (column != 0 && row == sea.GetLength(0) - mod)
                for (int i = row - 1, j = column - 1, m = 0; m < mod + 1; m++, i++)
                    if (sea[i, j] == 1)
                        return false;


            if (column != 9 && row != 0 && row != sea.GetLength(0) - mod)
                for (int i = row - 1, j = column + 1, m = 0; m < mod + 2; m++, i++)
                    if (sea[i, j] == 1)
                        return false;
            if (column != 9 && row == 0)
                for (int i = row, j = column + 1, m = 0; m < mod + 1; m++, i++)
                    if (sea[i, j] == 1)
                        return false;
            if (column != 9 && row == sea.GetLength(0) - mod)
                for (int i = row - 1, j = column + 1, m = 0; m < mod + 1; m++, i++)
                    if (sea[i, j] == 1)
                        return false;

            return true;
        }

        static void Main(string[] args)
        {
            Init();
            ShipArrangement();
            Output();
            Console.ReadKey();
        }
    }
}
