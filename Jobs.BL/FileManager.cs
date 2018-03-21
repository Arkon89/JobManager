﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Jobs.BL
{
    public interface IFileManager
    {
        
        bool IsExist();        
        void CreateFile();
        string[] GetLines();
        bool AddContent(string newString);
        void DeleteLine(int pos);
    }

    public class FileManager: IFileManager
    {
        string filePath = Path.Combine(Environment.CurrentDirectory, "xJobsDoc.xml");
        private readonly Encoding _defaultEncoding = Encoding.GetEncoding(1251);

        public bool IsExist()
        {
            bool isExist = File.Exists(filePath);
            return isExist;
        }

        public void CreateFile()
        {
            var xmlDoc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), new XElement("Jobs"));
            foreach (var item in Job.GetAllJobs())
            {
                xmlDoc.Root.Add(new XElement("Job", new XAttribute("Id", item.Id),
                    new XElement("JobName", item.JobName)));
            }
            //File.Create(file);
            xmlDoc.Save(filePath);
        }       

        public bool AddContent(string newString )
        {
            var _text = File.ReadAllLines(filePath, _defaultEncoding);
            foreach (var item in _text)
            {
                if (item == newString) return false;
            } 
            
            File.AppendAllText(filePath, newString + "\n", _defaultEncoding);
            return true;
        }
              

        public string[] GetLines()
        {
            var jb =
                from job in
                    XDocument.Load(filePath).Descendants("Jobs")
                select new Job
                {
                    Id = (int)job.Attribute("Id"),
                    JobName = job.Element("JobName").Value.ToString()
                };
            List<string> JobList = new List<string>();
            foreach (var item in jb)
            {
                JobList.Add(item.Id.ToString() + "\t" + item.JobName);
            }
            return JobList.ToArray<string>();
        }

        public void DeleteLine(int pos)
        {
                string[] allLines = File.ReadAllLines(filePath, _defaultEncoding);
                allLines = allLines.Where(x => x != allLines.ElementAt(pos)).ToArray<string>();
                File.WriteAllLines(filePath, allLines, _defaultEncoding);            
        }


    }
}
