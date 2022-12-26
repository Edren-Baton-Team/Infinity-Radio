namespace Infinity_Radio
{
    using PluginAPI.Core;
    using PluginAPI.Core.Attributes;
    using PluginAPI.Enums;
    using PluginAPI.Events;
    public class Plugin
    {
        public const string Name = "Infinity Radio";
        public const string Version = "v1.0.0";
        public const string Author = "Rysik5318";
        public static Plugin Instance { get; private set; }

        [PluginConfig("Infinity_Radio.yml")]
        public Config Config;

        [PluginPriority(LoadPriority.Highest)]
        [PluginEntryPoint(Name, Version, "Gives radios infinite batteries", Author)]
        void LoadPlugin()
        {
            // Thx for this code Jesus-QC xD
            // |
            // ↓
            if (!Config.IsEnabled)
                return;
            Instance = this;
            EventManager.RegisterEvents<EventHandlers>(this);
            Log.Raw($"<color=blue>Loading {Name} {Version} by {Author}</color>");
            var handler = PluginHandler.Get(this);
            handler.SaveConfig(this, nameof(Config));
        }
    }
}
