using System.IO;

namespace InterfacesExtensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }
        void ILogger.LogError(string message)
        {
            Log(message, MessageTypes.ERROR.ToString());
        }

        void ILogger.LogInfo(string message)
        {
            Log(message, MessageTypes.INFO.ToString());
        }

        private void Log(string message, string messageType)
        {
            //since the external file is not handled by the CLR, we need to use "using". If something goes wrong, the errors will be handled by "Dispose"
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine($"{messageType}: {message}");
            }
        }
    }
}
