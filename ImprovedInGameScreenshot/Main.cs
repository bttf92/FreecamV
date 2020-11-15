using System.Windows.Forms;

using GTA;

namespace FreecamV
{
    public class Main : Script
    {
        public Main()
        {
            // Load all of the config values from ini
            Config.DefaultSpeed = Settings.GetValue("Settings", "Speed", 0.5f);
            Config.ShiftSpeed = Settings.GetValue("Settings", "BoostSpeed", 4.0f);
            Config.FilterIntensity = Settings.GetValue("Settings", "FilterIntensity", 1.0f);            
            Config.Precision = Settings.GetValue("Settings", "Precision", 1.0f);
            Config.SlowMotionMultiplier = Settings.GetValue("Settings", "SlowMotionMult", 8.5f);

            Freecam.Initialize();

            // Input handling
            KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Settings.GetValue("Keys", "Toggle", Keys.J))
                    Freecam.Toggle();
            };
            // Ticking for freecam
            Tick += (sender, e) =>
            {
                Freecam.Tick();
            };
        }
    }
}
