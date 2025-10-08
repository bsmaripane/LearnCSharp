namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Basic declaration of the jagged array.
            //int[][] jaggedArray;

            // Declare and initialising a jagged array
            int[][] jaggedArray = new int[4][];     // An array with four inner arrays

            // Assigning inner arrays
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5 };
            jaggedArray[2] = new int[] { 5, 6, 8, 9 };
            jaggedArray[3] = new int[] { 7, 5, 8, 2, 6, 1, 3 };

            // Printing jagged array
            for (int row = 0; row < 4; row++)
            {
                Console.Write($"Row {row +1}:");
                for (int element = 0; element < jaggedArray[row].Length; element++)
                    Console.Write($" {jaggedArray[row][element]} ");
                Console.WriteLine();
            }

       
            Console.ReadKey();
        }
    }
}
