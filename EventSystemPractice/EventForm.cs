namespace EventSystemPractice;

public partial class EventForm : Form
{
	private Contact _contact;

	public Contact Contact
	{
		get => _contact;
		set
		{
			if (_contact is not null)
			{
				UnsubscribeContactEvents();
			}
			_contact = value;
			_contact.FullNameChanged    += FullNameChanged;
			_contact.PhoneNumberChanged += PhoneNumberChanged;
			_contact.AddressChanged     += AddressChanged;
		}
	}

	public EventForm(Contact subscribedContact, string formTitle)
	{
		InitializeComponent();

		Contact = subscribedContact;
		Text = formTitle;
	}

	public void FullNameChanged(object? sender, EventArgs e)
	{
		if (sender is Contact contact)
		{
			FullNameTextBox.Text = contact.FullName;
		}
	}

	public void PhoneNumberChanged(object? sender, EventArgs e)
	{
		if (sender is Contact contact)
		{
			PhoneNumberTextBox.Text = contact.PhoneNumber;
		}
	}

	public void AddressChanged(object? sender, EventArgs e)
	{
		if (sender is Contact contact)
		{
			AddressTextBox.Text = contact.Address;
		}
	}

	private void UnsubscribeContactEvents()
	{
		Contact.FullNameChanged    -= FullNameChanged;
		Contact.PhoneNumberChanged -= PhoneNumberChanged;
		Contact.AddressChanged     -= AddressChanged;
	}

	private void FullNameTextBox_TextChanged(object sender, EventArgs e)
	{
		Contact.FullName = FullNameTextBox.Text;
	}

	private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
	{
		Contact.PhoneNumber = PhoneNumberTextBox.Text;
	}

	private void AddressTextBox_TextChanged(object sender, EventArgs e)
	{
		Contact.Address = AddressTextBox.Text;
	}

	private void EventForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		UnsubscribeContactEvents();
	}

	private void CloseButton_Click(object sender, EventArgs e)
	{
		Close();
	}
}