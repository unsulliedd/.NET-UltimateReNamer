using System.ComponentModel;
using UltimateReNamer.Core.Interfaces;

namespace UltimateReNamer.MVVM.ViewModel
{
    public class MainWindowViewModel : IContentViewModel
    {
        public string Title { get; } = "Home";

        public event PropertyChangedEventHandler? PropertyChanged;

        public void Cleanup()
        {
        }

        public void Initialize()
        {
        }
    }
}
