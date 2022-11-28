using FileExtensionFilter.Model;

namespace FileExtensionFilter.Commands;

/// <summary>
/// Command realization for removing filename from list.
/// </summary>
public class RemoveFileCommand : BaseCommand
{
	/// <summary>
	/// On which model the command interact.
	/// </summary>
	private FilenameList _filenameList;

	/// <summary>
	/// Command method that executed to remove a filename from the list.
	/// </summary>
	/// <param name="parameter">Parameter passed from user interface.</param>
	public override void Execute(object? parameter)
	{
		try
		{
			int index = System.Convert.ToInt32(parameter);
			_filenameList.RemoveAt(index);
		}
		//TODO: Как обработать случай когда не выбран ни один элемент при удалении?
		catch
		{

		}
	}

	/// <summary>
	/// Command constructor.
	/// </summary>
	/// <param name="filenameList">List of filenames on which command interact.</param>
	public RemoveFileCommand(FilenameList filenameList)
	{
		_filenameList = filenameList;
	}
}