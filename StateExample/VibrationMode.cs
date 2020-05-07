using System;

namespace StateExample
{
    /// <summary>
    /// Режим "Вибрация"
    /// </summary>
    public class VibrationMode : SoundMode
    {
        private static string name = "Vibration";

        public string getName()
        {
            return name;
        }

        public void setOnClick(SoundModeContext context)
        {
            context.setContext(new SoundOnMode());
        }

        public void doClickSound()
        {
            Console.WriteLine("bzzzzz");
        }
    }
}