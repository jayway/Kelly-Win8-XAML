using System;
using System.Windows.Input;

namespace Kelly.App.ViewModels
{
    public class ShowHistoryCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Navigate.ToHistoryPage();
        }

        public event EventHandler CanExecuteChanged;
    }
}