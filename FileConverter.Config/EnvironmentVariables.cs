using Microsoft.Win32;

namespace FileConverter.Config
{
	public static class EnvironmentVariables
	{
		/// <summary>
		/// Retrieves the value of an environment variable. Will attempt to read from the Windows Registry if not found.
		/// </summary>
		/// <param name="subKey"></param>
		/// <returns>A string with the value of the environment variable, or empty string if not found.</returns>
		public static string GetEnvironmentVariable(string subKey)
		{
			const string AppName = "FileConverter";
			const string RegPath = @"SYSTEM\ControlSet001\Control\Session Manager\Environment";
			string key = string.Concat(AppName, subKey);
			var value = Environment.GetEnvironmentVariable(key) ??
						Registry.GetRegistryValue(RegistryHive.LocalMachine, RegPath, key);
			return value?.ToString() ?? "";
		}
	}
}