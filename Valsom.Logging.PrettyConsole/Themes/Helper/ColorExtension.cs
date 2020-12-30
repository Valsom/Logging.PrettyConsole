using System;
using System.Drawing;

namespace Valsom.Logging.PrettyConsole.Themes.Helper
{
    internal static class ColorExtension
    {
        public static Color ToColor(this ConsoleColor color)
        {
            switch (color)
            {
                case ConsoleColor.Black:
                    return Color.Black;
                case ConsoleColor.Blue:
                    return Color.Blue;
                case ConsoleColor.Cyan:
                    return Color.Cyan;
                case ConsoleColor.DarkBlue:
                    return Color.DarkBlue;
                case ConsoleColor.DarkGray:
                    return Color.DarkGray;
                case ConsoleColor.DarkGreen:
                    return Color.DarkGreen;
                case ConsoleColor.DarkMagenta:
                    return Color.DarkMagenta;
                case ConsoleColor.DarkRed:
                    return Color.DarkRed;
                case ConsoleColor.DarkYellow:
                    return Color.FromArgb(255, 128, 128, 0);
                case ConsoleColor.Gray:
                    return Color.Gray;
                case ConsoleColor.Green:
                    return Color.Green;
                case ConsoleColor.Magenta:
                    return Color.Magenta;
                case ConsoleColor.Red:
                    return Color.Red;
                case ConsoleColor.White:
                    return Color.White;
                case ConsoleColor.DarkCyan:
                    return Color.DarkCyan;
                case ConsoleColor.Yellow:
                    return Color.Yellow;
                default:
                    return Color.White;
            }
        }

        public static Color ToColor(this string hex)
        {
            hex = hex.Replace("#", string.Empty);
            byte r = (byte)Convert.ToUInt32(hex.Substring(0, 2), 16);
            byte g = (byte)Convert.ToUInt32(hex.Substring(2, 2), 16);
            byte b = (byte)Convert.ToUInt32(hex.Substring(4, 2), 16);

            return Color.FromArgb(r, g, b);
        }
    }
}