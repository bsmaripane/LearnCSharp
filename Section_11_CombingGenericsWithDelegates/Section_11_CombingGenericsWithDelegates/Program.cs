namespace Section_11_CombingGenericsWithDelegates
{
    public delegate int Comparison<T>(T x, T y);

    public class Person
    {
        public int Age { get; set; }
        public string name { get; set; }
    }

    public class PersonSort
    {
        public void Sort(Person[] people, Comparison<Person> comparison)
        {
            for(int i = 0; i < people.Length - 1; i++)
            {
                for(int j = i + 1; j < people.Length; j++)
                {
                    // Compare people[i] and pwoplw[j] using the provided comparison delegate
                    if (comparison(people[i], people[j]) > 0)
                    {
                        Person temp = people[i];
                        people[i] = people[j];
                        people[j] = temp;
                    }
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.ReadKey();
        }
    }
}
