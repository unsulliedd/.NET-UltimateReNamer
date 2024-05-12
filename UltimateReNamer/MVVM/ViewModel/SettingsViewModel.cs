using System.ComponentModel;
using UltimateReNamer.Core.Interfaces;

namespace UltimateReNamer.MVVM.ViewModel
{
    public class SettingsViewModel : IContentViewModel
    {
        public string Title { get;} = "Settings";

        public event PropertyChangedEventHandler? PropertyChanged;

        public void Cleanup()
        {
        }

        public void Initialize()
        {
        }
    }
}
