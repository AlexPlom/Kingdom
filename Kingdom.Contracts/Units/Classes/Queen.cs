using Kingdom.Contracts.Weapons;

namespace Kingdom.Contracts.Units
{
    public class Queen : Character
    {
        protected Queen(IWeaponBehaviour weaponBehaviour) : base(weaponBehaviour) { }
    }
}
