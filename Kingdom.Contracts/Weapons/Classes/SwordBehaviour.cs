using System;

namespace Kingdom.Contracts.Weapons.Classes
{
    public class SwordBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Slash!");
        }
    }
}
