﻿using System.IO;

namespace section6_34
{
    public class FileLogger: ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            
        }

        public void LogError(string message)
        {
            Log(message, "ERROR");   
        }

        public void LogInfo(string message)
        {
            Log(message,"INFO");
        }

        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + " : " + message);
                streamWriter.Dispose();
            }
        }
    }
}