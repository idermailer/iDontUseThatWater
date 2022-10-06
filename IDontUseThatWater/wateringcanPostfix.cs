using iDontUseThatWater;
using StardewModdingAPI;
using StardewValley;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeawaterIsUnusable
{
    internal class wateringcanPostfix
    {
        private static IMonitor monitor;

        public static void isProperForWaterSource(int tileX, int tileY, ref bool __result)
        {
            try
            {
                if (Game1.currentLocation.doesTileHavePropertyNoNull(tileX, tileY, "WaterSource", "Back") == "F")
                {
                    __result = false;
                }
                return;
            }
            catch (Exception ex)
            {
                monitor.Log($"Failed in {nameof(isProperForWaterSource)}:\n{ex}", LogLevel.Error);
                return;
            }
        }
    }
}
