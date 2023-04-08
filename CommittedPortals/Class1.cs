using BepInEx;
using HarmonyLib;

namespace CommittedPortals
{
    [BepInPlugin(Guid, ModName, Version)]
    public class Plugin : BaseUnityPlugin
    {
        public const string Version = "1.0.0";
        public const string ModName = "CommittedPortals";
        public const string Guid = "no.fyren.committedportals";

        public readonly Harmony Harmony = new Harmony(Guid);

        private void Awake()
        {
            // todo
        }
    }
}