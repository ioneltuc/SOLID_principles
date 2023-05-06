namespace TMPS_lab4.OCP
{
    //Violating Interface Segregation
    public interface IWeapon
    {
        void Attack();

        void Reload();
    }
}