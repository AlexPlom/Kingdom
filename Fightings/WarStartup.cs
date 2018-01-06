using Kingdom.Contracts;
using Kingdom.Contracts.Units;
using Kingdom.Contracts.Weapons;
using System;

namespace Fightings
{
    class WarStartup
    {
        static void Main(string[] args)
        {
            Character[] units = GenerateTroops();
            DeployTheAttack(units);
        }

        private static Character[] GenerateTroops()
        {
            return new Character[5]
            {
                new King(new SwordBehaviour()),
                new Queen(new BowAndArrowBehaviour()),
                new Knight(new AxeBehaviour()),
                new Troll(new PaperClipBehaviour()),
                new Smurfette(new KnifeBehaviour())
            };
        }

        private static void DeployTheAttack(Character[] units)
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
