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

        private string _currentfilepath;

        public MainPresenter(IMainForm viev, IFileManager manager, IMessageService service)
        {
            _view = viev;
            _manager = manager;
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
                _manager.DeleteLine(_view.DeleteJob());
                _view.ClearList();
                string[] content = _manager.GetLines();
                foreach (var item in content)
                {
                    _view.AddTheJob(item);
                }
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
            //try
            //{
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
                    foreach (var item in content)
                    {
                        _view.AddTheJob(item);
                    }
                }
            //}
            //catch(Exception ex)
            //{
            //    _messageService.ShowError(ex.Message);
            //}
            
            
        }

        private void _view_JobDeleteClick(object sender, EventArgs e)
        {
            try
            {
                //_manager.DeleteLine( _view.DeleteJob());
                _jobManager.DeleteNewJob(_view.DeleteJob());
                _view.ClearList();
                string[] content = _manager.GetLines();
                foreach (var item in content)
                {
                    _view.AddTheJob(item);
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
                if(!_manager.AddContent(_view.NewJob)) return;
                _view.ClearList();
                string[] content = _manager.GetLines();
                foreach (var item in content)
                {
                    _view.AddTheJob(item);
                }

            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }
    }
}
