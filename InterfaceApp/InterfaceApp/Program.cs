namespace InterfaceApp
{
    public interface IEnemy
    {
        void Attack();
        void Defend();
    }

    public class Dragon : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("Dragon breathes fire~");
        }

        public void Defend()
        {
            Console.WriteLine("Dragon spreads its wings to shield itself.");
        }
    }

    public class Vampire : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("Vampire strikes with its fangs.");
        }

        public void Defend()
        {
            Console.WriteLine("Vampire transforms into a bat to evade.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IEnemy enemy1 = new Dragon();
            IEnemy enemy2 = new Vampire();

            List<IEnemy> enemyList = new List<IEnemy>();
            enemyList.Add(enemy1);
            enemyList.Add(enemy2);

            foreach (IEnemy enemy in enemyList)
            {
                enemy.Attack();
                enemy.Defend();
            }

            Console.ReadKey();
        }
    }
}
