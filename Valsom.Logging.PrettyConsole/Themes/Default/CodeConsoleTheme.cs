using System.Drawing;

using Valsom.Logging.PrettyConsole.Themes.Abstractions;

namespace Valsom.Logging.PrettyConsole.Themes.Default
{
    /// <summary>
    /// A theme similar to the colors used in Visual Studio Code
    /// </summary>
    public class CodeConsoleTheme : IConsoleTheme
    {
        /// <inheritdoc />
        public Color Background => Color.FromArgb(15, 17, 26);

        /// <inheritdoc />
        public Color Foreground => Color.FromArgb(143, 147, 162);

        /// <inheritdoc />
        public Color SecondaryText => Color.FromArgb(70, 75, 93);

        /// <inheritdoc />
        public Color Punctuation => SecondaryText;

        /// <inheritdoc />
        public Color Critical => Color.FromArgb(199, 144, 234);

        /// <inheritdoc />
        public Color Error => Color.FromArgb(240, 113, 120);

        /// <inheritdoc />
        public Color Warning => Color.FromArgb(247, 140, 108);

        /// <inheritdoc />
        public Color Information => Color.FromArgb(137, 221, 255);

        /// <inheritdoc />
        public Color Debug => Foreground;

        /// <inheritdoc />
        public Color Trace => SecondaryText;
    }
}