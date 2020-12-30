﻿using System;
using System.Drawing;

using Valsom.Logging.PrettyConsole.Themes.Abstractions;
using Valsom.Logging.PrettyConsole.Themes.Helper;

namespace Valsom.Logging.PrettyConsole.Themes.Default
{
    /// <summary>
    /// A default 16-color Console Theme
    /// </summary>
    public class VanillaConsoleTheme : IConsoleTheme
    {
        internal VanillaConsoleTheme()
        {

        }

        /// <inheritdoc />
        public Color Background => ConsoleColor.Black.ToColor();

        /// <inheritdoc />
        public Color Foreground => ConsoleColor.Gray.ToColor();

        /// <inheritdoc />
        public Color SecondaryText => ConsoleColor.DarkGray.ToColor();

        /// <inheritdoc />
        public Color Punctuation => ConsoleColor.DarkGray.ToColor();

        /// <inheritdoc />
        public Color Critical => ConsoleColor.DarkCyan.ToColor();

        /// <inheritdoc />
        public Color Error => ConsoleColor.Red.ToColor();

        /// <inheritdoc />
        public Color Warning => ConsoleColor.DarkYellow.ToColor();

        /// <inheritdoc />
        public Color Information => ConsoleColor.White.ToColor();

        /// <inheritdoc />
        public Color Debug => ConsoleColor.DarkGray.ToColor();

        /// <inheritdoc />
        public Color Trace => ConsoleColor.DarkGreen.ToColor();
    }
}