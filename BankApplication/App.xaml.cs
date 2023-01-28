using BankApplication.Services;
using BankApplication.ViewModels.Base;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Toolkit.Mvvm.DependencyInjection;
using System.Windows;

namespace BankApplication
{
    public partial class App : Application
    {
        public ViewModelLocator ViewModelLocator { get { return (ViewModelLocator)Current.TryFindResource("ViewModelLocator"); } }

        public App()
        {
            SetupDependencyInjection();
        }
        private void SetupDependencyInjection()
        {
            Ioc.Default.ConfigureServices(
                new ServiceCollection()
                    .AddSingleton<IMessenger, Messenger>()
                    .AddViewModels<ViewModelBase>()
                    .BuildServiceProvider()
                );
            ;
        }
    }
}
