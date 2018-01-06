using Kingdom.Contracts.Weapons;

namespace Kingdom.Contracts.Units
{
    public class Queen : Character
    {
        public Queen(IWeaponBehaviour weaponBehaviour) : base(weaponBehaviour) { }
    }
}
