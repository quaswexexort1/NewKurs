using KursovayaaClient.Utills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KursovayaaClient.ViewModels
{
    public class NavigationViewModel : ViewModelBase
    {
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand HomeCommand { get; set; }
        public ICommand ChitatelCommand { get; set; }

        private void HomeView(object obj) => CurrentView = new HomeViewModel();
        private void ChitateliView(object obj) => CurrentView = new ChitateliViewModel();
        public NavigationViewModel()
        {
            HomeCommand = new RelayCommand(HomeView);
            ChitatelCommand = new RelayCommand(ChitateliView);
            CurrentView = new HomeViewModel();
        }
    }
}
