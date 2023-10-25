using Microsoft.Win32;

namespace FileConverter
{
	public class RegistryHelper
	{
		/// <summary>
		///	Retrieves the value of an environment variable. Will attempt to read from the Windows Registry if not found.
		/// </summary>
		/// <param name="subKey"></param>
		/// <returns>A string with the value of the environment variable, or empty string if not found.</returns>
		public static string GetEnvironmentVariable(string key)
		{
			const string RegPath = @"SYSTEM\ControlSet001\Control\Session Manager\Environment";
			string value;

			try
			{
				// This will always return the actual value, whether or not the varibles have been "refreshed" in Windows
				value = (string)GetRegistryValue(RegistryHive.LocalMachine, RegPath, key);
			}
			catch (Exception ex)
			{
				// If there is a permissions issue, revert to the traditional method
				value = Environment.GetEnvironmentVariable(key);
			}

			return value ?? "";
		}

		public static object GetRegistryValue(RegistryHive hive, string subKey, string key)
		{
			// If you request a 64-bit view on a 32-bit operating system, the returned keys will be in the 32-bit view.
			var regkey = RegistryKey.OpenBaseKey(hive, RegistryView.Registry64)?.OpenSubKey(subKey);
			return regkey?.GetValue(key);
		}
	}
}
