using System;
using MelonLoader;
using UnityEngine;

namespace DemoMod
{
    public class DemoMod : MelonMod
    {
        public override void OnApplicationStart()
        {
            Debug.Log("DemoMod by filadog initialized");
        }
    }
}
