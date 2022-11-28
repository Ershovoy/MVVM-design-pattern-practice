using System;
using System.Collections.Generic;

namespace FileExtensionFilter.Model;

/// <summary>
/// Main storage of file names.
/// </summary>
public class FilenameList : List<string>
{
	/// <summary>
	/// Add file name to the list.
	/// </summary>
	/// <param name="filename">File name.</param>
	public new void Add(string filename)
	{
		base.Add(filename);
		FilenameAdded?.Invoke(this, filename);
	}

	/// <summary>
	/// Remove file name form the list at certain position.
	/// </summary>
	/// <param name="index">Position of deleted file name</param>
	public new void RemoveAt(int index)
	{
		base.RemoveAt(index);
		FilenameRemoved?.Invoke(this, index);
	}

	/// <summary>
	/// Invoke whenever a file name is added to storage.
	/// </summary>
	public event EventHandler<string>? FilenameAdded;

	/// <summary>
	/// Invoke whenever a file name is removed from storage.
	/// </summary>
	public event EventHandler<int>? FilenameRemoved;
}