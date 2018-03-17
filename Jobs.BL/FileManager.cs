using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobs.BL
{
    public interface IFileManager
    {
        bool IsExist(string filePath);
        string GetContent(string filepath);
        string GetContent(string filePath, Encoding encoding);
        void SaveContent(string content, string filepath);
        void SaveContent(string content, string filePath, Encoding encoding);

    }

    public class FileManager: IFileManager
    {
        private readonly Encoding _defaultEncoding = Encoding.GetEncoding(1251);

        public bool IsExist(string filePath)
        {
            bool isExist = File.Exists(filePath);
            return isExist;
        }

        public string GetContent(string filepath)
        {
            return GetContent(filepath, _defaultEncoding);
        }

        public string GetContent(string filePath, Encoding encoding )
        {
            string content = File.ReadAllText(filePath, encoding);
            return content;//
        }

        public void SaveContent(string content ,string filepath)
        {
            SaveContent(content ,filepath, _defaultEncoding);
        }

        public void SaveContent(string content ,string filePath, Encoding encoding)
        {
            File.WriteAllText(filePath, content, encoding);
            
        }

    }
}
