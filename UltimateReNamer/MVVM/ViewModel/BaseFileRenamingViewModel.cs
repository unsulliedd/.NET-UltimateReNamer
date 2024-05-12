using System.ComponentModel;
using UltimateReNamer.Core.Interfaces;

namespace UltimateReNamer.MVVM.ViewModel
{
    public class BaseFileRenamingViewModel : IContentViewModel
    {
        // Constructor with a title parameter
        public BaseFileRenamingViewModel(string title)
        {
            Title = title;
        }

        public string Title { get; protected set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        // Initialize method
        public virtual void Initialize()
        {
            // Perform initialization tasks here
        }

        // Cleanup method
        public virtual void Cleanup()
        {
            // Perform cleanup tasks here
        }
    }
}
