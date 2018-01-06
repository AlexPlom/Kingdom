using Kingdom.Contracts.Weapons;

namespace Kingdom.Contracts.Units
{
    public class Troll : Character
    {
        protected Troll(IWeaponBehaviour weaponBehaviour) : base(weaponBehaviour)
        {
        }
    }
}
