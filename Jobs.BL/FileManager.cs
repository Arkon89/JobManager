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
        
        string[] GetLines(string filepath);
        void AddContent(string path, string newString);
        void DeleteLine(string path, string delString);
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
              

        public string[] GetLines(string filePath)
        {
            return File.ReadAllLines(filePath, _defaultEncoding);
        }

        public void DeleteLine(string path, string delString)
        {
            string[] allLines = File.ReadAllLines(path, _defaultEncoding);
            allLines = allLines.Where(x => x != delString).ToArray<string>();
        }


    }
}
