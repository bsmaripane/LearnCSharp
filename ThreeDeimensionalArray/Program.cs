namespace ThreeDeimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,,] simple3DArray =
            {
                {
                    { "000", "001", "002"},
                    { "010", "011", "012"},
                    { "020", "021", "022"}
                },
                {
                    { "100", "101", "102"},
                    { "110", "111", "112"},
                    { "120", "121", "121"}
                },
                {
                    { "200", "201", "201"},
                    { "210", "211", "212"},
                    { "220", "221", "222"}
                }
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int f = 0; f < 3; f++)
                        Console.Write(simple3DArray[i, j, f] + " ");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            foreach (var item  in simple3DArray)
                Console.Write(item);

            Console.ReadKey(true);
        }
    }
}
