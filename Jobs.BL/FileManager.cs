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
        void CreateFile(string file);
        string GetContent(string filepath);
        string GetContent(string filePath, Encoding encoding);
        void SaveContent(string content, string filepath);
        void SaveContent(string content, string filePath, Encoding encoding);
        void AddContent(string path, string newString);
    }

    public class FileManager: IFileManager
    {
        private readonly Encoding _defaultEncoding = Encoding.GetEncoding(1251);

        public bool IsExist(string filePath)
        {
            bool isExist = File.Exists(filePath);
            return isExist;
        }
       public void CreateFile(string file)
        {
            File.Create(file);
        }
        public void AddContent(string path, string newString )
        {
            File.AppendAllText(path, newString + "\n", _defaultEncoding);
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
