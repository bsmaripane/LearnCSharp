namespace TwoDimensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array2DDeclaration = new int[3, 3];
            
            int[,,] array3DDeclaration = new int[3, 3, 4];

            int[,] array2DInitialised = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                    Console.Write(array2DInitialised[row, col] + " ");
                Console.WriteLine();
                if (row == 2)
                    Console.WriteLine("# " + 0 + " * ");
            }

            Console.ReadKey();
        }
    }
}
