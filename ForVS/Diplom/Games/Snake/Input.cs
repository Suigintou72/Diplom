using System.Collections;
using System.Windows.Forms;

namespace Snake
{
    internal class Input
    {
        //Загрузить список доступных кнопок клавиатуры
        private static Hashtable keyTable = new Hashtable();

        //Выполните проверку, чтобы увидеть, нажата ли конкретная кнопка
        public static bool KeyPressed(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
            }

            return (bool) keyTable[key];
        }

        //Определить, нажата ли кнопка клавиатуры
        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
