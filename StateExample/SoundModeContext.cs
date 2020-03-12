namespace StateExample
{
    /// <summary>
    /// Класс - хранящий текущий звуковой режим и
    /// описывающий методы для работы со звуком
    /// </summary>
    public class SoundModeContext
    {
        private SoundMode soundMode = new SoundOnMode();
        /// <summary>
        /// Издать звук/вибрацию/ничего
        /// </summary>
        public void doClickSound()
        {
            soundMode.doClickSound();
        }
        /// <summary>
        /// Получить название текущего режима для отображения
        /// </summary>
        /// <returns>Название режима</returns>
        public string getModeName()
        {
            return soundMode.getName();
        }
        /// <summary>
        ///Сменить режим на следующий
        /// </summary>
        public void setOnClick()
        {
            soundMode.setOnClick(this);
        }
        /// <summary>
        ///Изменить текущий режим звука на другой
        /// </summary>
        /// <param name="mode">Новый режим звука</param>
        public void setContext(SoundMode mode)
        {
            soundMode = mode;
        }
        /// <summary>
        /// Получить текущий режим звука
        /// </summary>
        /// <returns></returns>
        public SoundMode getContext()
        {
            return soundMode;
        }
    }
}