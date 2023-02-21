using CommunityToolkit.Mvvm.ComponentModel;

using System.Globalization;
using System.Linq;

namespace PalindromeFinder.Model;

/// <summary>
/// Class for check is word palindrome.
/// </summary>
public class Palindrome : ObservableObject
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
			SetProperty(ref _word, value);
			WordReverse = new string(Word.Reverse().ToArray());
			IsPalindrome = CheckPalindrome();
		}
	}

	/// <summary>
	/// Property for reverse word.
	/// </summary>
	public string WordReverse
	{
		get => _wordReverse;
		private set => SetProperty(ref _wordReverse, value);
	}

	/// <summary>
	/// Property for palindrome check result.
	/// </summary>
	public bool IsPalindrome
	{
		get => _isPalindrome;
		private set => SetProperty(ref _isPalindrome, value);
	}

	/// <summary>
	/// Constructor.
	/// </summary>
	/// <param name="word">Word for palindrome checking.</param>
	public Palindrome(string word = "")
	{
		Word = word;
	}

	/// <summary>
	/// Check is word palindrome or not.
	/// </summary>
	/// <param name="word">Word for palindrome checking.</param>
	/// <returns>Return true if a word is palindrome otherwise false.</returns>
	public bool CheckPalindrome()
	{
		int lexicalRelationship = CultureInfo.CurrentCulture.CompareInfo.Compare(Word,
																		WordReverse,
																		CompareOptions.IgnoreCase
																		| CompareOptions.IgnoreSymbols);

		return lexicalRelationship == 0;
	}
}