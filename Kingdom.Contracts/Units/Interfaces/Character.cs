using Kingdom.Contracts.Weapons;

namespace Kingdom.Contracts
{
    public abstract class Character
    {
        private readonly IWeaponBehaviour weaponBehaviour;

        protected Character(IWeaponBehaviour weaponBehaviour)
        {
            this.weaponBehaviour = weaponBehaviour;
        }

        public void Fight()
        {
            weaponBehaviour.UseWeapon();
        }
    }
}
