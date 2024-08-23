using System.ComponentModel;
using System.Windows.Input;

namespace WinFormsMVVM
{
    public sealed class UpdateCounterCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private readonly Action<object, PropertyChangedEventArgs> _updateCounter;

        public UpdateCounterCommand(Action<object, PropertyChangedEventArgs> updateCounter)
        {
            _updateCounter = updateCounter;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _updateCounter(this, new PropertyChangedEventArgs("Command"));
        }
    }
}