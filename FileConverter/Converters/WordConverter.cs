using Aspose.Words;
using Aspose.Words.Saving;

using System.Text;

namespace FileConverter
{
	public static class WordConverter
	{
		public static string GetLicenceDirectory()
		{
			var di = new DirectoryInfo(Directory.GetCurrentDirectory());
			return Path.Combine(di.Parent.Parent.Parent.FullName, "Licenses");
		}

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
		private static void ActivateAsposeWordsLicense()
		{
			// Aspose.Words.dll license only valid up to v13.8.0.0
			var license = new License();
#if DEBUG
			string licenseFileName = Path.Combine(GetLicenceDirectory(), "Aspose.Words.lic");
			license.SetLicense(licenseFileName);
#else
			license.SetLicense("Aspose.Words.lic");
#endif
		}

		private static List<string> GetSupportedFormats()
		{
			return new() { ".doc", ".docx" };
		}

		public static bool ToPdf(string inputPath, ref string outputPath, PdfPermissions? permissions = null, string userPassword = "", string ownerPassword = "")
		{
			try
			{
				var fiInput = new FileInfo(inputPath);
				if (!fiInput.Exists)
					throw new FileNotFoundException();
				else if(!GetSupportedFormats().Contains(fiInput.Extension))
					throw new Exception("Invalid file type.");

				ActivateAsposeWordsLicense();
				//string pdfFilePath = Path.ChangeExtension(Path.GetTempFileName(), "pdf");

				var pdfOptions = new PdfSaveOptions
				{
					JpegQuality = 70,
					TextCompression = PdfTextCompression.Flate,
					EmbedFullFonts = false,
					FontEmbeddingMode = PdfFontEmbeddingMode.EmbedAll,
					UseHighQualityRendering = false,
					UseCoreFonts = true,
					SaveFormat = SaveFormat.Pdf
				};

				if ((!string.IsNullOrEmpty(userPassword) || !string.IsNullOrEmpty(ownerPassword)) && permissions != null)
				{
					var encryptDetails = new PdfEncryptionDetails(userPassword, ownerPassword, PdfEncryptionAlgorithm.RC4_128)
					{
						Permissions = (PdfPermissions)permissions
					};
					pdfOptions.EncryptionDetails = encryptDetails;
				}

				// Prevents "System.NotSupportedException: No data is available for encoding 1252."
				// From https://stackoverflow.com/questions/50858209/
				// .NET Core supports only ASCII, ISO-8859-1 and Unicode encodings, whereas .NET Framework supports much more.
				// However, .NET Core can be extended to support additional encodings like Windows-1252, Shift-JIS, GB2312 by
				// registering the CodePagesEncodingProvider from the System.Text.Encoding.CodePages NuGet package.
				Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

				var doc = new Document(inputPath);
				doc.BuiltInDocumentProperties.Author = "DocumentConverter";
				doc.BuiltInDocumentProperties.Title = fiInput.Name;

				var builder = new DocumentBuilder(doc);
				outputPath = Path.ChangeExtension(Path.GetTempFileName(), ".pdf");
				SaveOutputParameters outParams = builder.Document.Save(outputPath, pdfOptions);

				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

	}
}
