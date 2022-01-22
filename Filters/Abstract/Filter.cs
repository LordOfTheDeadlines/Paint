using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor.Filters
{
    abstract class Filter
    {
        public Bitmap ChangeBitmapImage(Bitmap image)
        {
            for (int y = 0; y < image.Height; y++)
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    Color newColor = ChangePixelColor(pixelColor);
                    image.SetPixel(x, y, newColor);
                }
            return image;
        }
        public abstract Color ChangePixelColor(Color imagePixelColor);
    }
}
