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
        
        string NewJob { get; }
        string SelectedJob { get; }
        //List<String> allJobs { get; set; }
        event EventHandler JobAddClick;
        event EventHandler JobDeleteClick;
        event EventHandler FormLoad;
        event EventHandler MovToActualClick;
        event EventHandler MoveToWorkClick;
        event EventHandler MoveToReadyClick;
        void AddTheJob(string job, int jobList);
        string DeleteJob();
        void ClearList(int jobList);



    }

    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            btAddJob.Click += BtAddJob_Click;
            btDeleteJob.Click += BtDeleteJob_Click;
            this.Load += MainForm_Load;
            
        }


        #region проброс событий
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (FormLoad != null) FormLoad(this, EventArgs.Empty); 
        }
        
        private void BtDeleteJob_Click(object sender, EventArgs e)
        {
            if (JobDeleteClick != null) JobDeleteClick(this, EventArgs.Empty);
        }

        private void BtAddJob_Click(object sender, EventArgs e)
        {
            if (JobAddClick != null) JobAddClick(this, EventArgs.Empty);
        }

        private void butMovToActual_Click(object sender, EventArgs e)
        {
            if (MovToActualClick != null) MovToActualClick(this, EventArgs.Empty);
        }


        private void butMoveToWork_Click(object sender, EventArgs e)
        {
            if (MoveToWorkClick != null) MoveToWorkClick(this, EventArgs.Empty);            
        }

        private void butReady_Click(object sender, EventArgs e)
        {
            if (MoveToReadyClick != null) MoveToReadyClick(this, EventArgs.Empty);
        }
        #endregion

        #region реализация интерфейса IMaimForm

        //public void TestText()
        //{
        //    labelTest.Text = listBoxMain.SelectedItem.ToString();  //  <----------
        //}

        public string NewJob
        {
             get { return fldNewJob.Text; }            
        }
        string x = "";
        
        public string SelectedJob
        {
            get
            {
                //listBoxMain.SelectedItem != null ? x = listBoxMain.SelectedItem.ToString() :
                //   listBoxActual.SelectedItem != null ? x = listBoxActual.SelectedItem.ToString() :
                //        listBoxWork.SelectedItem != null ? x = listBoxWork.SelectedItem.ToString() : x = y;
                if (listBoxMain.SelectedItem != null) x = listBoxMain.SelectedItem.ToString();
                if (listBoxActual.SelectedItem != null) x = listBoxActual.SelectedItem.ToString();
                if (listBoxWork.SelectedItem != null) x = listBoxWork.SelectedItem.ToString();
                return x;
            }
        }

        public string DeleteJob()
        {
            //int index = listBoxMain.SelectedIndex;
            //listBoxMain.Items.RemoveAt(index);
            string _item = listBoxMain.SelectedItem.ToString();
            listBoxMain.Items.Remove(listBoxMain.SelectedItem);
                return _item;
        }


        public event EventHandler JobAddClick;
        public event EventHandler JobDeleteClick;
        public event EventHandler FormLoad;
        public event EventHandler MovToActualClick;
        public event EventHandler MoveToWorkClick;
        public event EventHandler MoveToReadyClick;

        public void ClearList(int jobList)
        {
            switch (jobList)
            {
                case 1:
                    listBoxMain.Items.Clear();
                    break;
                case 2:
                    listBoxActual.Items.Clear();
                    break;
                case 3:
                    listBoxWork.Items.Clear();
                    break;
                case 4:
                    listBoxReady.Items.Clear();
                    break;
                default:
                    break;
            }
            
        }

        public void AddTheJob(string job, int jobList)
        {
            switch (jobList)
            {
                case 1:
                    listBoxMain.Items.Add(job);
                    break;
                case 2:
                    listBoxActual.Items.Add(job);
                    break;
                case 3:
                    listBoxWork.Items.Add(job);
                    break;
                case 4:
                    listBoxReady.Items.Add(job);
                    break;
                default:
                    break;
            }
            
        }







        #endregion

        #region собственный код формы

        #endregion

        
    }
}
