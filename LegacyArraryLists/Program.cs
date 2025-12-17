using System.Collections;

namespace LegacyArraryLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring an ArrayList
            ArrayList myArrayList = new ArrayList();
            // Declaring an ArrayList with defined amount of object
            ArrayList myArrayList2 = new ArrayList(50);
            double sum = 0;

            myArrayList.Add(11);
            myArrayList.Add("Lesego");
            myArrayList.Add(3);
            myArrayList.Add("Kganya");
            myArrayList.Add(34.78);
            myArrayList.Add(13);
            myArrayList.Add(13);
            myArrayList.Add(13);
            myArrayList.Add("Belmy");

            Console.WriteLine("Initial ArrayList:");
            foreach (object obj in myArrayList)
            {
                if (obj is int)
                    sum += Convert.ToDouble(obj);
                else if (obj is double)
                    sum += (double)obj;
                else if (obj is string)
                    Console.WriteLine(obj);
            }
            Console.WriteLine($"Sum: {sum}");

            // Remove element with specific value from arrayList
            myArrayList.Remove(13);
            sum = 0;

            Console.WriteLine("ArrayList after Remove():");
            foreach (object obj in myArrayList)
            {
                if (obj is int)
                    sum += Convert.ToDouble(obj);
                else if (obj is double)
                    sum += (double)obj;
                else if (obj is string)
                    Console.WriteLine(obj);
            }
            Console.WriteLine($"Sum: {sum}");

            // Remove element at specific position
            myArrayList.RemoveAt(5);

            sum = 0;

            Console.WriteLine("ArrayList after RemoveAt():");
            foreach (object obj in myArrayList)
            {
                if (obj is int)
                    sum += Convert.ToDouble(obj);
                else if (obj is double)
                    sum += (double)obj;
                else if (obj is string)
                    Console.WriteLine(obj);
            }
            Console.WriteLine($"Sum: {sum}");


            Console.ReadKey();
        }
    }
}
