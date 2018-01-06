using System;

namespace Kingdom.Contracts.Weapons
{
    public class AxeBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Chop!");
        }
    }
}
