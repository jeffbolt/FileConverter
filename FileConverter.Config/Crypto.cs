using System.Diagnostics;
using System.Security.Cryptography;

namespace FileConverter.Config
{
	public static class Crypto
	{
		//public static string ComputeCrc32(uint crc, uint data)
		//{
		//	var crc32 = new Crc32();
		//	string hash = string.Empty;
		//	using (FileStream fs = File.Open(path, FileMode.Open))
		//	{
		//		foreach (byte b in crc32.ComputeHash(fs))
		//		{
		//			hash += b.ToString("x2").ToLower();
		//		}
		//		Console.WriteLine("CRC-32 is {0}", hash);
		//	}
		//	return value.ToString();
		//}

		public async static void RunDemo()
		{
			const string folder = @"C:\Users\jbolt\Documents\GitHub\jeffbolt\FileConverter\Images\temp";
			//string startupPath = AssemblyHelper.GetStartupPath();

			foreach (var file in Directory.EnumerateFiles(folder))
			{
				var crc = await ComputeCrc32(file);
				Debug.WriteLine($"The CRC32 hash of {file} is {crc}.");

				string[] algorithmNames =
				{
					HashAlgorithmName.MD5.Name,
					HashAlgorithmName.SHA1.Name,
					HashAlgorithmName.SHA256.Name,
					HashAlgorithmName.SHA384.Name,
					HashAlgorithmName.SHA512.Name
				};
				foreach (var algorithmName in algorithmNames)
				{
					string hash = await ComputeHash(file, algorithmName);
					Debug.WriteLine($"The {algorithmName} hash of \"{file}\" = {hash}.");
				}
			}
		}

		public async static Task<string> ComputeCrc32(string path)
		{
			using var stream = new FileStream(path, FileMode.Open);
			var crc32 = new System.IO.Hashing.Crc32();
			await crc32.AppendAsync(stream);
			var bytes = crc32.GetCurrentHash();
			// WinRAR format - validate with https://crc32.online/
			return BitConverter.ToString(bytes.Reverse().ToArray()).Replace("-", "");
		}

		public async static Task<string> ComputeHash(string path, string algorithmName)
		{
			using var stream = new FileStream(path, FileMode.Open);
			var bytes = algorithmName switch
			{
				"MD5" => await MD5.Create().ComputeHashAsync(stream),
				"SHA1" => await SHA1.Create().ComputeHashAsync(stream),
				"SHA256" => await SHA256.Create().ComputeHashAsync(stream),
				"SHA384" => await SHA384.Create().ComputeHashAsync(stream),
				"SHA512" => await SHA512.Create().ComputeHashAsync(stream),
				_ => throw new ArgumentOutOfRangeException($"Invalid Algorithm Name: '{algorithmName}'."),
			};
			return BitConverter.ToString(bytes).Replace("-", "").ToLower();
		}

		//public static string ComputeSha1(string path)
		//{
		//	using var stream = new FileStream(path, FileMode.Open);
		//	var ca = SHA1.Create();
		//	var bytes = ca.ComputeHash(stream);
		//	return BitConverter.ToString(bytes).Replace("-", "").ToLower();
		//}

		//public static string ComputeSha256(string path)
		//{
		//	using var stream = new FileStream(path, FileMode.Open);
		//	var ca = SHA256.Create();
		//	var bytes = ca.ComputeHash(stream);
		//	return BitConverter.ToString(bytes).Replace("-", "").ToLower();
		//}

		public static void EncryptFile(string path)
		{
			File.Encrypt(path);
		}

		public static void DecryptFile(string path)
		{
			File.Decrypt(path);
		}

		public static char[] GetInvalidPathChars(string path)
		{
			// Get a list of invalid path characters.
			char[] invalidPathChars = Path.GetInvalidPathChars();
#if DEBUG
			Debug.WriteLine("The following characters are invalid in a path:");
			ShowChars(invalidPathChars);
#endif
			return invalidPathChars;
		}

		public static char[] GetInvalidFileNameChars(string path)
		{
			// Get a list of invalid path characters.
			char[] invalidFileChars = Path.GetInvalidFileNameChars();
#if DEBUG
			Debug.WriteLine("The following characters are invalid in a filename:");
			ShowChars(invalidFileChars);
#endif
			return invalidFileChars;
		}

		public static void ShowChars(char[] charArray)
		{
			Debug.WriteLine("Char\tHex Value");
			// Display each invalid character to the console.
			foreach (char someChar in charArray)
			{
				if (char.IsWhiteSpace(someChar))
					Debug.WriteLine(",\t{0:X4}", (int)someChar);
				else
					Debug.WriteLine("{0:c},\t{1:X4}", someChar, (int)someChar);
			}
		}
	}
}
