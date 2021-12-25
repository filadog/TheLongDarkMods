using System;
using MelonLoader;
using UnityEngine;

namespace UnbreakableBedroll
{
    public class UnbreakableBedroll : MelonMod
    {
        public override void OnApplicationStart()
        {
            Debug.Log("UnbreakableBedroll initialized");
        }
    }

    static class BuildInfo
    {
        public const string name = "UnbreakableBedroll";
        public const string author = "filadog";
        public const string description = "Bedroll won't break from usage. Ever.";
        public const string version = "1.0.0";
    }
}
