using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobs.BL
{
    public class FileManager
    {
        private readonly Encoding _defaultEncoding = Encoding.GetEncoding(1251);

        public string GetContent(string filepath)
        {
            return GetContent(filepath, _defaultEncoding);
        }

        public string GetContent(string filePath, Encoding encoding )
        {
            string content = File.ReadAllText(filePath, encoding);
            return content;//
        }
    }
}
