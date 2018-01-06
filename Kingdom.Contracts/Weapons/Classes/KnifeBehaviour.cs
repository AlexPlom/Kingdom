﻿using System;

namespace Kingdom.Contracts.Weapons
{
    public class KnifeBehaviour : IWeaponBehaviour
    {
        public string UseWeapon()
        {
            return "Shank!";
        }
    }
}
