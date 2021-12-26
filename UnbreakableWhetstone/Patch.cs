using HarmonyLib;

namespace UnbreakableWhetstone
{
    internal class Patch
    {
        [HarmonyPatch(typeof(GearItem), "Degrade")]
        internal class GearItem_Degrade
        {
            [HarmonyPrefix]
            private static bool Prefix(GearItem __instance)
            {
                if (__instance.m_GearName == "GEAR_SharpeningStone")
                {
                    //MelonLoader.MelonLogger.Msg("Prevented sharpening stone from degrading");
                    return false;
                }
                return true;
            }
        }
    }
}
