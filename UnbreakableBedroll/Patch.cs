using System;
using HarmonyLib;
using UnityEngine;

namespace UnbreakableBedroll
{
    internal class Patch
    {
        [HarmonyPatch(typeof(Bed), "Degrade")]
        private static bool Prefix()
        {
            //MelonLoader.MelonLogger.Msg("Prevented bedroll from degrading");
            return false;
        }
    }
}
