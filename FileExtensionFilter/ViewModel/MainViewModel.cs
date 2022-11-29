using FileExtensionFilter.Commands;
using FileExtensionFilter.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace FileExtensionFilter.ViewModel;

/// <summary>
/// View model for Model and View communication.
/// </summary>
public class MainViewModel
{
	/// <summary>
	/// Binded filename list.
	/// </summary>
	private FilenameList _filenameList = new();

	/// <summary>
	/// Representation of filename list for displaying in window.
	/// </summary>
	private ObservableCollection<string> _fileNames = new();

	/// <summary>
	/// Property for filename list.
	/// </summary>
	public ObservableCollection<string> FileNames
	{
		get { return _fileNames; }
		set { _fileNames = value; }
	}

	/// <summary>
	/// Conscructor without parameters.
	/// </summary>
	public MainViewModel()
	{
		_filenameList.FilenameAdded   += FilenameList_FilenameAdded;
		_filenameList.FilenameRemoved += FilenameList_FilenameRemoved;

		AddFileCommand    = new AddFileCommand(_filenameList);
		RemoveFileCommand = new RemoveFileCommand(_filenameList);
	}

	/// <summary>
	/// Destructor.
	/// </summary>
	~MainViewModel()
	{
		_filenameList.FilenameAdded   -= FilenameList_FilenameAdded;
		_filenameList.FilenameRemoved -= FilenameList_FilenameRemoved;
	}

	/// <summary>
	/// Invoke whenever a file name is added to storage.
	/// </summary>
	/// <param name="sender">Event sender.</param>
	/// <param name="filename">Event argument.</param>
	private void FilenameList_FilenameAdded(object? sender, string filename)
	{
		FileNames.Add(filename);
	}

	/// <summary>
	/// Invoke whenever a file name is removed from storage.
	/// </summary>
	/// <param name="sender">Event sender.</param>
	/// <param name="index">Event argument.</param>
	private void FilenameList_FilenameRemoved(object? sender, int index)
	{
		FileNames.RemoveAt(index);
	}

	/// <summary>
	/// Add file command.
	/// </summary>
	public ICommand AddFileCommand { get; }

	/// <summary>
	/// Remove file command.
	/// </summary>
	public ICommand RemoveFileCommand { get; }
}