using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditor.Filters.Implementation
{
    class BlackWhiteFilter : Filter
    {
        public override Color ChangePixelColor(Color imagePixelColor)
        {
            var averageValue = (imagePixelColor.R + imagePixelColor.B + imagePixelColor.G) / 3;
            return Color.FromArgb(averageValue, averageValue, averageValue);
        }
    }
}
