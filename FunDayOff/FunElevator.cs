using OWML.Common;
using OWML.ModHelper;

namespace FunDayOff
{

    public class FunElevator : ModBehaviour
    {
        public override void Configure(IModConfig config)
        {
            var newFavorite = config.GetSettingsValue<string>("FUN Slider");
            ModHelper.Console.WriteLine($"Elevator moved too: {newFavorite}!");
        }
    }
}