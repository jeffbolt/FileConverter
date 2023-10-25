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

		public static string GetLicenceDirectory()
		{
			var di = new DirectoryInfo(Directory.GetCurrentDirectory());
			return Path.Combine(di.Parent.Parent.Parent.FullName, "Licenses");
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

		/// <summary>Extension method for calling GetFileSizeSuffix() from a FileInfo object</summary>
		/// <param name="fileInfo">FileInfo object</param>
		/// <param name="decimalPlaces">Number of decimal places to display</param>
		/// <returns></returns>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public static string FormatFileSize(this FileInfo fileInfo, int decimalPlaces = 0)
		{
			return FormatFileSize(fileInfo.Length, decimalPlaces);
		}

		/// <summary>Format the nubmer of bytes to the nearest whole number byte magnitude</summary>
		/// <param name="value">Number of bytes</param>
		/// <param name="decimalPlaces">Number of decimal places to display</param>
		/// <returns>Value formatted to number of decimal places with unit suffix</returns>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public static string FormatFileSize(long value, int decimalPlaces = 0)
		{
			// https://stackoverflow.com/questions/14488796/does-net-provide-an-easy-way-convert-bytes-to-kb-mb-gb-etc
			string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

			if (decimalPlaces < 0) throw new ArgumentOutOfRangeException(nameof(decimalPlaces));
			if (value < 0) return "-" + FormatFileSize(-value, decimalPlaces);
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

		public static string FormatFileSize2(long bytes, int decimalPlaces = 0)
		{
			// https://stackoverflow.com/questions/14488796/does-net-provide-an-easy-way-convert-bytes-to-kb-mb-gb-etc
			var unit = 1024;
			if (bytes < unit) return $"{bytes} B";

			var exp = (int)(Math.Log(bytes) / Math.Log(unit));
			//return $"{bytes / Math.Pow(unit, exp):F2} {"KMGTPE"[exp - 1]}B";
			return string.Format("{0:F" + decimalPlaces + "} {1}", bytes / Math.Pow(unit, exp), $"{"KMGTPE"[exp - 1]}B");
		}

		public static string ConvertToBinary(this FileInfo fileInfo)
		{
			if (File.Exists(fileInfo.FullName))
			{
				byte[] bytes = File.ReadAllBytes(fileInfo.FullName);
				return BitConverter.ToString(bytes).Replace("-", "");
			}
			else
			{
				throw new FileNotFoundException($"Could not open file '{fileInfo.FullName}'.");
			}
		}

		public static string ConvertToBase64(this FileInfo fileInfo)
		{
			if (File.Exists(fileInfo.FullName))
			{
				byte[] bytes = File.ReadAllBytes(fileInfo.FullName);
				return Convert.ToBase64String(bytes);
			}
			else
			{
				throw new FileNotFoundException($"Could not open file '{fileInfo.FullName}'.");
			}
		}

		public static void SaveAsBinary(this FileInfo fileInfo, string outputFilePath)
		{
			string fileContents = fileInfo.ConvertToBinary();
			if (!string.IsNullOrEmpty(fileContents))
				File.WriteAllText(outputFilePath, fileContents);
		}
	}
}