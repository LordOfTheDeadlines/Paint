using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor.Filters.Implementation
{
    class SepiaFilter : Filter
    {
        public override Color ChangePixelColor(Color imagePixelColor)
        {
            var averageValue = (imagePixelColor.R + imagePixelColor.B + imagePixelColor.G) / 3;
            return Color.FromArgb(averageValue, (int)(averageValue * 0.95), (int)(averageValue * 0.82));
        }
    }
}
