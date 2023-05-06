namespace TMPS_lab4.OCP_violation
{
    public static class OCPViolationExample
    {
        public static void StartExample()
        {
            var sword = new Weapon("sword", 50, 5);

            var player1 = new Player("Ninja", sword);

            player1.UseWeapon();

            var rifle = new Weapon("rifle", 30, 80);

            player1.ChangeWeapon(rifle);
            player1.UseWeapon();
        }
    }
}