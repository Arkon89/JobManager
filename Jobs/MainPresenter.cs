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

        private string _currentfilepath;

        public MainPresenter(IMainForm viev, IFileManager manager, IMessageService service)
        {
            _view = viev;
            _manager = manager;
            _messageService = service;
            _view.FormLoad += _view_FormLoad;
            
            _view.JobAddClick += _view_JobAddClick;
            _view.JobDeleteClick += _view_JobDeleteClick;
            
        }

        private void _view_FormLoad(object sender, EventArgs e)
        {
            string[] content = _manager.GetLines(_view.filePath);
            foreach (var item in content)
            {
                _view.AddTheJob(item);
            }
            
        }

        private void _view_JobDeleteClick(object sender, EventArgs e)
        {
            try
            {
                _manager.DeleteLine(_view.filePath, _view.DeleteJob());
                _view.ClearList();
                string[] content = _manager.GetLines(_view.filePath);
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
                    //_messageService.ShowExclamation("Файл не найден");
                    //return;
                    _manager.CreateFile();
                }
                _currentfilepath = filepath;

                if (String.IsNullOrEmpty(_view.NewJob)) return;
                if(!_manager.AddContent(filepath, _view.NewJob)) return;
                _view.AddTheJob(_view.NewJob);

            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }
    }
}
