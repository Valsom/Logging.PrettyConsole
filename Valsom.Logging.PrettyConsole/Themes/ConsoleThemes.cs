using Valsom.Logging.PrettyConsole.Themes.Abstractions;
using Valsom.Logging.PrettyConsole.Themes.Default;

namespace Valsom.Logging.PrettyConsole.Themes
{
    /// <summary>
    /// Default console themes
    /// </summary>
    public static class ConsoleThemes
    {
        /// <summary>
        /// A default 16-color Console Theme
        /// </summary>
        public static IConsoleTheme Vanilla => new VanillaConsoleTheme();

        /// <summary>
        /// A theme similar to the colors used in Visual Studio Code
        /// </summary>
        public static IConsoleTheme Code => new CodeConsoleTheme();

        /// <summary>
        /// Implementation of the One Dark Pro Visual Studio Code theme
        /// </summary>
        public static IConsoleTheme OneDarkPro => new OneDarkProTheme();

        /// <summary>
        /// Implementation of the Material Theme Lighter theme for Visual Studio Code
        /// </summary>
        public static IConsoleTheme MaterialLight => new MaterialLightTheme();

        /// <summary>
        /// Implementation of the Eva Light theme for Visual Studio Code
        /// </summary>
        public static IConsoleTheme EvaLight => new EvaLightTheme();

        /// <summary>
        /// Implementation of the Pop N' Lock theme for Visual Studio Code
        /// </summary>
        public static IConsoleTheme PopAndLock => new PopAndLockTheme();

        /// <summary>
        /// Implementation of the Hackpot Under The Sea theme for Visual Studio Code
        /// </summary>
        public static IConsoleTheme Hackpot => new HackpotTheme();
    }
}
