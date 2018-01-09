using Kingdom.Contracts;
using Kingdom.Contracts.Units;
using Kingdom.Contracts.Weapons;
using System;
using System.Collections.Generic;

namespace Fightings
{
    class WarStartup
    {
        static void Main(string[] args)
        {
            Dictionary<string, IWeaponBehaviour> characterInformation = new Dictionary<string, IWeaponBehaviour>
            {
                { "King", new SwordBehaviour() },
                { "Knight", new BowAndArrowBehaviour() },
                { "Queen", new AxeBehaviour() },
                { "Troll", new PaperClipBehaviour() },
                { "GrandWizard", new KnifeBehaviour() }
            };

            IEnumerable<Character> units = GenerateTroops(characterInformation);
            DeployTheAttack(units);
        }

        private static IEnumerable<Character> GenerateTroops(Dictionary<string, IWeaponBehaviour> characterInformation)
        {
            var factory = new CharacterFactory();
            List<Character> characters = new List<Character>();

            foreach (var information in characterInformation)
            {
                characters.Add(factory.CreateInstance(information.Key, information.Value));
            }

            return characters;
        }

        private static void DeployTheAttack(IEnumerable<Character> units)
        {
            foreach (var unit in units)
            {
                unit.Fight();
                unit.ChangeFightingBehaviour(new BowAndArrowBehaviour());
                unit.Fight();

                Console.WriteLine();
            }
        }
    }
}
