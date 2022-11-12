using System;
using System.Windows.Input;

namespace Base
{
    /// <summary>
    /// Класс реализующий интерфейс ICommand
    /// </summary>
    public class RelayCommand : ICommand
    {
        private Action<object> _Execute;
        private Func<object, bool> _CanExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object> Execute, Func<object, bool> CanExecute = null)
        {
            _Execute = Execute;
            _CanExecute = CanExecute;
        }

        public bool CanExecute(object Parameter) => _CanExecute?.Invoke(Parameter) ?? true;

        public void Execute(object Parameter) => _Execute(Parameter);
    }
}
