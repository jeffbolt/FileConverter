using System.Diagnostics;

namespace FileConverter
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

			string processName = Process.GetCurrentProcess().ProcessName;

			// Prevent more than one instance from running (see https://www.dotnetcurry.com/showarticle.aspx?ID=150) 
			using var mutex = new Mutex(true, processName, out bool instanceCountOne);
			if (instanceCountOne)
			{
				ApplicationConfiguration.Initialize();
				Application.Run(new frmMain());
				mutex.ReleaseMutex();
			}
			else
			{
				// Set focus to current window (see https://stackoverflow.com/questions/2315561)
				var process = Process.GetProcessesByName(processName).FirstOrDefault();
				if (process != null)
				{
					IntPtr ipHwnd = process.MainWindowHandle;
					Thread.Sleep(100);
					PInvoke.SetForegroundWindow(ipHwnd);

					// This method requires Interop.UIAutomationClient...
					//AutomationElement element = AutomationElement.FromHandle(process.MainWindowHandle);
					//element?.SetFocus();
				}
			}
		}
	}
}