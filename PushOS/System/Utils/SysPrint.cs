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

        private static Dictionary<int, ConsoleColor> LevelColors = new Dictionary<int, ConsoleColor>()
        {
            { (int)Levels.Trace,     ConsoleColor.White },
            { (int)Levels.Debug,     ConsoleColor.Cyan },
            { (int)Levels.Ok,        ConsoleColor.Green },
            { (int)Levels.Warning,   ConsoleColor.Yellow },
            { (int)Levels.Error,     ConsoleColor.Red },
            { (int)Levels.Fatal,     ConsoleColor.DarkRed },
        };

        private static Dictionary<int, string> LevelNames = new Dictionary<int, string>()
        {
            { (int)Levels.Trace,     " TRACE " },
            { (int)Levels.Debug,     " DEBUG " },
            { (int)Levels.Ok,        "  OK   " },
            { (int)Levels.Warning,   " WARN  " },
            { (int)Levels.Error,     " ERROR " },
            { (int)Levels.Fatal,     " FATAL " }
        };

        private static void Print(Levels level, string message)
        {
            Console.ResetColor();
            Console.Write('[');
            Console.ForegroundColor = LevelColors[(int)level];
            Console.Write(LevelNames[(int)level]);
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
