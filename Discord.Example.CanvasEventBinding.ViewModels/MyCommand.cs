using System;
using System.Windows.Input;

namespace Discord.Example.CanvasEventBinding.ViewModels;
public class MyCommand : ICommand
{
    public event EventHandler? CanExecuteChanged;
    public event Action<object?>? Executed;

    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        Executed?.Invoke(parameter);
    }
}