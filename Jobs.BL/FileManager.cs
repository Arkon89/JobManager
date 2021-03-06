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
        //string[] GetLines();
        bool AddContent(string newString, string jStatus);
        //void DeleteLine(int pos);
        List<Job> ReadXFile();
        bool SaveContent(List<Job> jList);
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
                xmlDoc.Root.Add(new XElement("Jobb", new XAttribute("Id", item.Id),
                    new XElement("JobName", item.JobName)));
            }
            //File.Create(file);
            xmlDoc.Save(filePath);
        }       

        public bool AddContent(string newString, string jStatus )
        {
            var xmlDoc = XDocument.Load(filePath);
            var xAtt = xmlDoc.Element("Jobs").Elements().ToArray();
            int attCount = xAtt.Length;
            xmlDoc.Element("Jobs").Add(new XElement
                                        ("Jobb",
                                        new XAttribute("Id", attCount + 1000 + 1),
                                        new XElement("JobName", newString)),
                                        new XElement("JobStatus", jStatus)
                                        );
            
            
            xmlDoc.Save(filePath);
            return true;
        }

        public bool SaveContent(List<Job> jList)
        {
            var xmlDoc = XDocument.Load(filePath);
            //var jAtt = xmlDoc.Element("Jobs").Elements().ToArray();
            
            //xmlDoc.Element("Jobs").Add(new XElement
            //                            ("Jobb",
            //                            new XAttribute("Id", attCount + 1000 + 1),
            //                            new XElement("JobName", newString)),
            //                            new XElement("JobStatus", jStatus)
            //                            );
            xmlDoc.Root.RemoveAll();
            for (int i = 0; i < jList.Count; i++)
            {
                xmlDoc.Element("Jobs").Add(new XElement
                                        ("Job",
                                        new XAttribute("Id", jList.ElementAt(i).Id),
                                        new XElement("JobName", jList.ElementAt(i).JobName),
                                        new XElement("JobStatus", jList.ElementAt(i).JobStatus.ToString())
                                        )
                                        );
            }
            

            xmlDoc.Save(filePath);
            return true;
        }


        public List<Job> ReadXFile()
        {
            List<Job> _jobs;
            var _tmp = from job in
                    XDocument.Load(filePath).Descendants("Job")
                       select new Job
                       {
                           Id = job.HasAttributes ? (int)job.Attribute("Id") : 0,
                           JobName = job.Element("JobName").Value.ToString(),
                           JobStatus = (Job.JStats)Enum.Parse(typeof(Job.JStats), job.Element("JobStatus").Value)
                       };
            _jobs = _tmp.ToList<Job>();            
            return _jobs;
        }

        //public string[] GetLines()
        //{    
        //        var jb =
        //        from job in
        //            XDocument.Load(filePath).Descendants("Jobb")                    
        //        select new Job
        //        {                    
        //            Id = job.HasAttributes? (int)job.Attribute("Id"):0,
        //            JobName = job.Element("JobName").Value.ToString(),
        //            //JobStatus = (Job.JStats)job.Element("JobStatus").Value
        //        };

        //    List<string> JobList = new List<string>();
        //    foreach (var item in jb)
        //    {
        //        JobList.Add(item.Id.ToString() + "\t" + item.JobName);
        //    }
        //    return JobList.ToArray<string>();
        //}

        //public void DeleteLine(int pos)
        //{
        //    var xmlDoc = XDocument.Load(filePath);

        //    //xmlDoc.Element("Jobs").Elements("Jobb").Where(x => x.Attribute("Id").Value == (pos + 1000).ToString()).FirstOrDefault().Remove();
        //    //xmlDoc.Save(filePath);
        //    xmlDoc.Element("Jobs").Elements().ElementAt(pos).Remove();
        //    xmlDoc.Save(filePath);

        //}


    }
}
