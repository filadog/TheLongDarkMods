using System;
using MelonLoader;
using UnityEngine;


namespace UnbreakableWhetstone
{
    public class Implementation : MelonMod
    {
        public override void OnApplicationStart()
        {
        }
    }

    internal static class BuildInfo
    {
        public const string name = "UnbreakableWhetstone";
        public const string author = "filadog";
        public const string description = "Sharpening stone won't break from usage. Ever.";
        public const string version = "1.0.0";
    }
}
