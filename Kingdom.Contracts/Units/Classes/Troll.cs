using Kingdom.Contracts.Weapons;

namespace Kingdom.Contracts.Units
{
    public class Troll : Character
    {
        public Troll(IWeaponBehaviour weaponBehaviour) : base(weaponBehaviour) { }
    }
}
