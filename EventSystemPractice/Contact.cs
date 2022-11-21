namespace EventSystemPractice;

public class Contact
{
	private string _fullName    = "";

	private string _phoneNumber = "";

	private string _address     = "";

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

	public event EventHandler? FullNameChanged;

	public event EventHandler? PhoneNumberChanged;

	public event EventHandler? AddressChanged;
}