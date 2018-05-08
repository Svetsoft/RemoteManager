using Prism.Mvvm;

namespace RemoteManager.Desktop.Main
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";

        /// <summary>
        ///     Gets or sets the title.
        /// </summary>
        /// <value>
        ///     The title.
        /// </value>
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
    }
}