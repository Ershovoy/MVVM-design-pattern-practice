namespace EventSystemPractice;

/// <summary>
/// Form for user interaction with contact information.
/// </summary>
public partial class EventForm : Form
{
	/// <summary>
	/// Which contact this form is link to.
	/// </summary>
	private Contact _contact;

	/// <summary>
	/// Property for contact.
	/// </summary>
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

	/// <summary>
	/// Form constructor with given subscribed contact and form title.
	/// </summary>
	/// <param name="subscribedContact">Subscribed contact.</param>
	/// <param name="formTitle">Form title.</param>
	public EventForm(Contact subscribedContact, string formTitle)
	{
		InitializeComponent();

		Contact = subscribedContact;
		Text = formTitle;
	}

	/// <summary>
	/// Invoke whenever full name of subscribed contact is changed.
	/// </summary>
	/// <param name="sender">Event sender.</param>
	/// <param name="e">Event arguments.</param>
	public void FullNameChanged(object? sender, EventArgs e)
	{
		if (sender is Contact contact)
		{
			FullNameTextBox.Text = contact.FullName;
		}
	}

	/// <summary>
	/// Invoke whenever phone number of subscribed contact is changed.
	/// </summary>
	/// <param name="sender">Event sender.</param>
	/// <param name="e">Event arguments.</param>
	public void PhoneNumberChanged(object? sender, EventArgs e)
	{
		if (sender is Contact contact)
		{
			PhoneNumberTextBox.Text = contact.PhoneNumber;
		}
	}

	/// <summary>
	/// Invoke whenever address of subscribed contact is changed.
	/// </summary>
	/// <param name="sender">Event sender.</param>
	/// <param name="e">Event arguments.</param>
	public void AddressChanged(object? sender, EventArgs e)
	{
		if (sender is Contact contact)
		{
			AddressTextBox.Text = contact.Address;
		}
	}

	/// <summary>
	/// Unsubscribe contact events. Raise whenever stored contact is changed.
	/// </summary>
	private void UnsubscribeContactEvents()
	{
		Contact.FullNameChanged    -= FullNameChanged;
		Contact.PhoneNumberChanged -= PhoneNumberChanged;
		Contact.AddressChanged     -= AddressChanged;
	}

	/// <summary>
	/// Invoke whenever content of text box related to full name is changed.
	/// </summary>
	/// <param name="sender">Event sender.</param>
	/// <param name="e">Event arguments.</param>
	private void FullNameTextBox_TextChanged(object sender, EventArgs e)
	{
		Contact.FullName = FullNameTextBox.Text;
	}

	/// <summary>
	/// Invoke whenever content of text box related to phone number is changed.
	/// </summary>
	/// <param name="sender">Event sender.</param>
	/// <param name="e">Event arguments.</param>
	private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
	{
		Contact.PhoneNumber = PhoneNumberTextBox.Text;
	}

	/// <summary>
	/// Invoke whenever content of text box related to address is changed.
	/// </summary>
	/// <param name="sender">Event sender.</param>
	/// <param name="e">Event arguments.</param>
	private void AddressTextBox_TextChanged(object sender, EventArgs e)
	{
		Contact.Address = AddressTextBox.Text;
	}

	/// <summary>
	/// Invoke during form closing.
	/// </summary>
	/// <param name="sender">Event sender.</param>
	/// <param name="e">Event arguments.</param>
	private void EventForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		UnsubscribeContactEvents();
	}

	/// <summary>
	/// Invoke after clicking close button.
	/// </summary>
	/// <param name="sender">Event sender.</param>
	/// <param name="e">Event arguments.</param>s
	private void CloseButton_Click(object sender, EventArgs e)
	{
		Close();
	}
}