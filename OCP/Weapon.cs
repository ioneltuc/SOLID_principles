namespace TMPS_lab4.OCP
{
    public abstract class Weapon : IAttack
    {
        public int Damage { get; set; }
        public int Range { get; set; }

        public Weapon(int damage, int range)
        {
            Damage = damage;
            Range = range;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"Attack with damage {Damage} and range {Range}");
        }
    }
}