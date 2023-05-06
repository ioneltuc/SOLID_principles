namespace TMPS_lab4.OCP_violation
{
    public class Weapon
    {
        private string Type { get; set; }
        private int Damage { get; set; }
        private int Range { get; set; }

        public Weapon(string type, int damage, int range)
        {
            Type = type;
            Damage = damage;
            Range = range;
        }

        public void Attack()
        {
            if (Type.ToLower() == "sword")
            {
                Console.WriteLine($"Sword hit with damage {Damage} and range {Range}");
            }
            else if (Type.ToLower() == "rifle") //added later
            {
                Console.WriteLine($"Rifle shoot with damage {Damage} and range {Range}");
            }
        }
    }
}