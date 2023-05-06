namespace TMPS_lab4.OCP
{
    public static class OCPExample
    {
        public static void StartExample()
        {
            Weapon sword = new Sword(50, 5);

            var player1 = new Player("Ninja", sword);

            player1.UseWeapon();

            Weapon rifle = new Rifle(30, 80);

            player1.ChangeWeapon(rifle);
            player1.UseWeapon();
        }
    }
}