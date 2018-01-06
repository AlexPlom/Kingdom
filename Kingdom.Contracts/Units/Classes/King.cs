using Kingdom.Contracts.Weapons;

namespace Kingdom.Contracts.Units
{
    public class King : Character
    {
        public King(IWeaponBehaviour weaponBehaviour) : base(weaponBehaviour) { }
    }
}
