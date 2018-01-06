using Kingdom.Contracts.Weapons;

namespace Kingdom.Contracts.Units
{
    public class Knight : Character
    {
        protected Knight(IWeaponBehaviour weaponBehaviour) : base(weaponBehaviour) { }
    }
}
