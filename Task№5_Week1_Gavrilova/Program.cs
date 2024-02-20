using System;

namespace ChessHorse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод координат коня и фигуры.
            Console.WriteLine("Введите координаты коня и фигуры в формате 'a1 b2':");
            string input = Console.ReadLine();
            string[] coordinates = input.Split(' ');

            // Проверка корректности введенных данных.
            if (coordinates.Length != 2 || !IsValidCoordinate(coordinates[0]) || !IsValidCoordinate(coordinates[1]))
            {
                Console.WriteLine("Введены некорректные координаты");
                return;
            }

            // Получение координат коня и фигуры.
            char horseColumns = coordinates[0][0];
            int horseRows = int.Parse(coordinates[0][1].ToString());
            char figureColumns = coordinates[1][0];
            int figureRows = int.Parse(coordinates[1][1].ToString());

            // Проверка бьёт ли король фигуру.
            if ((Math.Abs(horseColumns - figureColumns) == 1 && Math.Abs(horseRows - figureRows) == 2) || 
                (Math.Abs(horseColumns - figureColumns) == 2 && Math.Abs(horseRows - figureRows) == 1))
            {
                Console.WriteLine("Конь сможет побить фигуру");
            }
            else
            {
                Console.WriteLine("Конь не сможет побить фигуру");
            }
        }

        // Проверка корректности координат.
        static bool IsValidCoordinate(string coordinate)
        {
            if (coordinate.Length != 2)
            {
                return false;
            }

            char colomns = coordinate[0];
            int rows = int.Parse(coordinate[1].ToString());

            return (colomns >= 'a' && colomns <= 'h') && (rows >= 1 && rows <= 8);
        }

    }
}