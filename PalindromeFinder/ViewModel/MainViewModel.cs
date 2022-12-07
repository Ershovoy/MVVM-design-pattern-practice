﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PalindromeFinder.Model;

namespace PalindromeFinder.ViewModel;

/// <summary>
/// View model for Model and View communication.
/// </summary>
public class MainViewModel
{
	/// <summary>
	/// Representation of palindrome list for displaying in window.
	/// </summary>
	private ObservableCollection<Palindrome> _palindromeList = new();

	/// <summary>
	/// Property for palindrome list.
	/// </summary>
	public ObservableCollection<Palindrome> PalindromeList
	{
		get => _palindromeList;
		set => _palindromeList = value;
	}

	/// <summary>
	/// Conscructor without parameters.
	/// </summary>
	public MainViewModel()
	{
		AddPalindrome = new RelayCommand(() =>
		{
			PalindromeList.Add(new Palindrome());
		});

		RemovePalindrome = new RelayCommand<object>((object? obj) =>
		{
			if (obj is int index)
			{
				if (index != -1)
				{
					PalindromeList.RemoveAt(index);
				}
			}
		});
	}

	/// <summary>
	/// Add palindrome command.
	/// </summary>
	public ICommand AddPalindrome { get; }

	/// <summary>
	/// Remove palindrome command.
	/// </summary>
	public ICommand RemovePalindrome { get; }
}