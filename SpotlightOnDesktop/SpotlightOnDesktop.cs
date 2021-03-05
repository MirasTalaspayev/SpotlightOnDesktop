using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotlightOnDesktop
{
    class SpotlightOnDesktop
    {
        private static string srcpath = @"C:\Users\" + Environment.UserName + @"\AppData\Local\Packages\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\LocalState\Assets";

        private static string[] images = Directory.GetFiles(srcpath);
        private static int index { get; set; } = 0;
        public static bool ChangeDesktopImage()
        {
            Image bitmap = new Bitmap(images[index]);
            bool isImage = true;
            try
            {
                isImage = bitmap.Width == 1920;
            }
            catch (ArgumentException)
            {
                isImage = false;
            }
            
            if (isImage)
                Wallpaper.SystemParametersInfo(20, 0, images[index], 0x01 | 0x02);
            bitmap.Dispose();
            return isImage;
        }
        public static void NextImage()
        {
            index++;
            if (index == images.Length) index = 0;
        }
        public static int GetIndex() => index;
    }
}
