using Microsoft.Extensions.Logging;

using System;

using Valsom.AnsiBuilder;
using Valsom.AnsiBuilder.Abstractions;
using Valsom.Logging.PrettyConsole.Formats.Abstractions;
using Valsom.Logging.PrettyConsole.Themes.Abstractions;

namespace Valsom.Logging.PrettyConsole
{
    /// <summary>
    /// A colorful console implementation for <seealso cref="ILogger"/>
    /// </summary>
    public class PrettyConsoleLogger : ILogger
    {
        private readonly string _categoryName;
        private readonly IConsoleFormat _format;
        private readonly IConsoleTheme _theme;

        internal PrettyConsoleLogger(string categoryName, IConsoleFormat format, IConsoleTheme theme)
        {
            _categoryName = categoryName;
            _format = format;
            _theme = theme;


            IAnsiStringBuilder fillColor = new AnsiStringBuilder();
            fillColor.EndWithBackground(theme.Background);
            Console.Write(fillColor.Build());
            Console.Clear();
        }

        /// <inheritdoc />
        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        /// <inheritdoc />
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        /// <inheritdoc />
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception,
            Func<TState, Exception, string> formatter)
        {
            var entryBuilder = _format.CreateLogEntry(logLevel, _categoryName, eventId, formatter(state, exception), exception, _theme);
            var entry = entryBuilder.ToString();
            entry = entry.Trim('\r', '\n');

            Console.WriteLine(entry);
        }
    }
}