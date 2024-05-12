using System.ComponentModel;

namespace UltimateReNamer.Core.Interfaces
{
    public interface IContentViewModel : INotifyPropertyChanged
    {
        // Title property to display a title for the content pane
        string Title { get; }

        // Method to initialize the view model
        void Initialize();

        // Method to perform cleanup before the view model is unloaded
        void Cleanup();
    }
}
