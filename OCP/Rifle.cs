namespace TMPS_lab4.OCP
{
    public class Rifle : Weapon, IReload
    {
        public int Bullets { get; set; }

        public Rifle(int damage, int range) : base(damage, range)
        {
        }

        public override void Attack()
        {
            Console.WriteLine($"Rifle shoot with damage {Damage} and range {Range}");
        }

        public void Reload()
        {
            Bullets = 30;
        }
    }
}