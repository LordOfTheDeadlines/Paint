using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor
{
    class RotationAlgorithms
    {
        public static Bitmap Rotate(Bitmap image, float angle)
        {
            var bmp = new Bitmap(image.Width, image.Height);

            var w = (image.Width & 1) == 0 ? image.Width + 1 : image.Width;
            var h = (image.Height & 1) == 0 ? image.Height + 1 : image.Height;
            var center = new Point(w / 2, h / 2);
            var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);

            using (var m = new System.Drawing.Drawing2D.Matrix())
            {
                Point[] pts = new Point[1];
                m.Translate(center.X, center.Y);
                m.Rotate(-angle);
                for (int x = 0; x < image.Width; x++)
                    for (int y = 0; y < image.Height; y++)
                    {
                        pts[0] = new Point((x - center.X), (y - center.Y));
                        m.TransformPoints(pts);
                        if (!rect.Contains(pts[0]))
                            continue;
                        bmp.SetPixel(x, y, image.GetPixel(pts[0].X, pts[0].Y));
                    }
            }

            return bmp;// Unscale(bmp, 2);
        }
    }
}
