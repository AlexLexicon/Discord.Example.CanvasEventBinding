using System.ComponentModel;
using System.Windows.Input;

namespace Discord.Example.CanvasEventBinding.ViewModels;
public class MainWindowViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public MainWindowViewModel()
    {
        KeyDownCommand = new MyCommand();
        KeyDownCommand.Executed += OnKeyDown;
    }

    public MyCommand KeyDownCommand { get; }

    private double _ellipseLeft;
    public double EllipseLeft
    {
        get => _ellipseLeft;
        set
        {
            _ellipseLeft = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(EllipseLeft)));
        }
    }

    public void OnKeyDown(object? args)
    {
        if (args is KeyEventArgs e)
        {
            if (e.Key is Key.D)
            {
                EllipseLeft += 5;
            }
            else if (e.Key is Key.A)
            {
                EllipseLeft -= 5;
            }
        }
    }
}
