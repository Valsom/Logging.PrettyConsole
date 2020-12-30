using Microsoft.Extensions.Logging;

using System;
using System.Text;

using Valsom.Logging.PrettyConsole.Themes.Abstractions;

namespace Valsom.Logging.PrettyConsole.Formats.Abstractions
{
    /// <summary>
    /// A format used for formatting the console
    /// </summary>
    public interface IConsoleFormat
    {
        StringBuilder CreateLogEntry(LogLevel logLevel, string category, EventId eventId, string message, Exception ex, IConsoleTheme theme);
    }
}
