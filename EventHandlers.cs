namespace Infinity_Radio
{
    using HarmonyLib;
    using InventorySystem.Items.Radio;
    public class EventHandlers
    {
        [HarmonyPatch(typeof(RadioItem), "Update")]
        static class RadioPostfix
        {
            public static void Prefix(RadioItem __instance)
            {
                __instance.BatteryPercent = 100;
            }
        }
    }
}
