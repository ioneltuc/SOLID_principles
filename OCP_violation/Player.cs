namespace TMPS_lab4.OCP_violation
{
    public class Player
    {
        private string Name { get; set; }
        private Weapon Weapon { get; set; }

        public Player(string name, Weapon weapon)
        {
            Name = name;
            Weapon = weapon;
        }

        public void ChangeWeapon(Weapon newWeapon)
        {
            Weapon = newWeapon;
        }

        public void UseWeapon()
        {
            Weapon.Attack();
        }
    }
}