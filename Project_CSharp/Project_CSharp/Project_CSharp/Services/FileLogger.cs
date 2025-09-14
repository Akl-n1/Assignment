using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Project_CSharp.Services
{
    using System.Text.Json;

    public class FileLogger
    {
        private readonly object _lock = new();
        public void AppendJsonLine(string path, object obj)
        {
            var json = JsonSerializer.Serialize(obj, new JsonSerializerOptions { WriteIndented = false });
            lock (_lock) File.AppendAllText(path, json + Environment.NewLine);
        }
    }

}
