using Valsom.Logging.PrettyConsole.Formats.Abstractions;
using Valsom.Logging.PrettyConsole.Formats.Default;

namespace Valsom.Logging.PrettyConsole.Formats
{
    /// <summary>
    /// Default console formats
    /// </summary>
    public static class ConsoleFormats
    {
        /// <summary>
        /// The default console format
        /// </summary>
        public static IConsoleFormat Default => new DefaultConsoleFormat();
    }
}
