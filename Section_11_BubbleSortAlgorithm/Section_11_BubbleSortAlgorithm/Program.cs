namespace Section_11_BubbleSortAlgorithm
{
    internal class Program
    {
        static void BubbleSort(int[] arr)
        {
            int len = arr.Length;
            bool swapped;

            for (int i = 0; i < len; i++)
            {
                swapped = false;

                for (int j = 0; j < len - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                // If no swaps occurred, the array is already sorted
                if (!swapped) break;
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 9, 1, 6, 7, 3, 7, 4, 8, 2, 5 };

            Console.WriteLine($"Unsorted Array: {string.Join(",", arr)}");

            BubbleSort(arr);

            Console.WriteLine($"Sorted Array: {string.Join(",", arr)}");


            Console.ReadKey();
        }
    }
}
