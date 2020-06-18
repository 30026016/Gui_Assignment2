using System.ComponentModel;

namespace Assignment.ViewModels
{
    public class FinalNewsViewModel : INotifyPropertyChanged
    {
        private NewsViewModel _news0;
        public NewsViewModel News0
        {
            get
            {
                return _news0;
            }
            private set
            {
                _news0 = value;
                NotifyPropertyChanged("News0");
            }
        }

        private NewsViewModel _news1;

        public NewsViewModel News1
        {
            get
            {
                return _news1;
            }

            private set
            {
                _news1 = value;
                NotifyPropertyChanged("News1");
            }
        }

        public FinalNewsViewModel()
        {
            _news0 = new NewsViewModel();
            _news1 = new NewsViewModel();
        }

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
