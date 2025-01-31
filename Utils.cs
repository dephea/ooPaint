using System.Drawing;
using System.Windows.Forms;

namespace ProjectOOP
{
    public static class Utils
    {

        public static bool isHost;

        public static void SetupButtonImage(Button button, Image image)
        {
            Image resizedImage = new Bitmap(image, button.Size);

            button.Image = resizedImage;


        }
    }
}
