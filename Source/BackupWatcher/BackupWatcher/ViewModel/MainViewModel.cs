using System.ComponentModel;

namespace BackupWatcher.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string caminhoDiretorio;
        private string log;

        public string CaminhoDiretorio
        {
            get { return caminhoDiretorio; }
            set
            {
                caminhoDiretorio = value;
                OnPropertyChanged("CaminhoDiretorio");
            }
        }

        public string Log
        {
            get { return log; }
            set
            {
                log = value;
                OnPropertyChanged("Log");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}