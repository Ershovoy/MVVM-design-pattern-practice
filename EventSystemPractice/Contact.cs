namespace EventSystemPractice;

/// <summary>
/// Represent contact information.
/// </summary>
public class Contact
{
	/// <summary>
	/// Full name of contact.
	/// </summary>
	private string _fullName    = "";

	/// <summary>
	/// Phone number of contact.
	/// </summary>
	private string _phoneNumber = "";

	/// <summary>
	/// Address of contact.
	/// </summary>
	private string _address     = "";

	/// <summary>
	/// Property for full name.
	/// </summary>
	public string FullName
	{
		get => _fullName;
		set
		{
			if (value == _fullName)
			{
				return;
			}
			_fullName = value;
			FullNameChanged?.Invoke(this, EventArgs.Empty);
		}
	}

	/// <summary>
	/// Property for phone number.
	/// </summary>
	public string PhoneNumber
	{
		get => _phoneNumber;
		set
		{
			if (value == _phoneNumber)
			{
				return;
			}
			_phoneNumber = value;
			PhoneNumberChanged?.Invoke(this, EventArgs.Empty);
		}
	}

	/// <summary>
	/// Property for address.
	/// </summary>
	public string Address
	{
		get => _address;
		set
		{
			if (value == _address)
			{
				return;
			}
			_address = value;
			AddressChanged?.Invoke(this, EventArgs.Empty);
		}
	}

	/// <summary>
	/// Invoke whenever full name of contact is changed.
	/// </summary>
	public event EventHandler? FullNameChanged;

	/// <summary>
	/// Invoke whenever phone number of contact is changed.
	/// </summary>
	public event EventHandler? PhoneNumberChanged;

	/// <summary>
	/// Invoke whenever address of contact is changed.
	/// </summary>
	public event EventHandler? AddressChanged;
}