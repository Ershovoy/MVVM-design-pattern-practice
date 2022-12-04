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
	/// Representation of filename list for displaying in window.
	/// </summary>
	private ObservableCollection<FileInfo> _filesInfo = new();

	/// <summary>
	/// Property for filename list.
	/// </summary>
	public ObservableCollection<FileInfo> FilesInfo
	{
		get => _filesInfo;
		set => _filesInfo = value;
	}

	/// <summary>
	/// Conscructor without parameters.
	/// </summary>
	public MainViewModel()
	{
		AddFileCommand = new RelayCommand((object? parameter) =>
		{
			var openFileDialog = new Microsoft.Win32.OpenFileDialog();

			bool? result = openFileDialog.ShowDialog();
			if (result == true)
			{
				string filename = openFileDialog.FileName;
				FileInfo fileInfo = new FileInfo(filename);
				FilesInfo.Add(fileInfo);
			}
		});

		RemoveFileCommand = new RelayCommand((object? parameter) =>
		{
			int index = System.Convert.ToInt32(parameter);
			if (index != -1)
			{
				FilesInfo.RemoveAt(index);
			}
		});
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