namespace TMPS_lab4.OCP
{
    public class Sword : Weapon
    {
        public Sword(int damage, int range) : base(damage, range)
        {
        }

        public override void Attack()
        {
            Console.WriteLine($"Sword hit with damage {Damage} and range {Range}");
        }
    }
}