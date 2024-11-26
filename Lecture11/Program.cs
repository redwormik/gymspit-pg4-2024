namespace Lecture11
{
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
			
			Form welcomeForm = new WelcomeForm();
			Application.Run(welcomeForm);
			
			if (welcomeForm.DialogResult == DialogResult.Continue) {
				TodoManager todoManager = new TodoManager();
				Application.Run(new TodoForm(todoManager));
			}
		}
	}
}
