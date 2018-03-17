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
        event EventHandler FormActivated;
        void AddTheJob(string job);
        string DeleteJob();

    }

    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            btAddJob.Click += BtAddJob_Click;
            btDeleteJob.Click += BtDeleteJob_Click;
            this.Activated += MainForm_Activated;
        }


        #region проброс событий
        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (FormActivated != null) FormActivated(this, EventArgs.Empty); 
        }
        
        private void BtDeleteJob_Click(object sender, EventArgs e)
        {
            if (JobDeleteClick != null) JobDeleteClick(this, EventArgs.Empty);
        }

        private void BtAddJob_Click(object sender, EventArgs e)
        {
            if (JobAddClick != null) JobAddClick(this, EventArgs.Empty);
        }
        #endregion

        #region реализация интерфейса IMaimForm
        public string filePath
        {
            get { return "Jobs.txt"; }
        }

        public string NewJob
        {
             get { return fldNewJob.Text; }            
        }

        public string DeleteJob()
        {
            MessageService service = new MessageService();
            try
            {
                if (listBoxMain.SelectedValue != null)
                    return listBoxMain.SelectedValue.ToString();
                else
                {
                    service.ShowExclamation("Чтобы что то удалить, нужно это что то выбрать ");
                    return "";
                }
            }
            catch (Exception ex)
            {
                
                service.ShowError(ex.Message);
                return "";
            }            
        }


        public event EventHandler JobAddClick;
        public event EventHandler JobDeleteClick;
        public event EventHandler FormActivated;

        public void AddTheJob(string job)
        {
            listBoxMain.Items.Add(job);
        }
        
        #endregion

        #region собственный код формы

        #endregion
    }
}
