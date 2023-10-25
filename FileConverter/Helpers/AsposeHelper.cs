namespace FileConverter
{
	public static class AsposeHelper
	{
		/// <summary>Licenses the component</summary>
		/// <remarks>
		/// Tries to find the license in the following locations:
		///		1. Explicit path.
		///		2. The folder that contains the Aspose component assembly.
		///		3. The folder that contains the client’s calling assembly.
		///		4. The folder that contains the entry (startup) assembly.
		///		5. An embedded resource in the client’s calling assembly.
		///	Note: On the .NET Compact Framework, tries to find the license only in these locations:
		///		1. Explicit path.
		///		2. An embedded resource in the client’s calling assembly
		///	</remarks>
		///	<example>
		///	//Set the license for our Aspose.Words product by passing the local file system filename of a valid license file.
		///	string licenseFileName = Path.Combine(LicenseDir, "Aspose.Words.NET.lic");
		///	License license = new License();
		///	license.SetLicense(licenseFileName);
		///	
		///	// Create a copy of our license file in the binaries folder of our application.
		///	string licenseCopyFileName = Path.Combine(AssemblyDir, "Aspose.Words.NET.lic");
		///	File.Copy(licenseFileName, licenseCopyFileName);
		///
		///	// If we pass a file's name without a path,
		///	// the SetLicense will search several local file system locations for this file.
		///	// One of those locations will be the "bin" folder, which contains a copy of our license file.
		///	license.SetLicense("Aspose.Words.NET.lic");
		/// </example>
		/// <see href="https://reference.aspose.com/words/net/aspose.words/license/setlicense/" />

		private const string WordsLicenseFile = "Aspose.Words.lic";  // valid up to v13.8.0.0
		private const string CellsLicenseFile = "Aspose.Cells.lic";  // valid up to v7.5.3.0

		public enum LicenseType
		{
			Words = 0,
			Cells = 1
		}

		/// <summary>
		/// Licenses Aspose components
		/// </summary>
		/// <param name="type"></param>
		/// <returns>True if successful, otherwise false.</returns>
		/// <exception cref="ArgumentException"></exception>
		/// <exception cref="FileNotFoundException"></exception>
		public static bool SetLicense(LicenseType type)
		{
			try
			{
				// Get license from local file system (must set as environment variable)
				string licenseFolder = RegistryHelper.GetEnvironmentVariable("AsposeLicensePath") ?? "";
				string licenseFile = type switch
				{
					LicenseType.Words => WordsLicenseFile,
					LicenseType.Cells => CellsLicenseFile,
					_ => throw new ArgumentException($"Invalid Aspose License Type '{(int)type}'."),
				};
				string licensePath = Path.Combine(licenseFolder, licenseFile);

				if (!File.Exists(licenseFile))
					throw new FileNotFoundException($"Cannot locate license file '{licenseFile}'.");

				using (Stream stream = File.OpenRead(licenseFile))
				{
					var license = new Aspose.Words.License();
					license.SetLicense(stream);
				}
				return true;
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine(ex.ToString());
				return false;
			}
		}
	}
}
