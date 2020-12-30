using System.Drawing;
using Microsoft.Extensions.Logging;

namespace Valsom.Logging.PrettyConsole.Themes.Abstractions
{
    /// <summary>
    /// A theme used for coloring the console
    /// </summary>
    public interface IConsoleTheme
    {
        /// <summary>
        /// The background color
        /// </summary>
        Color Background { get; }

        /// <summary>
        /// Normal text color
        /// </summary>
        Color Foreground { get; }

        /// <summary>
        /// Secondary text color
        /// </summary>
        Color SecondaryText { get; }

        /// <summary>
        /// Punctuation color
        /// </summary>
        Color Punctuation { get; }

        /// <summary>
        /// Color for when a <see cref="LogLevel"/> of CRITICAL is reached
        /// </summary>
        Color Critical { get; }

        /// <summary>
        /// Color for when a <see cref="LogLevel"/> of ERROR is reached
        /// </summary>
        Color Error { get; }

        /// <summary>
        /// Color for when a <see cref="LogLevel"/> of WARNING is reached
        /// </summary>
        Color Warning { get; }

        /// <summary>
        /// Color for when a <see cref="LogLevel"/> of INFORMATION is reached
        /// </summary>
        Color Information { get; }

        /// <summary>
        /// Color for when a <see cref="LogLevel"/> of DEBUG is reached
        /// </summary>
        Color Debug { get; }

        /// <summary>
        /// Color for when a <see cref="LogLevel"/> of TRACE is reached
        /// </summary>
        Color Trace { get; }
    }
}