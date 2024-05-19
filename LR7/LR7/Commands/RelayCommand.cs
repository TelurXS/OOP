using System.Windows.Input;

namespace LR7.Commands;

public class RelayCommand<T> : ICommand
{
    public RelayCommand(Action<T> action, Predicate<T>? predicate)
    {
        Action = action;
		Predicate = predicate;
    }

	public RelayCommand(Action<T> action)
		: this(action, null)
	{
	}

	private Action<T> Action { get; init; }
	private Predicate<T>? Predicate { get; init; }

    public event EventHandler? CanExecuteChanged;

	public bool CanExecute(object? parameter)
	{
		return Predicate is null || Predicate((T)parameter!);
	}

	public void Execute(object? parameter)
	{
		Action((T)parameter!);
	}
}
