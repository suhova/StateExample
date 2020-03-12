using System;

namespace StateExample
{
    /// <summary>
    /// Класс для демонстрации работы кнопки режима звука в приложении
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в приложение
        /// </summary>
        static void Main(string[] args)
        {
            SoundModeContext soundModeContext = new SoundModeContext();

            Console.WriteLine("Отображаемая кнопка: " + soundModeContext.getModeName());
            Console.WriteLine("Звук: ");
            soundModeContext.doClickSound();
            soundModeContext.setOnClick();
            
            Console.WriteLine("Отображаемая кнопка: " + soundModeContext.getModeName());
            Console.WriteLine("Звук: ");
            soundModeContext.doClickSound();
            soundModeContext.setOnClick();
            
            Console.WriteLine("Отображаемая кнопка: " + soundModeContext.getModeName());
            Console.WriteLine("Звук: ");
            soundModeContext.doClickSound();
            soundModeContext.setOnClick();
            
            Console.WriteLine("Отображаемая кнопка: " + soundModeContext.getModeName());
            Console.WriteLine("Звук: ");
            soundModeContext.doClickSound();
        }
    }
}