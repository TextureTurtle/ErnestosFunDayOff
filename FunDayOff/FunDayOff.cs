using OWML.Common;
using OWML.ModHelper;


namespace FunDayOff
{

    public class FunDayOff : ModBehaviour
    {
        public FunElevator FunEL;

        private void Awake()
        {
            // You won't be able to access OWML's mod helper in Awake.
            // So you probably don't want to do anything here.
            // Use Start() instead.
        }

        private void Start()
        {

            // Starting here, you'll have access to OWML's mod helper.
            ModHelper.Console.WriteLine($"My mod {nameof(FunDayOff)} is loaded!", MessageType.Success);

            // Get the New Horizons API and load configs
            var newHorizons = ModHelper.Interaction.TryGetModApi<INewHorizons>("xen.NewHorizons");
            newHorizons.LoadConfigs(this);

            // Example of accessing game code.
            LoadManager.OnCompleteSceneLoad += (scene, loadScene) =>
            {
                if (loadScene != OWScene.SolarSystem) return;
                ModHelper.Console.WriteLine("Loaded into solar system!", MessageType.Success);
            };
        }
        public override void Configure(IModConfig config)
        {
            // Slider

            FunElevator.SliderValue = config.GetSettingsValue<int>("FUN Slider"); // Elevator


            //  Button

            SpamDoor.IsOn = config.GetSettingsValue<bool>("FUN Button"); // Elevator Code 1


            // Text Box

            WordBridge.Words = config.GetSettingsValue<string>("Typing Time!!!"); // Elevator Code 1


            //#===============#
            //#     Code      #
            //#===============#

            CodeDoor.Code1 = config.GetSettingsValue<string>("Code 1"); // Elevator Code 1
            CodeDoor.Code2 = config.GetSettingsValue<string>("Code 2"); // Elevator Code 2
            CodeDoor.Code3 = config.GetSettingsValue<string>("Code 3"); // Elevator Code 3
            CodeDoor.Code4 = config.GetSettingsValue<string>("Code 4"); // Elevator Code 4
            CodeDoor.Code5 = config.GetSettingsValue<string>("Code 5"); // Elevator Code 5

        }
    }
}

