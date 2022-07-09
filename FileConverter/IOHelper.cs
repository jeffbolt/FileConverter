using System.Reflection;

namespace FileConverter
{
	public static class IOHelper
	{
		public static string GetCurrentDirectory()
		{
			return Directory.GetCurrentDirectory();
		}

		public static string GetBaseDirectory()
		{
			return Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase).Replace(@"file:\", "");
		}

		public static string GetTempDirectory()
		{
			return Path.Combine(Directory.GetParent(GetBaseDirectory()).Parent.FullName, "Temp");
		}

		public static string GetFileExtension(string fileName)
		{
			var objFileInfo = new FileInfo(fileName);
			return objFileInfo.Extension;
		}

		public static string GetMimeContentType(string mimeType)
		{
			// Return the file extension part of the MIME string (i.e. "image/pjpeg")
			var arrKeys = mimeType.Split('/');
			if (arrKeys.Length == 2)
				return arrKeys[1].Trim();
			else
				return "";
		}

		public static string GetFileSizeSuffix(long value, int decimalPlaces = 0)
		{
			// https://stackoverflow.com/questions/14488796/does-net-provide-an-easy-way-convert-bytes-to-kb-mb-gb-etc#14488941
			string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

			if (decimalPlaces < 0) throw new ArgumentOutOfRangeException("decimalPlaces");
			if (value < 0) return "-" + GetFileSizeSuffix(-value, decimalPlaces);
			if (value == 0) return string.Format("{0:n" + decimalPlaces + "} bytes", 0);

			// mag is 0 for bytes, 1 for KB, 2, for MB, etc.
			int mag = (int)Math.Log(value, 1024);

			// 1L << (mag * 10) == 2 ^ (10 * mag) 
			// [i.e. the number of bytes in the unit corresponding to mag]
			decimal adjustedSize = (decimal)value / (1L << (mag * 10));

			// make adjustment when the value is large enough that it would round up to 1000 or more
			if (Math.Round(adjustedSize, decimalPlaces) >= 1000)
			{
				mag += 1;
				adjustedSize /= 1024;
			}

			return string.Format("{0:n" + decimalPlaces + "} {1}", adjustedSize, SizeSuffixes[mag]);
		}

		public static string ConvertToBinary(string path)
		{
			if (File.Exists(path))
			{
				byte[] bytes = File.ReadAllBytes(path);
				return BitConverter.ToString(bytes).Replace("-", "");
			}
			else
			{
				throw new FileNotFoundException($"Could not open file '{path}'.");
			}
		}

		public static string ConvertToBase64(string path)
		{
			if (File.Exists(path))
			{
				byte[] bytes = File.ReadAllBytes(path);
				return Convert.ToBase64String(bytes);
			}
			else
			{
				throw new FileNotFoundException($"Could not open file '{path}'.");
			}
		}

		public static void SaveAsBinary(string inputFilePath, string outputFilePath)
		{
			string fileContents = ConvertToBinary(inputFilePath);
			if (!string.IsNullOrEmpty(fileContents))
				File.WriteAllText(outputFilePath, fileContents);
		}
	}
}