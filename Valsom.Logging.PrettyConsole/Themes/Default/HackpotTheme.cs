using System.Drawing;

using Valsom.Logging.PrettyConsole.Themes.Abstractions;
using Valsom.Logging.PrettyConsole.Themes.Helper;

namespace Valsom.Logging.PrettyConsole.Themes.Default
{
    /// <summary>
    /// Implementation of the Hackpot Under The Sea theme for Visual Studio Code
    /// </summary>
    public class HackpotTheme : IConsoleTheme
    {
        internal HackpotTheme()
        {

        }

        /// <inheritdoc />
        public Color Background => "#003030".ToColor();

        /// <inheritdoc />
        public Color Foreground => "#B1E7B1".ToColor();

        /// <inheritdoc />
        public Color SecondaryText => "#cbe4cb".ToColor();

        /// <inheritdoc />
        public Color Punctuation => "#8E8E8E".ToColor();

        /// <inheritdoc />
        public Color Critical => "#E56697".ToColor();

        /// <inheritdoc />
        public Color Error => "#32CD32".ToColor();

        /// <inheritdoc />
        public Color Warning => "#FFB84D".ToColor();

        /// <inheritdoc />
        public Color Information => "#1FADA6".ToColor();

        /// <inheritdoc />
        public Color Debug => "#B1E7B1".ToColor();

        /// <inheritdoc />
        public Color Trace => "#1E621E".ToColor();
    }
}
