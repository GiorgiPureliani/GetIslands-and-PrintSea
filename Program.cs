namespace Project7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] sea = new int[Random.Shared.Next(10, 20), Random.Shared.Next(10, 20)];
            GenerateIslands(sea);
            PrintSea(sea);
            Console.WriteLine($"\nWe have {GetIslandsCount(sea)} islands");
        }

        static int GetIslandsCount(int[,] sea)
        {
            return 0;
        }

        static void GenerateIslands(int[,] sea)
        {
            for (int i = 0; i < sea.GetLength(0); i++)
            {
                for (int j = 0; j < sea.GetLength(1); j++)
                {
                    sea[i, j] = Random.Shared.Next(10) > 7 ? 1 : 0;
                }
            }
        }

        static void PrintSea(int[,] sea)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < sea.GetLength(0); i++)
            {
                for (int j = 0; j < sea.GetLength(1); j++)
                {
                    if (sea[i, j] == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }

                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }

                    Console.Write($" {sea[i, j]} ");
                }

                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
}