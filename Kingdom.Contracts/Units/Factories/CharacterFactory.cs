using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Kingdom.Contracts.Units.Classes;
using Kingdom.Contracts.Weapons;
using Kingdom.Contracts.Weapons.Classes;

namespace Kingdom.Contracts.Units
{
    public class CharacterFactory : ICharacterFactory
    {
        private Dictionary<string, Type> characters;

        public CharacterFactory()
        {
            LoadAllTypesOfCharacterFromAssembly();
        }

        public Character CreateInstance(string characterName, IWeaponBehaviour weaponBehaviour)
        {
            if (string.IsNullOrEmpty(characterName)) throw new ArgumentNullException(nameof(characterName));
            if (ReferenceEquals(null, weaponBehaviour)) throw new ArgumentNullException(nameof(weaponBehaviour));

            Type typeToCreate = GetTypeToCreate(characterName);

            if (typeToCreate == null)
                return new UnknownCharacter(new UnknownBehaviour());

            return Activator.CreateInstance(typeToCreate, weaponBehaviour) as Character;
        }

        private Type GetTypeToCreate(string characterName)
        {
            if (string.IsNullOrEmpty(characterName)) throw new ArgumentNullException(nameof(characterName));


            foreach (var character in characters)
            {
                if (character.Key.Contains(characterName.ToLower()))
                {
                    return characters[character.Key];
                }
            }

            return null;
        }

        private void LoadAllTypesOfCharacterFromAssembly()
        {
            characters = new Dictionary<string, Type>();

            IEnumerable<Type> types = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsSubclassOf(typeof(Character)));

            foreach (Type type in types)
            {
                characters.Add(type.Name.ToLower(), type);
            }
        }
    }
}
