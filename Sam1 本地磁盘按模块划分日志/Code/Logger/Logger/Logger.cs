using NLog;
using System.Collections.Generic;

namespace BrowsePearls.Log
{
    public class Logger
    {
        public static void Debug(string content,string module)
        {
            AddLoggerForNewModule(module);
            _existingLoggers[module].Debug(content);
        }

        public static void Info(string content, string module)
        {
            AddLoggerForNewModule(module);
            _existingLoggers[module].Info(content);
        }

        public static void Warn(string content, string module)
        {
            AddLoggerForNewModule(module);
            _existingLoggers[module].Warn(content);
        }

        public static void Error(string content, string module)
        {
            AddLoggerForNewModule(module);
            _existingLoggers[module].Error(content);
        }

        public static void Fatal(string content, string module)
        {
            AddLoggerForNewModule(module);
            _existingLoggers[module].Fatal(content);
        }

        public static void Report(string content, string module)
        {
            AddLoggerForNewModule(module);
            _existingLoggers[module].Trace(content);
        }

        private static readonly Dictionary<string, NLog.Logger> _existingLoggers = new Dictionary<string, NLog.Logger>();
        private static readonly object locker = new object();
        private static void AddLoggerForNewModule(string module)
        {
            if (!_existingLoggers.ContainsKey(module))
            {
                lock (locker)
                {
                    if (!_existingLoggers.ContainsKey(module))
                    {
                        _existingLoggers[module] = LogManager.GetLogger(module);
                    }
                }
            }
        }
    }
}
