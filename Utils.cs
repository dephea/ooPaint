using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOOP
{
    public static class Utils
    {

        public static bool isHost;

        public static void SetupButtonImage(Button button, Image image) {
            Image resizedImage = new Bitmap(image, button.Size);

            button.Image = resizedImage;


        }
    }
}
