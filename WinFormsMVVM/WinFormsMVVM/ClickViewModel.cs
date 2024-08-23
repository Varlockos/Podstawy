using System.ComponentModel;
using System.Windows.Input;

namespace WinFormsMVVM
{
    public sealed class ClickViewModel : INotifyPropertyChanged
    {
        private readonly CounterModel _model;

        public event PropertyChangedEventHandler? PropertyChanged;

        public ICommand UpdateCounterCommand { get; private set; }

        public ClickViewModel(CounterModel model)
        {
            _model = model;
            _model.PropertyChanged += ModelChanged;
            UpdateCounterCommand = new UpdateCounterCommand(UpdateCounter);
        }

        public Binding GetLabelBinding()
        {
            return new Binding(
                "Text",
                _model,
                nameof(_model.ClicksCount),
                true,
                DataSourceUpdateMode.OnPropertyChanged);
        }

        private void ModelChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Model"));
        }

        private void UpdateCounter(object sender, PropertyChangedEventArgs e)
        {
            _model.ClicksCount++;
        }
    }
}