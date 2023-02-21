namespace EventSystemPractice;

internal static class Program
{
	/// <summary>
	///  The main entry point for the application.
	/// </summary>
	[STAThread]
	static void Main()
	{
		// To customize application configuration such as set high DPI settings or default font,
		// see https://aka.ms/applicationconfiguration.
		ApplicationConfiguration.Initialize();

		Contact contact = new();
		for(int i = 0; i < 2; i++)
		{
			EventForm secondaryForm = new(contact, "Secondary Form");
			secondaryForm.Show();
		}

		EventForm mainForm = new(contact, "Main Form");
		Application.Run(mainForm);
	}
}