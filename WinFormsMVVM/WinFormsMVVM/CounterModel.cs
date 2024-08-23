using System.ComponentModel;

namespace WinFormsMVVM
{
    public sealed class CounterModel : INotifyPropertyChanged
    {
        private int _counter = 0;

        public event PropertyChangedEventHandler? PropertyChanged;

        public int ClicksCount
        {
            get { return _counter; }
            set
            {
                _counter = value;
                PropertyChanged?.Invoke(
                    this,
                    new PropertyChangedEventArgs(nameof(ClicksCount)));
            }
        }
    }
}