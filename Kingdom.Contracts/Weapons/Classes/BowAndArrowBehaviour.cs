using System;

namespace Kingdom.Contracts.Weapons
{
    public class BowAndArrowBehaviour : IWeaponBehaviour
    {
        public string UseWeapon()
        {
            return "Headshot!";
        }
    }
}
