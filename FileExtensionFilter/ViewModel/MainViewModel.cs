using FileExtensionFilter.Commands;
using FileExtensionFilter.Model;
using System;
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
	private ObservableCollection<string> _filenames = new();

	/// <summary>
	/// Property for filename list.
	/// </summary>
	public ObservableCollection<string> Filenames
	{
		get => _filenames;
		set => _filenames = value;
	}

	/// <summary>
	/// Conscructor without parameters.
	/// </summary>
	public MainViewModel()
	{
		_filenameList.FilenameAdded   += FilenameList_FilenameAdded;
		_filenameList.FilenameRemoved += FilenameList_FilenameRemoved;

		AddFileCommand = new RelayCommand((object? parameter) =>
		{
			var openFileDialog = new Microsoft.Win32.OpenFileDialog();

			bool? result = openFileDialog.ShowDialog();
			if (result == true)
			{
				string filename = openFileDialog.SafeFileName;
				Filenames.Add(filename);
			}
		});

		RemoveFileCommand = new RelayCommand((object? parameter) =>
		{
			int index = System.Convert.ToInt32(parameter);
			if (index != -1)
			{
				Filenames.RemoveAt(index);
			}
		});
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
		Filenames.Add(filename);
	}

	/// <summary>
	/// Invoke whenever a file name is removed from storage.
	/// </summary>
	/// <param name="sender">Event sender.</param>
	/// <param name="index">Event argument.</param>
	private void FilenameList_FilenameRemoved(object? sender, int index)
	{
		Filenames.RemoveAt(index);
	}

	/// <summary>
	/// Add file command.
	/// </summary>
	public RelayCommand AddFileCommand { get; }

	/// <summary>
	/// Remove file command.
	/// </summary>
	public RelayCommand RemoveFileCommand { get; }
}