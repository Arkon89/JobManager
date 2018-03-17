using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jobs
{
    public interface IMainForm
    {
        string filePath { get; }
        string NewJob { get; }
        //List<String> allJobs { get; set; }
        event EventHandler JobAddClick;
        event EventHandler JobDeleteClick;


    }

    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string filePath
        {
            get { return "Jobs.txt"; }
        }

        public string NewJob
        {
             get { return fldNewJob.Text; }            
        }

        
        public event EventHandler JobAddClick;
        public event EventHandler JobDeleteClick;

    }
}
