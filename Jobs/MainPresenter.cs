using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jobs.BL;


namespace Jobs
{
    class MainPresenter
    {
        private readonly IMainForm _view;
        private readonly IFileManager _manager;
        private readonly IMessageService _messageService;
        private readonly IJobManager _jobManager;

        

        public MainPresenter(IMainForm viev, IFileManager manager, IMessageService service, IJobManager jobManager)
        {
            _view = viev;
            _manager = manager;
            _jobManager = jobManager;
            _messageService = service;
            _view.FormLoad += _view_FormLoad;
            
            _view.JobAddClick += _view_JobAddClick;
            _view.JobDeleteClick += _view_JobDeleteClick;
            _view.MovToActualClick += _view_MovToActualClick;
            _view.MoveToWorkClick += _view_MoveToWorkClick;
            
        }        

        private void _view_MovToActualClick(object sender, EventArgs e)
        {
            try
            {
                //_manager.DeleteLine(_view.DeleteJob());
                _jobManager.RemoveFromTo(Job.JStats.newJob, _view.SelectedJob, Job.JStats.actualJob);
                _view.ClearList(1);
                List<Job> content = _jobManager.GetJobList(Job.JStats.newJob).ToList<Job>();
                foreach (var item in content)
                {
                    _view.AddTheJob(item.JobName, 1);
                }
                _view.ClearList(2);
                content = _jobManager.GetJobList(Job.JStats.actualJob).ToList<Job>();
                foreach (var item in content)
                {
                    _view.AddTheJob(item.JobName, 2);
                }
                ////string[] content = _manager.GetLines();
                ////foreach (var item in content)
                ////{
                ////    _view.AddTheJob(item);
                ////}
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        private void _view_MoveToWorkClick(object sender, EventArgs e)
        {
            
            throw new NotImplementedException();  
        }

        private void _view_FormLoad(object sender, EventArgs e)
        {
            //при загрузке формы - из файла грузится только первый столбец. 
            //    Это неободимо исправить
            try
            {
                bool isExist = _manager.IsExist();
                if (!isExist)
                {
                    //_messageService.ShowExclamation("Файл не найден");
                    //return;
                    _manager.CreateFile();
                }
                else
                {
                    string[] content = _manager.GetLines();
                    //if (_jobManager.GetJobList(Job.JStats.newJob).ToList<Job>() != null)
                    //{
                    //    List<Job> content = _jobManager.GetJobList(Job.JStats.newJob).ToList<Job>();
                    //    if (content != null)
                    foreach (var item in content)
                            {
                                _view.AddTheJob(item,1);
                                //_view.AddTheJob(item.JobName);
                            }
                    //}
                }
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }


        }

        private void _view_JobDeleteClick(object sender, EventArgs e)
        {
            try
            {
                //_manager.DeleteLine( _view.DeleteJob());
                _jobManager.DeleteNewJob(_view.DeleteJob());
                _view.ClearList(1);
                //string[] content = _manager.GetLines();
                List<Job> content = _jobManager.GetJobList(Job.JStats.newJob).ToList<Job>();
                foreach (var item in content)
                {
                    _view.AddTheJob(item.JobName, 1);
                }
            }
            catch(Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        private void _view_JobAddClick(object sender, EventArgs e)
        {
            try
            {
                bool isExist = _manager.IsExist();
                if (!isExist)
                {
                    _manager.CreateFile();
                }

                if (String.IsNullOrWhiteSpace(_view.NewJob)) return;
                //if(!_manager.AddContent(_view.NewJob)) return;//запись добавляется здесь
                if (!_jobManager.AddNewJob(_view.NewJob)) return;

                _view.ClearList(1);
                //string[] content = _manager.GetLines();
                List<Job> content = _jobManager.GetJobList(Job.JStats.newJob).ToList<Job>();
                foreach (var item in content)
                {
                    _view.AddTheJob(item.JobName, 1);
                }

            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }
    }
}
