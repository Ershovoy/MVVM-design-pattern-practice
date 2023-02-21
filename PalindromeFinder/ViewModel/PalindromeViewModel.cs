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
	public Palindrome Palindrome { get; set; }

	/// <summary>
	/// Constructor with two parameters.
	/// </summary>
	/// <param name="palindrome">Palindrome.</param>
	/// <param name="removeCommand">Remove command event.</param>
	public PalindromeViewModel(Palindrome palindrome, ICommand removeCommand)
	{
		Palindrome = new();

		Palindrome = palindrome;
		RemovePalindrome = removeCommand;
	}

	/// <summary>
	/// Remove command.
	/// </summary>
	public ICommand RemovePalindrome { get; }
}