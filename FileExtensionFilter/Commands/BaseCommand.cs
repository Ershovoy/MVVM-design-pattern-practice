using System;
using System.Windows.Input;

namespace FileExtensionFilter.Commands;

/// <summary>
/// Abstraction for commands.
/// </summary>
public abstract class BaseCommand : ICommand
{
	/// <summary>
	/// Invoke whenever a result from CanExecute() method is changed.
	/// </summary>
	public event EventHandler? CanExecuteChanged;

	/// <summary>
	/// Called to determine should be Execture() method be called.
	/// </summary>
	/// <param name="parameter">Parameter passed from user interface.</param>
	/// <returns></returns>
	public virtual bool CanExecute(object? parameter)
	{
		return true;
	}

	/// <summary>
	/// Abstaction for polymorphic command method.
	/// </summary>
	/// <param name="parameter">Parameter passed from user interface.</param>
	public abstract void Execute(object? parameter);
}