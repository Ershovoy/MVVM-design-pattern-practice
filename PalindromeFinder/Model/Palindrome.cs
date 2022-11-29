﻿using System.Globalization;
using System.Linq;

namespace PalindromeFinder.Model;

/// <summary>
/// Class for check is word palindrome.
/// </summary>
public class Palindrome
{
	/// <summary>
	/// Store word for palindrome checking.
	/// </summary>
	private string _word;

	/// <summary>
	/// Reverse word used for comparison with original.
	/// </summary>
	private string _wordReverse;

	/// <summary>
	/// Result of palindrom checking.
	/// </summary>
	private bool _isPalindrome;

	/// <summary>
	/// Property for word.
	/// </summary>
	public string Word
	{
		get => _word;
		set
		{
			_word = value;
			_wordReverse = new string(_word.Reverse().ToArray());
			int result = CultureInfo.CurrentCulture.CompareInfo.Compare(Word,
																		WordReverse,
																		CompareOptions.IgnoreCase
																		| CompareOptions.IgnoreSymbols);
			_isPalindrome = result == 0;
		}
	}

	/// <summary>
	/// Property for reverse word.
	/// </summary>
	public string WordReverse
	{
		get => _wordReverse;
	}

	/// <summary>
	/// Property for palindrome check result.
	/// </summary>
	public bool IsPalindrome
	{
		get => _isPalindrome;
	}

	/// <summary>
	/// Constructor.
	/// </summary>
	/// <param name="word">Word for palindrome checking.</param>
	public Palindrome(string word = "")
	{
		Word = word;
	}
}