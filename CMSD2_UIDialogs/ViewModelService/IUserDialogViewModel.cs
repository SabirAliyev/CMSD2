﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentOrganizer_2.UIDialogs.ViewModelService
{
    public interface IUserDialogViewModel : IDialogViewModel
    {
        bool IsModal { get; }
        void RequestClose();
        event EventHandler DialogClosing;
    }
}
