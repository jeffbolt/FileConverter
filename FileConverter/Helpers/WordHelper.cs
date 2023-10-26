using Aspose.Words;
using Aspose.Words.Saving;

using System.Text;

namespace FileConverter
{
	public static class WordHelper
	{
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
				else if (!GetSupportedFormats().Contains(fiInput.Extension))
					throw new Exception("Invalid file type.");
				else if (!AsposeHelper.SetLicense(AsposeHelper.LicenseType.Words))
					throw new Exception("Could not activate Aspose.Words license.");

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
				Console.Error.WriteLine(ex.ToString());
				return false;
			}
		}

	}
}
