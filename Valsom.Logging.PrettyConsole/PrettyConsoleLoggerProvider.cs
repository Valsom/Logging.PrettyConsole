using Microsoft.Extensions.Logging;

using System;
using System.Runtime.InteropServices;

using Valsom.Logging.PrettyConsole.Formats.Abstractions;
using Valsom.Logging.PrettyConsole.Themes.Abstractions;

namespace Valsom.Logging.PrettyConsole
{
    public class PrettyConsoleLoggerProvider : ILoggerProvider
    {
        private readonly IConsoleTheme _theme;
        private readonly IConsoleFormat _format;

        /// <summary>
        /// Creates a new instance of the <see cref="PrettyConsoleLoggerProvider"/> class with a custom <seealso cref="IConsoleFormat"/> and <seealso cref="IConsoleTheme"/>
        /// </summary>
        /// <param name="format">The <see cref="IConsoleFormat"/> used logging</param>
        /// <param name="theme">The <see cref="IConsoleTheme"/> used for logging</param>
        public PrettyConsoleLoggerProvider(IConsoleFormat format, IConsoleTheme theme)
        {
            _theme = theme;
            _format = format;
        }

        /// <summary>
        /// Disposes of the logger
        /// </summary>
        public void Dispose()
        {
        }

        /// <summary>
        /// Creates a new ConsoleLogger
        /// </summary>
        /// <param name="categoryName">The category of these logs</param>
        /// <returns></returns>
        public ILogger CreateLogger(string categoryName)
        {
            // Get the STD handle
            IntPtr iStdOut = GetStdHandle(StdOutputHandle);

            // Try to enable the use of ANSI codes
            bool colorSupported = GetConsoleMode(iStdOut, out uint outConsoleMode) &&
                                  SetConsoleMode(iStdOut, outConsoleMode | EnableVirtualTerminalProcessing);

            return new PrettyConsoleLogger(categoryName, _format, _theme);
        }

        private const int StdOutputHandle = -11;
        private const uint EnableVirtualTerminalProcessing = 0x0004;

        [DllImport("kernel32.dll")]
        private static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);

        [DllImport("kernel32.dll")]
        private static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetStdHandle(int nStdHandle);
    }
}