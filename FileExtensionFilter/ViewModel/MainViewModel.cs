using FileExtensionFilter.Commands;
using FileExtensionFilter.Model;

using System.Collections.ObjectModel;
using Microsoft.Win32;

namespace FileExtensionFilter.ViewModel;

/// <summary>
/// View model for Model and View communication.
/// </summary>
public class MainViewModel
{
	/// <summary>
	/// Representation of files info list for displaying in window.
	/// </summary>
	public ObservableCollection<FileInfoViewModel> FilesInfo { get; set; }

	/// <summary>
	/// Conscructor without parameters.
	/// </summary>
	public MainViewModel()
	{
		FilesInfo = new();

		RemoveFileCommand = new RelayCommand((object? parameter) =>
		{
			if (parameter is FileInfoViewModel fileInfoViewModel)
			{
				FilesInfo.Remove(fileInfoViewModel);
			}
		});

		AddFileCommand = new RelayCommand((object? parameter) =>
		{
			var fileDialog = new OpenFileDialog();
			bool? result = fileDialog.ShowDialog();
			if (result is not null && result == true)
			{
				string filename = fileDialog.FileName;
				var fileInfo = new FileInfo(filename);
				var fileInfoViewModel = new FileInfoViewModel(fileInfo, RemoveFileCommand);
				FilesInfo.Add(fileInfoViewModel);
			}
		});
	}

	/// <summary>
	/// Add file info command.
	/// </summary>
	public RelayCommand AddFileCommand { get; }

	/// <summary>
	/// Remove file info command.
	/// </summary>
	public RelayCommand RemoveFileCommand { get; }
}