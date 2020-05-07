using System;

namespace StateExample
{
    /// <summary>
    /// Режим звука
    /// </summary>
    public interface SoundMode
    {
        /// <summary>
        /// Возвращает название текущего режима
        /// </summary>
        /// <returns></returns>
        String getName();

        /// <summary>
        /// Сменить текущий режим на следующий
        /// </summary>
        /// <param name="context">текущий режим</param>
        void setOnClick(SoundModeContext context);

        /// <summary>
        /// Проиграть звук
        /// </summary>
        void doClickSound();
    }
}