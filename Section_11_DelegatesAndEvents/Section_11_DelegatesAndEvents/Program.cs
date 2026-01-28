namespace Section_11_DelegatesAndEvents
{
    internal class Program
    {
        // 1. Declaration:
        public delegate void Notify(string message);
         
        static void Main(string[] args)
        {
            // Delegates define a method signature, and any method assigned to a delegate must match this signature

            // 2. Instatiation:
            Notify notifyDelegate = ShowMessage;
            //Notify notifyDelegate = new Notify(notifyDelegate); // old style

            // 3. Invocation:
            notifyDelegate("Morning Delegate");

            Console.ReadKey();
        }

        // Mehod
        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
