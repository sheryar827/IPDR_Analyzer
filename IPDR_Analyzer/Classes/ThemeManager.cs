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
    RGBColors.color1,
    RGBColors.color2,
    RGBColors.color3,
    RGBColors.color4,
    RGBColors.color5,
    RGBColors.color6,
    RGBColors.color7,
    RGBColors.color8,
    RGBColors.color9,
    RGBColors.color10
    /*RGBColors.color11,
    RGBColors.color12,
    RGBColors.color13,
    RGBColors.color14,
    RGBColors.color15,
    RGBColors.color16,
    RGBColors.color17,
    RGBColors.color18,
    RGBColors.color19,
    RGBColors.color20,
    RGBColors.color21,
    RGBColors.color22,
    RGBColors.color23,
    RGBColors.color24,
    RGBColors.color25,
    RGBColors.color26,
    RGBColors.color27,
    RGBColors.color28,
    RGBColors.color29,
    RGBColors.color30,
    RGBColors.color31,
    RGBColors.color32,
    RGBColors.color33,
    RGBColors.color34,
    RGBColors.color35,
    RGBColors.color36,
    RGBColors.color37,
    RGBColors.color38,
    RGBColors.color39,
    RGBColors.color40,
    RGBColors.color41,
    RGBColors.color42,
    RGBColors.color43,
    RGBColors.color44,
    RGBColors.color45,
    RGBColors.color46,
    RGBColors.color47,
    RGBColors.color48,
    RGBColors.color49,
    RGBColors.color50,
    RGBColors.color51,
    RGBColors.color52,
    RGBColors.color53,
    RGBColors.color54,
    RGBColors.color55,
    RGBColors.color56,
    RGBColors.color57,
    RGBColors.color58,
    RGBColors.color59,
    RGBColors.color60,
    RGBColors.color61,
    RGBColors.color62,
    RGBColors.color63,
    RGBColors.color64,
    RGBColors.color65,
    RGBColors.color66,
    RGBColors.color67,
    RGBColors.color68,
    RGBColors.color69,
    RGBColors.color70,
    RGBColors.color71,
    RGBColors.color72,
    RGBColors.color73,
    RGBColors.color74,
    RGBColors.color75,
    RGBColors.color76,
    RGBColors.color77,
    RGBColors.color78,
    RGBColors.color79,
    RGBColors.color80,
    RGBColors.color81,
    RGBColors.color82,
    RGBColors.color83,
    RGBColors.color84,
    RGBColors.color85,
    RGBColors.color86,
    RGBColors.color87,
    RGBColors.color88,
    RGBColors.color89,
    RGBColors.color90,
    RGBColors.color91,
    RGBColors.color92,
    RGBColors.color93,
    RGBColors.color94,
    RGBColors.color95,
    RGBColors.color96,
    RGBColors.color97,
    RGBColors.color98,
    RGBColors.color99,
    RGBColors.color100,
    RGBColors.color101,
    RGBColors.color102,
    RGBColors.color103,
    RGBColors.color104,
    RGBColors.color105,
    RGBColors.color106,
    RGBColors.color107,
    RGBColors.color108,
    RGBColors.color109,
    RGBColors.color110,
    RGBColors.color111,
    RGBColors.color112,
    RGBColors.color113,
    RGBColors.color114,
    RGBColors.color115*/
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
        /*public static Color color11 = Color.FromArgb(102, 187, 106);
        public static Color color12 = Color.FromArgb(255, 87, 34);
        public static Color color13 = Color.FromArgb(33, 150, 243);
        public static Color color14 = Color.FromArgb(144, 202, 249);
        public static Color color15 = Color.FromArgb(233, 30, 99);
        public static Color color16 = Color.FromArgb(128, 172, 166);
        public static Color color17 = Color.FromArgb(41, 31, 61);
        public static Color color18 = Color.FromArgb(84, 250, 245);
        public static Color color19 = Color.FromArgb(179, 77, 186);
        public static Color color20 = Color.FromArgb(151, 204, 38);
        public static Color color21 = Color.FromArgb(253, 87, 222);
        public static Color color22 = Color.FromArgb(115, 56, 213);
        public static Color color23 = Color.FromArgb(115, 42, 66);
        public static Color color24 = Color.FromArgb(50, 231, 199);
        public static Color color25 = Color.FromArgb(22, 5, 93);
        public static Color color26 = Color.FromArgb(111, 50, 173);
        public static Color color27 = Color.FromArgb(47, 23, 229);
        public static Color color28 = Color.FromArgb(112, 94, 48);
        public static Color color29 = Color.FromArgb(159, 83, 77);
        public static Color color30 = Color.FromArgb(74, 4, 1);
        public static Color color31 = Color.FromArgb(144, 39, 10);
        public static Color color32 = Color.FromArgb(120, 0, 82);
        public static Color color33 = Color.FromArgb(3, 78, 136);
        public static Color color34 = Color.FromArgb(27, 124, 123);
        public static Color color35 = Color.FromArgb(142, 120, 185);
        public static Color color36 = Color.FromArgb(205, 218, 207);
        public static Color color37 = Color.FromArgb(188, 181, 63);
        public static Color color38 = Color.FromArgb(79, 229, 128);
        public static Color color39 = Color.FromArgb(158, 65, 90);
        public static Color color40 = Color.FromArgb(108, 12, 5);
        public static Color color41 = Color.FromArgb(11, 0, 187);
        public static Color color42 = Color.FromArgb(110, 245, 202);
        public static Color color43 = Color.FromArgb(217, 206, 92);
        public static Color color44 = Color.FromArgb(76, 249, 208);
        public static Color color45 = Color.FromArgb(139, 160, 105);
        public static Color color46 = Color.FromArgb(236, 47, 113);
        public static Color color47 = Color.FromArgb(154, 116, 37);
        public static Color color48 = Color.FromArgb(154, 126, 48);
        public static Color color49 = Color.FromArgb(77, 166, 139);
        public static Color color50 = Color.FromArgb(241, 217, 106);
        public static Color color51 = Color.FromArgb(211, 38, 215);
        public static Color color52 = Color.FromArgb(140, 164, 44);
        public static Color color53 = Color.FromArgb(152, 5, 237);
        public static Color color54 = Color.FromArgb(174, 49, 123);
        public static Color color55 = Color.FromArgb(124, 229, 139);
        public static Color color56 = Color.FromArgb(64, 118, 216);
        public static Color color57 = Color.FromArgb(183, 29, 72);
        public static Color color58 = Color.FromArgb(191, 83, 85);
        public static Color color59 = Color.FromArgb(130, 125, 39);
        public static Color color60 = Color.FromArgb(12, 127, 95);
        public static Color color61 = Color.FromArgb(62, 136, 136);
        public static Color color62 = Color.FromArgb(167, 186, 38);
        public static Color color63 = Color.FromArgb(194, 237, 163);
        public static Color color64 = Color.FromArgb(12, 240, 50);
        public static Color color65 = Color.FromArgb(229, 233, 187);
        public static Color color66 = Color.FromArgb(149, 62, 35);
        public static Color color67 = Color.FromArgb(107, 196, 24);
        public static Color color68 = Color.FromArgb(85, 5, 104);
        public static Color color69 = Color.FromArgb(247, 140, 169);
        public static Color color70 = Color.FromArgb(244, 128, 223);
        public static Color color71 = Color.FromArgb(193, 128, 80);
        public static Color color72 = Color.FromArgb(174, 150, 33);
        public static Color color73 = Color.FromArgb(94, 5, 157);
        public static Color color74 = Color.FromArgb(227, 174, 102);
        public static Color color75 = Color.FromArgb(200, 100, 255);
        public static Color color76 = Color.FromArgb(89, 193, 37);
        public static Color color77 = Color.FromArgb(246, 80, 31);
        public static Color color78 = Color.FromArgb(232, 102, 33);
        public static Color color79 = Color.FromArgb(158, 98, 66);
        public static Color color80 = Color.FromArgb(213, 35, 154);
        public static Color color81 = Color.FromArgb(245, 19, 86);
        public static Color color82 = Color.FromArgb(129, 82, 145);
        public static Color color83 = Color.FromArgb(186, 246, 44);
        public static Color color84 = Color.FromArgb(132, 153, 191);
        public static Color color85 = Color.FromArgb(147, 22, 231);
        public static Color color86 = Color.FromArgb(239, 37, 23);
        public static Color color87 = Color.FromArgb(254, 205, 219);
        public static Color color88 = Color.FromArgb(182, 96, 122);
        public static Color color89 = Color.FromArgb(117, 198, 170);
        public static Color color90 = Color.FromArgb(54, 81, 80);
        public static Color color91 = Color.FromArgb(230, 189, 82);
        public static Color color92 = Color.FromArgb(173, 235, 24);
        public static Color color93 = Color.FromArgb(200, 32, 98);
        public static Color color94 = Color.FromArgb(53, 132, 73);
        public static Color color95 = Color.FromArgb(156, 234, 118);
        public static Color color96 = Color.FromArgb(24, 129, 178);
        public static Color color97 = Color.FromArgb(112, 67, 221);
        public static Color color98 = Color.FromArgb(105, 155, 85);
        public static Color color99 = Color.FromArgb(164, 42, 42);
        public static Color color100 = Color.FromArgb(189, 8, 84);
        public static Color color101 = Color.FromArgb(197, 83, 113);
        public static Color color102 = Color.FromArgb(244, 93, 124);
        public static Color color103 = Color.FromArgb(31, 219, 191);
        public static Color color104 = Color.FromArgb(86, 203, 73);
        public static Color color105 = Color.FromArgb(233, 129, 168);
        public static Color color106 = Color.FromArgb(183, 225, 97);
        public static Color color107 = Color.FromArgb(215, 133, 209);
        public static Color color108 = Color.FromArgb(108, 35, 250);
        public static Color color109 = Color.FromArgb(145, 175, 192);
        public static Color color110 = Color.FromArgb(201, 153, 230);
        public static Color color111 = Color.FromArgb(115, 0, 103);
        public static Color color112 = Color.FromArgb(10, 85, 61);
        public static Color color113 = Color.FromArgb(206, 135, 118);
        public static Color color114 = Color.FromArgb(197, 111, 34);
        public static Color color115 = Color.FromArgb(129, 230, 95);*/
    }
}
