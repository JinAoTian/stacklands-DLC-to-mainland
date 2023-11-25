using HarmonyLib;
using System;
using System.Collections;
using UnityEngine;

namespace JYZDLCToMainNS
{
    public class JYZDLCToMain : Mod
    {
        public override void Ready()
        {
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.BasicHarvestable, "tomato_plant", 1);
        }
    }
}