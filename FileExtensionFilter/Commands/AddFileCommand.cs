using FileExtensionFilter.Model;

namespace FileExtensionFilter.Commands;

/// <summary>
/// Command realization for adding a new filename.
/// </summary>
public class AddFileCommand : BaseCommand
{
	/// <summary>
	/// On which model the command interact.
	/// </summary>
	private FilenameList _filenameList;

	/// <summary>
	/// Command method that executed to add a filename to the list.
	/// </summary>
	/// <param name="parameter">Parameter passed from user interface.</param>
	public override void Execute(object? parameter)
	{
		var openFileDialog = new Microsoft.Win32.OpenFileDialog();

		bool? result = openFileDialog.ShowDialog();
		if (result == true)
		{
			string filename = openFileDialog.SafeFileName;
			_filenameList.Add(filename);
		}
	}

	/// <summary>
	/// Command constructor.
	/// </summary>
	/// <param name="filenameList">List of filenames on which command interact.</param>
	public AddFileCommand(FilenameList filenameList)
	{
		_filenameList = filenameList;
	}
}