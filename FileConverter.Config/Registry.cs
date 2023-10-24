using Microsoft.Win32;

namespace FileConverter.Config
{
	public static class Registry
	{
		/// <summary>
		/// Retrieves the value of a Windows Registry key.
		/// </summary>
		/// <param name="hive"></param>
		/// <param name="subKey"></param>
		/// <param name="key"></param>
		/// <returns>The value associated with the RegistryHive/subkey/key, or null if not found.</returns>
		public static object GetRegistryValue(RegistryHive hive, string subKey, string key)
		{
			// If you request a 64-bit view on a 32-bit operating system, the returned keys will be in the 32-bit view.
			var regkey = RegistryKey.OpenBaseKey(hive, RegistryView.Registry64)?.OpenSubKey(subKey);
			return regkey?.GetValue(key);
		}
	}
}
