using System;

namespace StateExample
{
    /// <summary>
    /// Режим "Без звука"
    /// </summary>
    public class SoundOffMode : SoundMode
    {
        private static string name = "Sound OFF";
        public string getName()
        {
            return name;
        }

        public void setOnClick(SoundModeContext context)
        {
            context.setContext(new VibrationMode());
        }

        public void doClickSound()
        {
            Console.WriteLine("...");
        }
    }
}