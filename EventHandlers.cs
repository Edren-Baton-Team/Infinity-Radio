namespace Infinity_Radio
{
    using InventorySystem.Items.Radio;
    using PluginAPI.Core;
    using PluginAPI.Core.Attributes;
    using PluginAPI.Enums; 
    public class EventHandlers
    {
        [PluginEvent(ServerEventType.PlayerChangeRadioRange)]
        public void OnPlayerChangesRadioRange(Player player, RadioItem radio, byte range)
        {
            radio.enabled = false;
            radio.BatteryPercent = 100;
        }
    }
}
