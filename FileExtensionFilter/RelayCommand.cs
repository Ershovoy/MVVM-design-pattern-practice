using System;
using System.Windows.Input;

namespace FileExtensionFilter.Commands;

/// <summary>
/// Abstraction for commands.
/// </summary>
public class RelayCommand : ICommand
{
	/// <summary>
	/// Invoke whenever a result from CanExecute() method is changed.
	/// </summary>
	public event EventHandler? CanExecuteChanged;

	/// <summary>
	/// Called to determine should be Execture() method be called.
	/// </summary>
	/// <param name="parameter">Parameter passed from user interface.</param>
	/// <returns>If true action can be executed.</returns>
	public bool CanExecute(object? parameter)
	{
		return true;
	}

	/// <summary>
	/// Execute command method.
	/// </summary>
	/// <param name="parameter">Parameter passed from user interface.</param>
	public void Execute(object? parameter)
	{
		ExecuteAction.Invoke(parameter);
	}

	/// <summary>
	/// Constructor.
	/// </summary>
	/// <param name="executeAction">Default action for execution.</param>
	public RelayCommand(Action<object?> executeAction)
	{
		ExecuteAction = executeAction;
	}

	/// <summary>
	/// Action method that needs to be executed.
	/// </summary>
	public Action<object?> ExecuteAction { get; set; }
}