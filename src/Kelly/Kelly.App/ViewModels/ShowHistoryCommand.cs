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

        protected void OnCanExecuteChanged()
        {
            var ev = CanExecuteChanged;
            if (ev == null) return;
            ev(this, EventArgs.Empty);
        }

        public event EventHandler CanExecuteChanged;
    }
}