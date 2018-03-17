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

        public MainPresenter(IMainForm viev, IFileManager manager, IMessageService service)
        {
            _view = viev;
            _manager = manager;
            _messageService = service;
        }
    }
}
