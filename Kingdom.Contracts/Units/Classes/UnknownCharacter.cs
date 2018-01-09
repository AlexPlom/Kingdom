using Kingdom.Contracts.Weapons;

namespace Kingdom.Contracts.Units.Classes
{
    public class UnknownCharacter : Character
    {
        public UnknownCharacter(IWeaponBehaviour weaponBehaviour) : base(weaponBehaviour)
        {
        }
    }
}
