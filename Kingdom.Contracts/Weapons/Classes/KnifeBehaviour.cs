using System;

namespace Kingdom.Contracts.Weapons.Classes
{
    public class KnifeBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Shank!");
        }
    }
}
