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
            _view.FormActivated += _view_FormActivated;
            _view.JobAddClick += _view_JobAddClick;
            _view.JobDeleteClick += _view_JobDeleteClick;
            
        }

        private void _view_FormActivated(object sender, EventArgs e)
        {
            string[] content = _manager.GetLines(_view.filePath);
        }

        private void _view_JobDeleteClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _view_JobAddClick(object sender, EventArgs e)
        {
            try
            {
                string filepath = _view.filePath;
                bool isExist = _manager.IsExist(filepath);
                if (!isExist)
                {
                    //_messageService.ShowExclamation("Файл не найден");
                    //return;
                    _manager.CreateFile(filepath);
                }
                _currentfilepath = filepath;
                _view.AddTheJob(_view.NewJob);
                _manager.AddContent(filepath, _view.NewJob);

            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }
    }
}
