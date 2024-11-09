using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
#pragma warning disable CA1416 // Validate platform compatibility
namespace obrazek_2024_10_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Bitmap bitmap = (Bitmap)Image.FromFile(@"C:\Users\Hubert\source\repos\ZTP_1\1.jpg");
            Bitmap bitmap2 = new Bitmap(bitmap.Width, bitmap.Height);

            Bitmap bitmap3 = (Bitmap)Image.FromFile(@"C:\Users\Hubert\source\repos\ZTP_1\2.jpg");
            Bitmap bitmap4 = new Bitmap(bitmap3.Width, bitmap3.Height);

            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int y = 0; y < bitmap.Height; y++)
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color oldColor = bitmap.GetPixel(x, y);
                    int r = (int)(0.75 * oldColor.R);
                    int g = (int)(0.75 * oldColor.G);
                    int b = (int)(0.75 * oldColor.B);

                    bitmap2.SetPixel(x, y, Color.FromArgb(r, g, b));

                }

            sw.Stop();
            bitmap2.Save(@"C:\Users\Hubert\source\repos\ZTP_1\photo1.png", ImageFormat.Jpeg);
            Console.WriteLine(sw.Elapsed);
        }
    }
}