using DocumentOrganizer_2.UIDialogs.ViewModelService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentOrganizer_2.UIDialogs.Presenter
{
    public interface IDialogBoxPresenter<T> where T : IDialogViewModel
    {
        void Show(T viewModel);
    }
}
