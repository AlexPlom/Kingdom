using Kingdom.Contracts.Weapons;

namespace Kingdom.Contracts.Units
{
    public class Smurfette : Character
    {
        public Smurfette(IWeaponBehaviour weaponBehaviour) : base(weaponBehaviour) { }
    }
}
