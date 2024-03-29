﻿using PalindromeFinder.Model;

using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace PalindromeFinder.ViewModel;

/// <summary>
/// View model for Model and View communication.
/// </summary>
public class MainViewModel
{
	/// <summary>
	/// Representation of palindrome list for displaying in window.
	/// </summary>
	public ObservableCollection<PalindromeViewModel> PalindromeList { get; set;	}

	/// <summary>
	/// Conscructor without parameters.
	/// </summary>
	public MainViewModel()
	{
		PalindromeList = new();

		RemovePalindrome = new RelayCommand<object>((object? parameter) =>
		{
			if(parameter is PalindromeViewModel palindromeViewModel)
			{
				PalindromeList.Remove(palindromeViewModel);
			}
		});
		
		AddPalindrome = new RelayCommand(() =>
		{
			Palindrome palindrome = new Palindrome();
			PalindromeList.Add(new PalindromeViewModel(palindrome, RemovePalindrome));
		});
	}

	/// <summary>
	/// Add palindrome command.
	/// </summary>
	public ICommand AddPalindrome { get; }

	/// <summary>
	/// Remove cirtain palindrome command.
	/// </summary>
	public ICommand RemovePalindrome { get; }
}