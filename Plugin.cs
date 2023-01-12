namespace Infinity_Radio
{
    using HarmonyLib;
    using PluginAPI.Core;
    using PluginAPI.Core.Attributes;
    using PluginAPI.Enums;
    using PluginAPI.Events;
    public class Plugin
    {
        public const string Name = "Infinity Radio";
        public const string Version = "v1.0.1";
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
            var Harmory = new Harmony("Infinity Radio");
            Harmory.PatchAll();
            Log.Info("Infinity Radio ON");
            handler.SaveConfig(this, nameof(Config));
        }
    }
}