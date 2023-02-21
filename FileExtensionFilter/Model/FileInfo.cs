using System.ComponentModel;

namespace FileExtensionFilter.Model;

/// <summary>
/// Store info about cirtain file.
/// </summary>
public class FileInfo : INotifyPropertyChanged
{
	/// <summary>
	/// Name of file without extension.
	/// </summary>
	private string _filename;

	/// <summary>
	/// File extension (including the period ".").
	/// </summary>
	private string _extension;

	/// <summary>
	/// Property for filename.
	/// </summary>
	public string Filename
	{
		get => _filename;
		set
		{
			_filename = value;
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Filename)));
		}
	}

	/// <summary>
	/// Property for file exntension.
	/// </summary>
	public string Extension
	{
		get => _extension;
		set
		{
			_extension = value;
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Extension)));
		}
	}

	/// <summary>
	/// Constuctor with one parameter.
	/// </summary>
	/// <param name="filepath">Path to file for storing his information.</param>
	public FileInfo(string filepath = "")
	{
		Filename  = System.IO.Path.GetFileNameWithoutExtension(filepath);
		Extension = System.IO.Path.GetExtension(filepath);
	}

	/// <summary>
	/// Invoke whenever a property of file info changed to notify subscribers.
	/// </summary>
	public event PropertyChangedEventHandler? PropertyChanged;
}