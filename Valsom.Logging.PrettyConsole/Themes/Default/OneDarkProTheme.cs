using System.Drawing;

using Valsom.Logging.PrettyConsole.Themes.Abstractions;
using Valsom.Logging.PrettyConsole.Themes.Helper;

namespace Valsom.Logging.PrettyConsole.Themes.Default
{
    /// <summary>
    /// Implementation of the One Dark Pro theme for Visual Studio Code
    /// </summary>
    public class OneDarkProTheme : IConsoleTheme
    {
        internal OneDarkProTheme()
        {

        }

        /// <inheritdoc />
        public Color Background => "#282c34".ToColor();

        /// <inheritdoc />
        public Color Foreground => "#dcdcdc".ToColor();

        /// <inheritdoc />
        public Color SecondaryText => "#ABB2BF".ToColor();

        /// <inheritdoc />
        public Color Punctuation => "#7F848E".ToColor();

        /// <inheritdoc />
        public Color Critical => "#C678DD".ToColor();

        /// <inheritdoc />
        public Color Error => "#E06C75".ToColor();

        /// <inheritdoc />
        public Color Warning => "#D19A66".ToColor();

        /// <inheritdoc />
        public Color Information => "#61AFEF".ToColor();

        /// <inheritdoc />
        public Color Debug => "#56B6C2".ToColor();

        /// <inheritdoc />
        public Color Trace => "#7F848E".ToColor();
    }
}
