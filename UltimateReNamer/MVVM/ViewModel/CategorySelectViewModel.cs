using UltimateReNamer.Core;
using System.Windows.Input;
using UltimateReNamer.Core.Interfaces;


namespace UltimateReNamer.MVVM.ViewModel
{
    public class CategorySelectViewModel : ObservableObject
    {
        private IContentViewModel _currentView;
        public IContentViewModel CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        private bool _showUndividedPane;
        public bool ShowUndividedPane
        {
            get { return _showUndividedPane; }
            set { _showUndividedPane = value; OnPropertyChanged(); if(value) ShowDividedPane = false; }
        }

        private bool _showDividedPane;
        public bool ShowDividedPane
        {
            get { return _showDividedPane; }
            set { _showDividedPane = value; OnPropertyChanged(); if (value) ShowUndividedPane = false; }
        }

        public ICommand HomeCommand { get; set; }
        public ICommand DocumentCommand { get; set; }
        public ICommand PhotoCommand { get; set; }
        public ICommand MusicCommand { get; set; }
        public ICommand VideoCommand { get; set; }
        public ICommand OtherCommand { get; set; }
        public ICommand SettingCommand { get; set; }

        private void Home(object obj)
        {
            CurrentView = new MainWindowViewModel();
            ShowUndividedPane = true;
        }

        private void Document(object obj)
        {
            CurrentView = new DocumentViewModel();
            ShowDividedPane = true;
        }

        private void Photo(object obj)
        {
            CurrentView = new PhotoViewModel();
            ShowDividedPane = true;
        }

        private void Music(object obj)
        {
            CurrentView = new MusicViewModel();
            ShowDividedPane = true;
        }

        private void Video(object obj)
        {
            CurrentView = new VideoViewModel();
            ShowDividedPane = true;
        }

        private void Other(object obj)
        {
            CurrentView = new OtherViewModel();
            ShowDividedPane = true;
        }

        private void Setting(object obj)
        {
            CurrentView = new SettingsViewModel();
            ShowUndividedPane = true;
        }

        public CategorySelectViewModel()
        {
            ShowUndividedPane = true;
            CurrentView = new MainWindowViewModel();

            HomeCommand = new RelayCommand(Home);
            DocumentCommand = new RelayCommand(Document);
            PhotoCommand = new RelayCommand(Photo);
            MusicCommand = new RelayCommand(Music);
            VideoCommand = new RelayCommand(Video);
            OtherCommand = new RelayCommand(Other);
            SettingCommand = new RelayCommand(Setting);
        }
    }
}