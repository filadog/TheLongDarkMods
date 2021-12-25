using System;
using HarmonyLib;
using UnityEngine;

namespace UnbreakableBedroll
{
    internal class Patch
    {
        [HarmonyPatch(typeof(Bed), "Degrade")]
        internal class Bed_Degrade
        {
            private static bool Prefix()
            {
                return false;
            }
        }
    }
}
