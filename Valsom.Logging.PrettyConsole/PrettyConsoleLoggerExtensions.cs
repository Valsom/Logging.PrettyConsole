using Microsoft.Extensions.Logging;

using Valsom.Logging.PrettyConsole.Formats;
using Valsom.Logging.PrettyConsole.Formats.Abstractions;
using Valsom.Logging.PrettyConsole.Themes;
using Valsom.Logging.PrettyConsole.Themes.Abstractions;

namespace Valsom.Logging.PrettyConsole
{
    public static class PrettyConsoleLoggerExtensions
    {
        /// <summary>
        /// Adds a <see cref="PrettyConsoleLogger"/> instance to the <seealso cref="ILoggingBuilder"/>
        /// </summary>
        /// <param name="format">The <see cref="IConsoleFormat"/> used logging</param>
        /// <param name="theme">The <see cref="IConsoleTheme"/> used for logging</param>
        /// <returns></returns>
        public static ILoggingBuilder AddPrettyConsole(this ILoggingBuilder builder, IConsoleFormat format = null, IConsoleTheme theme = null)
        {
            if (theme == null) { theme = ConsoleThemes.Code; }
            if (format == null) { format = ConsoleFormats.Default; }

            builder.AddProvider(new PrettyConsoleLoggerProvider(format, theme));

            return builder;
        }
    }
}