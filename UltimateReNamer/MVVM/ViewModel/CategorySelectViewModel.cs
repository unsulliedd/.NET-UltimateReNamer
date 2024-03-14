using UltimateReNamer.Core;
using System.Windows.Input;

namespace UltimateReNamer.MVVM.ViewModel
{
    public class CategorySelectViewModel : ObservableObject
    {
        private object _curentView;
        public object CurentView
        {
            get { return _curentView; }
            set { _curentView = value; OnPropertyChanged(); }
        }

        public ICommand HomeCommand { get; set; }
        public ICommand DocumentCommand { get; set; }
        public ICommand PhotoCommand { get; set; }
        public ICommand MusicCommand { get; set; }
        public ICommand VideoCommand { get; set; }
        public ICommand OtherCommand { get; set; }
        public ICommand SettingCommand { get; set; }

        private void Home(object obj) => CurentView = new MainWindowViewModel();
        private void Document(object obj) => CurentView = new DocumentViewModel();
        private void Photo(object obj) => CurentView = new PhotoViewModel();
        private void Music(object obj) => CurentView = new MusicViewModel();
        private void Video(object obj) => CurentView = new VideoViewModel();
        private void Other(object obj) => CurentView = new OtherViewModel();
        private void Setting(object obj) => CurentView = new SettingsViewModel();

        public CategorySelectViewModel()
        {
            HomeCommand = new RelayCommand(Home);
            DocumentCommand = new RelayCommand(Document);
            PhotoCommand = new RelayCommand(Photo);
            MusicCommand = new RelayCommand(Music);
            VideoCommand = new RelayCommand(Video);
            OtherCommand = new RelayCommand(Other);
            SettingCommand = new RelayCommand(Setting);

            CurentView = new MainWindowViewModel();
        }
    }
}
