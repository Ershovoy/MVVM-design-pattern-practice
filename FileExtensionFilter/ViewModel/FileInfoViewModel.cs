using FileExtensionFilter.Commands;
using FileExtensionFilter.Model;

namespace FileExtensionFilter.ViewModel;

/// <summary>
/// View model for file info.
/// </summary>
public class FileInfoViewModel
{
	/// <summary>
	/// Store info about file.
	/// </summary>
	public FileInfo FileInfo { get;	set; }

	/// <summary>
	/// Constructor with two parameters.
	/// </summary>
	/// <param name="fileInfo">File info.</param>
	/// <param name="removeCommand">Remove command event.</param>
	public FileInfoViewModel(FileInfo fileInfo, RelayCommand removeCommand)
	{
		FileInfo = fileInfo;
		RemoveCommand = removeCommand;
	}

	/// <summary>
	/// Remove file info command.
	/// </summary>
	public RelayCommand RemoveCommand { get; }
}