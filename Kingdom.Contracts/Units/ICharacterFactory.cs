using Kingdom.Contracts.Weapons;

namespace Kingdom.Contracts.Units
{
    public interface ICharacterFactory
    {
        Character CreateInstance(string characterName, IWeaponBehaviour weaponBehaviour);
    }
}
