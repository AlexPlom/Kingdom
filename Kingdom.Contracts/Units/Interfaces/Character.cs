using Kingdom.Contracts.Weapons;
using System;

namespace Kingdom.Contracts
{
    public abstract class Character
    {
        private IWeaponBehaviour weaponBehaviour;

        public Character(IWeaponBehaviour weaponBehaviour)
        {
            this.weaponBehaviour = weaponBehaviour;
        }

        public void Fight()
        {
            Console.WriteLine(GetType().Name + " used " + weaponBehaviour.UseWeapon());
        }

        public void ChangeFightingBehaviour(IWeaponBehaviour weaponBehaviour)
        {
            if (weaponBehaviour is null) throw new ArgumentNullException(nameof(weaponBehaviour));

            Console.WriteLine(GetType().Name + " changed the fighting behaviour!");
            this.weaponBehaviour = weaponBehaviour;
        }
    }
}
