using Microsoft.Toolkit.Mvvm.DependencyInjection;

namespace BankApplication.ViewModels.Base
{
    public class ViewModelLocator
    {
        public MainWindowViewModel Main
        {
            get { return Ioc.Default.GetService<MainWindowViewModel>(); }
        }

        public ConsultantViewModel Consultant
        {
            get { return Ioc.Default.GetService<ConsultantViewModel>(); }
        }

        public ManagerViewModel Manager
        {
            get { return Ioc.Default.GetService<ManagerViewModel>(); }
        }
    }
}
