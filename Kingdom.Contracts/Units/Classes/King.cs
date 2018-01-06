using Kingdom.Contracts.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kingdom.Contracts.Units
{
    public class King : Character
    {
        protected King(IWeaponBehaviour weaponBehaviour) : base(weaponBehaviour) { }
    }



    public class SwordBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Slash!");
        }
    }

    public class KnifeBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Shank!");
        }
    }

    public class BowAndArrowBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Headshot!");
        }
    }

    public class PaperClipBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Cut? Is this even effective?");
        }
    }
}
