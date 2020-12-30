using System.Drawing;

using Valsom.Logging.PrettyConsole.Themes.Abstractions;

namespace Valsom.Logging.PrettyConsole.Themes.Default
{
    /// <summary>
    /// Implementation of the Pop N' Lock theme for Visual Studio Code
    /// </summary>
    public class PopAndLockTheme : IConsoleTheme
    {
        internal PopAndLockTheme()
        {

        }

        /// <inheritdoc />
        public Color Background => Color.FromArgb(28, 28, 44);

        /// <inheritdoc />
        public Color Foreground => Color.FromArgb(184, 171, 139);

        /// <inheritdoc />
        public Color SecondaryText => Color.FromArgb(156, 115, 66);

        /// <inheritdoc />
        public Color Punctuation => Color.FromArgb(33, 115, 143);

        /// <inheritdoc />
        public Color Critical => Color.FromArgb(204, 102, 136);

        /// <inheritdoc />
        public Color Error => Color.FromArgb(238, 51, 85);

        /// <inheritdoc />
        public Color Warning => Color.FromArgb(255, 204, 85);

        /// <inheritdoc />
        public Color Information => Color.FromArgb(33, 115, 143);

        /// <inheritdoc />
        public Color Debug => Color.FromArgb(102, 170, 97);

        /// <inheritdoc />
        public Color Trace => Color.FromArgb(95, 95, 62);
    }
}
