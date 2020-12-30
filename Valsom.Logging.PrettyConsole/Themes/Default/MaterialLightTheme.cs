using System.Drawing;

using Valsom.Logging.PrettyConsole.Themes.Abstractions;

namespace Valsom.Logging.PrettyConsole.Themes.Default
{
    /// <summary>
    /// Implementation of the Material Theme Lighter theme for Visual Studio Code
    /// </summary>
    public class MaterialLightTheme : IConsoleTheme
    {
        /// <inheritdoc />
        public Color Background => Color.FromArgb(250, 250, 250);

        /// <inheritdoc />
        public Color Foreground => Color.FromArgb(126, 147, 158);

        /// <inheritdoc />
        public Color SecondaryText => Color.FromArgb(144, 164, 174);

        /// <inheritdoc />
        public Color Punctuation => Color.FromArgb(144, 164, 174);

        /// <inheritdoc />
        public Color Critical => Color.FromArgb(156, 62, 218);

        /// <inheritdoc />
        public Color Error => Color.FromArgb(229, 57, 53);

        /// <inheritdoc />
        public Color Warning => Color.FromArgb(247, 109, 71);

        /// <inheritdoc />
        public Color Information => Color.FromArgb(57, 173, 181);

        /// <inheritdoc />
        public Color Debug => Color.FromArgb(97, 130, 184);

        /// <inheritdoc />
        public Color Trace => Color.FromArgb(144, 164, 174);
    }
}
