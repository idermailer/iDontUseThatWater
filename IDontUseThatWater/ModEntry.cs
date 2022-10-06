﻿using System;
using System.Reflection;
using HarmonyLib;
using Microsoft.Xna.Framework;
using SeawaterIsUnusable;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace iDontUseThatWater
{
    public class ModEntry : Mod
    {
        public static IMonitor monitor;
        public override void Entry(IModHelper helper)
        {
            var harmony = new Harmony(this.ModManifest.UniqueID);

            harmony.Patch(
                original: AccessTools.Method(typeof(StardewValley.GameLocation), nameof(StardewValley.GameLocation.CanRefillWateringCanOnTile)),
                postfix: new HarmonyMethod(typeof(wateringcanPostfix), nameof(wateringcanPostfix.isProperForWaterSource))
            );
        }
    
    }
}