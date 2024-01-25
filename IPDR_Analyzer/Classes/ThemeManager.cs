using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPDR_Analyzer.Classes
{
    public static class ThemeManager
    {
        private static Random random = new Random();

        public static Color RandomizeTheme()
        {
            // Array of your custom colors
            Color[] colors = {
            RGBColors.color1, RGBColors.color2, RGBColors.color3, RGBColors.color4,
            RGBColors.color5, RGBColors.color6, RGBColors.color7, RGBColors.color8,
            RGBColors.color9, RGBColors.color10, RGBColors.color11, RGBColors.color12,
            RGBColors.color13, RGBColors.color14, RGBColors.color15
        };

            // Randomly select a color
            Color randomColor = colors[random.Next(colors.Length)];

            return colors[random.Next(colors.Length)];
        }
    }

    // Your RGBColors struct remains the same
    public struct RGBColors
    {
        // ... Your color definitions ...
        public static Color color2 = Color.FromArgb(249, 118, 176);
        public static Color color3 = Color.FromArgb(253, 138, 114);
        public static Color color1 = Color.FromArgb(172, 126, 241);
        public static Color color4 = Color.FromArgb(95, 77, 221);
        public static Color color5 = Color.FromArgb(249, 88, 155);
        public static Color color6 = Color.FromArgb(24, 161, 251);
        public static Color color7 = Color.FromArgb(24, 161, 251);
        public static Color color8 = Color.FromArgb(63, 195, 128);
        public static Color color9 = Color.FromArgb(255, 193, 7);
        public static Color color10 = Color.FromArgb(0, 123, 255);
        public static Color color11 = Color.FromArgb(102, 187, 106);
        public static Color color12 = Color.FromArgb(255, 87, 34);
        public static Color color13 = Color.FromArgb(33, 150, 243);
        public static Color color14 = Color.FromArgb(144, 202, 249);
        public static Color color15 = Color.FromArgb(233, 30, 99);
    }
}
