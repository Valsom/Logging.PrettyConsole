using System.Drawing;

using Valsom.Logging.PrettyConsole.Themes.Abstractions;

namespace Valsom.Logging.PrettyConsole.Themes.Default
{
    /// <summary>
    /// Implementation of the Eva Light theme for Visual Studio Code
    /// </summary>
    public class EvaLightTheme : IConsoleTheme
    {
        internal EvaLightTheme()
        {

        }

        /// <inheritdoc />
        public Color Background => Color.FromArgb(225, 228, 235);

        /// <inheritdoc />
        public Color Foreground => Color.FromArgb(93, 93, 95);

        /// <inheritdoc />
        public Color SecondaryText => Color.FromArgb(142, 142, 144);

        /// <inheritdoc />
        public Color Punctuation => Color.FromArgb(169, 169, 170);

        /// <inheritdoc />
        public Color Critical => Color.FromArgb(200, 56, 198);

        /// <inheritdoc />
        public Color Error => Color.FromArgb(205, 96, 105);

        /// <inheritdoc />
        public Color Warning => Color.FromArgb(255, 101, 0);

        /// <inheritdoc />
        public Color Information => Color.FromArgb(67, 122, 237);

        /// <inheritdoc />
        public Color Debug => Color.FromArgb(0, 190, 196);

        /// <inheritdoc />
        public Color Trace => Color.FromArgb(93, 93, 95);
    }
}
