using System;

namespace StateExample
{
    /// <summary>
    /// Режим "со звуком"
    /// </summary>
    public class SoundOnMode : SoundMode
    {
        private static string name = "Sound ON";
        public string getName()
        {
            return name;
        }

        public void setOnClick(SoundModeContext context)
        {
            context.setContext(new SoundOffMode());
        }

        public void doClickSound()
        {
            Console.WriteLine("SOUND");
        }
    }
}