using System;
using HarmonyLib;
using UnityEngine;

namespace DemoMod
{
    internal class Patch
    {
        
    }

    [HarmonyPatch(typeof(GameManager), "Awake")]
    internal class GameManager_Awake
    {
        private static void Postfix()
        {
            MelonLoader.MelonLogger.Msg("Hello");
        }
    }
}
