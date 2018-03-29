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
            _view.MoveToReadyClick += _view_MoveToReadyClick;
            _view.BackToAllClick += _view_BackToAllClick;
            _view.BackToActClick += _view_BackToActClick;
        }

        private void _view_BackToActClick(object sender, EventArgs e)
        {
            try
            {
                _jobManager.RemoveFromTo(Job.JStats.workJob, _view.SelectedJob, Job.JStats.actualJob);
                _view.ClearList(3);
                List<Job> content = _jobManager.GetJobList(Job.JStats.workJob).ToList<Job>();
                foreach (var item in content)
                {
                    _view.AddTheJob(item.JobName, 3);
                }
                _view.ClearList(2);
                content = _jobManager.GetJobList(Job.JStats.actualJob).ToList<Job>();
                foreach (var item in content)
                {
                    _view.AddTheJob(item.JobName, 2);
                }
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        private void _view_BackToAllClick(object sender, EventArgs e)
        {
            try
            {
                _jobManager.RemoveFromTo(Job.JStats.actualJob, _view.SelectedJob, Job.JStats.newJob);
                _view.ClearList(2);
                List<Job> content = _jobManager.GetJobList(Job.JStats.actualJob).ToList<Job>();
                foreach (var item in content)
                {
                    _view.AddTheJob(item.JobName, 2);
                }
                _view.ClearList(1);
                content = _jobManager.GetJobList(Job.JStats.newJob).ToList<Job>();
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

        private void _view_MoveToReadyClick(object sender, EventArgs e)
        {
            try
            {
                _jobManager.RemoveFromTo(Job.JStats.workJob, _view.SelectedJob, Job.JStats.readyJob);
                _view.ClearList(3);
                List<Job> content = _jobManager.GetJobList(Job.JStats.workJob).ToList<Job>();
                foreach (var item in content)
                {
                    _view.AddTheJob(item.JobName, 3);
                }
                _view.ClearList(4);
                content = _jobManager.GetJobList(Job.JStats.readyJob).ToList<Job>();
                foreach (var item in content)
                {
                    _view.AddTheJob(item.JobName, 4);
                }
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        private void _view_MovToActualClick(object sender, EventArgs e)
        {
            try
            {                
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
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        private void _view_MoveToWorkClick(object sender, EventArgs e)
        {
            try
            {
                List<Job> content = _jobManager.GetJobList(Job.JStats.newJob).ToList<Job>();
                content = _jobManager.GetJobList(Job.JStats.actualJob).ToList<Job>();
                //_jobManager.RemoveFromTo(Job.JStats.newJob, _view.SelectedJob, Job.JStats.actualJob);
                //_view.ClearList(1);
                ////List<Job> content = _jobManager.GetJobList(Job.JStats.newJob).ToList<Job>();
                //foreach (var item in content)
                //{
                //    _view.AddTheJob(item.JobName, 1);
                //}
                //_view.ClearList(2);
                //content = _jobManager.GetJobList(Job.JStats.actualJob).ToList<Job>();
                //foreach (var item in content)
                //{
                //    _view.AddTheJob(item.JobName, 2);
                //}
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
            try
            {
                _jobManager.RemoveFromTo(Job.JStats.actualJob, _view.SelectedJob, Job.JStats.workJob);
                _view.ClearList(2);
                List<Job> content = _jobManager.GetJobList(Job.JStats.actualJob).ToList<Job>();
                foreach (var item in content)
                {
                    _view.AddTheJob(item.JobName, 2);
                }
                _view.ClearList(3);
                content = _jobManager.GetJobList(Job.JStats.workJob).ToList<Job>();
                foreach (var item in content)
                {
                    _view.AddTheJob(item.JobName, 3);
                }
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
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
                    string[] content1 = _manager.ReadXFile().
                                                            Where(x => x.JobStatus == Job.JStats.newJob).
                                                            Select(x => x.JobName).ToArray<string>();                    
                    foreach (var item in content1)
                            {
                                _view.AddTheJob(item,1);
                                _jobManager.AddNewJob(item, 0);                                
                            }
                    //-----------------------------------
                    string[] content2 = _manager.ReadXFile().
                                                            Where(x => x.JobStatus == Job.JStats.actualJob).
                                                            Select(x => x.JobName).ToArray<string>();
                    foreach (var item in content2)
                    {
                        _view.AddTheJob(item, 2);
                        _jobManager.AddNewJob(item, 1);
                    }
                    //-----------------------------------
                    string[] content3 = _manager.ReadXFile().
                                                            Where(x => x.JobStatus == Job.JStats.workJob).
                                                            Select(x => x.JobName).ToArray<string>();
                    foreach (var item in content3)
                    {
                        _view.AddTheJob(item, 3);
                        _jobManager.AddNewJob(item, 2);
                    }
                    //-----------------------------------
                    string[] content4 = _manager.ReadXFile().
                                                            Where(x => x.JobStatus == Job.JStats.readyJob).
                                                            Select(x => x.JobName).ToArray<string>();
                    foreach (var item in content4)
                    {
                        _view.AddTheJob(item, 4);
                        _jobManager.AddNewJob(item, 3);
                    }

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
                if (!_jobManager.AddNewJob(_view.NewJob, 0)) return;

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
