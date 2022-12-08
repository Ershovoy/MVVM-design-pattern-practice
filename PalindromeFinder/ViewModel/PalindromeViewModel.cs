using PalindromeFinder.Model;

using System.Windows.Input;

namespace PalindromeFinder.ViewModel;

/// <summary>
/// View model for palindrome.
/// </summary
public class PalindromeViewModel
{
	/// <summary>
	/// Is it a alindrome or not.
	/// </summary>
	private Palindrome _palindrome;

	/// <summary>
	/// Property for palindrome.
	/// </summary>
	public Palindrome Palindrome
	{
		get => _palindrome;
		set => _palindrome = value;
	}

	/// <summary>
	/// Constructor with two parameters.
	/// </summary>
	/// <param name="palindrome">Palindrome.</param>
	/// <param name="removeCommand">Remove command event.</param>
	public PalindromeViewModel(Palindrome palindrome, ICommand removeCommand)
	{
		Palindrome = palindrome;
		RemovePalindrome = removeCommand;
	}

	/// <summary>
	/// Remove command.
	/// </summary>
	public ICommand RemovePalindrome { get; }
}