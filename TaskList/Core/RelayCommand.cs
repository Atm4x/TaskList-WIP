using System;
using System.Windows.Input;

namespace TaskList.Core
{
    public class RelayCommand : ICommand
    {
        private Action<object> _execute;
        private Func<object, bool> _canExecute; 
        
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value;  }
            remove { CommandManager.RequerySuggested -= value;  }
        }

        public bool CanExecute(object execute)
        {
            return _canExecute == null || _canExecute(execute);
        }

        public void Execute(object execute)
        {
            _execute(execute);
        }
        
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }
    }
}