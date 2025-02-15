using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushOSs.System.Utils
{
    internal class SysPrint
    {
        private enum Levels
        {
            Trace, Debug, Ok, Warning, Error, Fatal
        }

        private static readonly Dictionary<uint, ConsoleColor> LevelColors = new Dictionary<uint, ConsoleColor>
        {
            { (uint)Levels.Trace,     ConsoleColor.White },
            { (uint)Levels.Debug,     ConsoleColor.Cyan },
            { (uint)Levels.Ok,        ConsoleColor.Green },
            { (uint)Levels.Warning,   ConsoleColor.Yellow },
            { (uint)Levels.Error,     ConsoleColor.Red },
            { (uint)Levels.Fatal,     ConsoleColor.DarkRed },
        };

        private static readonly Dictionary<uint, string> LevelNames = new Dictionary<uint, string>
        {
            { (uint)Levels.Trace,     " TRACE " },
            { (uint)Levels.Debug,     " DEBUG " },
            { (uint)Levels.Ok,        "  OK   " },
            { (uint)Levels.Warning,   " WARN  " },
            { (uint)Levels.Error,     " ERROR " },
            { (uint)Levels.Fatal,     " FATAL " }
        };

        private static void Print(Levels level, string message)
        {
            Console.ResetColor();
            Console.Write('[');
            Console.ForegroundColor = LevelColors[(uint)level];
            Console.Write(LevelNames[(uint)level]);
            Console.ResetColor();
            Console.WriteLine($"] {message}");
        }

        public static void Trace(string message)
        {
            Print(Levels.Trace, message);
        }

        public static void Debug(string message)
        {
            Print(Levels.Debug, message);
        }

        public static void Ok(string message)
        {
            Print(Levels.Ok, message);
        }

        public static void Warning(string message)
        {
            Print(Levels.Warning, message);
        }

        public static void Error(string message)
        {
            Print(Levels.Error, message);
        }

        public static void Fatal(string message)
        {
            Print(Levels.Fatal, message);
        }
    }
}
