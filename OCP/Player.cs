namespace TMPS_lab4.OCP
{
    public class Player
    {
        private string Name { get; set; }
        private IAttack Weapon { get; set; }

        public Player(string name, IAttack weapon)
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