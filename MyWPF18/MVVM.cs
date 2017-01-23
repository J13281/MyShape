using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

class BindableBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    public void SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
    {
        storage = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

class DelegateCommand : ICommand
{
    public event EventHandler CanExecuteChanged;
    Action executeMethod;

    public DelegateCommand(Action executeMethod)
    {
        this.executeMethod = executeMethod;
    }

    public bool CanExecute(object parameter)
    {
        return true;
    }

    public void Execute(object parameter)
    {
        executeMethod?.Invoke();
    }
}