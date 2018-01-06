using Kingdom.Contracts.Weapons;

namespace Kingdom.Contracts.Units
{
    public class Smurfette : Character
    {
        protected Smurfette(IWeaponBehaviour weaponBehaviour) : base(weaponBehaviour)
        {
        }
    }
}
