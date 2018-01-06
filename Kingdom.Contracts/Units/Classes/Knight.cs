using Kingdom.Contracts.Weapons;

namespace Kingdom.Contracts.Units
{
    public class Knight : Character
    {
        public Knight(IWeaponBehaviour weaponBehaviour) : base(weaponBehaviour) { }
    }
}
