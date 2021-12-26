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
            [HarmonyPrefix]
            private static bool Prefix()
            {
                //MelonLoader.MelonLogger.Msg("Prevented bedroll from degrading");
                return false;
            }
        }
    }
}
