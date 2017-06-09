using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesctopApi
{
    class GlobalVariables
    {
        // <summary>
        // Картинка на столе
        // 1. Подогнать под размер
        // 2. Реальный размер
        // 3. Плитка
        // </summary>
        public enum ReplacePicture { Stretch =1, ActualSize, Tile }
        public static ReplacePicture rpWayChange;

        // <summary>
        // Версия ОС
        // </summary>
        public enum OSVersion { XP =5, Newer=6 };
        public static OSVersion osVersion;

        // <summary>
        // Для операционной системы XP.
        // Путь к  файлу-источнику картинки рабочего стола,
        // (прописан в реестре HKEY_CURRENT_USER\Control Panel\Desktop\ConvertedWallpaper)
        // Windows XP создает копию этого файла в формате .bmp,
        // При просмотре свойств рабочего стола отображается именно эта картинка.
        // </summary>
        public static string strConvertedWallpaperPath = null;

        // <summary>
        //Путь к текущему файлу картинки на рабочем столе прописанный в реестре.
        // </summary>
        public static string strWallPaperPath = null;

        // <summary>
        // Список имен картинок выбранного каталога.
        // </summary>
        public static List<string> listPictures = new List<string>();

        // <summary>
        // Автоматическая смена картинок рабочего стола.
        // </summary>
        public static bool bAutoChange = false;

        // <summary>
        // Выбор файлов в каталоге.
        // Случайный метод выбора файлов если true,
        // Последовательный если false.
        // </summary>
        public static bool bRandomSelection = false;

        // <summary>
        // Смена картинки для рабочего стола при загрузке Windows - true
        // Через определенный промежуток времени - false.
        // </summary>
        public static bool bLoadChange = true;

        // <summary>
        // Временный промежуток между сменой картинок, по умолчанию 1 минута.
        // </summary>
        public static int iWantChange = 1000 * 60;

        // <summary>
        // Показ сообщений об ошибке при отлкадке - true,
        // Непоказ - false. 
        // </summary>
        const bool debugState = false;

        // <summary>
        // Показывает пользователю сообщение об ошибке.
        // </summary>
 /*       public static void DebugMessage (string message)
        {
            if (debugState == true)
                MetroFramework.MetroMessageBox.Show("Error " + message);
        }*/
    }
}
