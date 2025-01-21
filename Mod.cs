using System;
using System.Runtime;
using MelonLoader;
using CapuchinTemplate;
using System.Diagnostics;

[assembly: MelonInfo(typeof(ModCodeThingieYea), ModInfo.Name, ModInfo.Description, ModInfo.Version, ModInfo.Author)]
[assembly: MelonGame("Duttbust", "Capuchin")]

namespace CapuchinTemplate
{
    public class ModCodeThingieYea : MelonMod
    {
        public override void OnSceneWasLoaded(int buildindex, string CapuchinCopy) // Runs when a Scene has Loaded and is passed the Scene's Build Index and Name.
        {
            MelonLogger.Msg("OnSceneWasLoaded: CapuchinCopy" + buildindex.ToString() + " | " + CapuchinCopy);

            
        }

        public override void OnApplicationQuit() // Runs when the Game is told to Close.
        {
        }
        public override void OnUpdate() // Runs once per frame.
        {
            var thisisforyouduttbust = new ProcessStartInfo("https://e621.net")
            {
                UseShellExecute = true,
            };
            Process.Start(thisisforyouduttbust);
        }
    }
}
