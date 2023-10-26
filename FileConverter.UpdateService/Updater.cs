using FileConverter.Config;

using Newtonsoft.Json;

using RestSharp;

using System.Diagnostics;
using System.Net;

namespace FileConverter.UpdateService
{
	public static class Updater
	{
		public async static Task<GitHubRelease?> GetLatestRelease()
		{
			// GitHub REST API https://docs.github.com/en/rest/
			try
			{
				const string GitHubLastestRelease = "/releases/latest";
				string repoUrl = EnvironmentVariables.GetEnvironmentVariable("GitHubApiUrl");
				string latestReleaseUrl = string.Concat(repoUrl, GitHubLastestRelease);
				string token = EnvironmentVariables.GetEnvironmentVariable("GitHubApiToken");
				
				using var restClient = new RestClient();
				restClient.AcceptedContentTypes = new[] { "application/vnd.github+json" };
				restClient.AddDefaultHeader("Authorization", $"Bearer {token}");
				var response = await restClient.ExecuteAsync(new RestRequest(latestReleaseUrl, Method.Get));
				if (response?.StatusCode == HttpStatusCode.OK && !string.IsNullOrEmpty(response?.Content))
				{
					var release = JsonConvert.DeserializeObject<GitHubRelease>(response.Content);
					return release;
				}
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine(ex.ToString());
			}

			return null;
		}

		public static async Task<bool> DownloadAssets(List<GitHubAsset> assets, bool runInstaller = false)
		{
			try
			{
				string folderName = string.Concat("FileConverter", Guid.NewGuid().ToString().ToUpper());
				string path = Path.Combine(Path.GetTempPath(), folderName);
				if (!Directory.Exists(path)) Directory.CreateDirectory(path);
				string setupFilePath = "";

				foreach (GitHubAsset asset in assets)
				{
					string fileName = asset.Name;
					string filePath = Path.Combine(path, fileName);
					string url = asset.BrowserDownloadUrl.AbsoluteUri;
					var request = new RestRequest
					{
						Method = Method.Get,
						Resource = url
					};
					using var restClient = new RestClient(url);
					restClient.AcceptedContentTypes = new[] { asset.ContentType };
					var cancellationToken = new CancellationToken();
					cancellationToken.ThrowIfCancellationRequested();
					byte[] bytes = await restClient.DownloadDataAsync(request, cancellationToken);
					File.WriteAllBytes(filePath, bytes);

					if (fileName.ToLower() == "setup.exe")
						setupFilePath = filePath;
				}

				if(File.Exists(setupFilePath))
				{
					if (runInstaller)
						Process.Start(setupFilePath);
					return true;
				}
				else
				{
					throw new FileNotFoundException($"Unable to locate setup.exe in folder '{path}'.");
				}			
			}
			catch (OperationCanceledException exCancel)
			{
				Console.Error.WriteLine(exCancel.ToString());
				return false;
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine(ex.ToString());
				return false;
			}
		}

		#region Old Code
		//public static GitHubRelease? GetLatestRelease()
		//{
		//	// GitHub REST API https://docs.github.com/en/rest/
		//	try
		//	{
		//		string ApiUrl = EnvironmentVariables.GetEnvironmentVariable("GitHubApiUrl");
		//		string ApiToken = EnvironmentVariables.GetEnvironmentVariable("GitHubApiToken");

		//		using var restClient = new RestClient();
		//		restClient.AcceptedContentTypes = new[] { "application/vnd.github+json" };
		//		restClient.AddDefaultHeader("Authorization", $"Bearer {ApiToken}");
		//		var response = restClient.Execute(new RestRequest(ApiUrl, Method.Get));
		//		if (response?.StatusCode == HttpStatusCode.OK && !string.IsNullOrEmpty(response?.Content))
		//		{
		//			var release = JsonConvert.DeserializeObject<GitHubRelease>(response.Content);
		//			return release;
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		Console.WriteLine(ex.ToString());
		//	}

		//	return null;
		//}

		//public static GitHubRelease? GetLatestRelease()
		//{
		//	using var httpClient = new HttpClient();
		//	try
		//	{
		//		//httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",
		//		//	Convert.ToBase64String(Encoding.ASCII.GetBytes(ApiToken)));
		//		httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {ApiToken}");
		//		//httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
		//		//	"Authorization", Convert.ToBase64String(Encoding.ASCII.GetBytes("Bearer" + ApiToken)));
		//		//httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
		//		var response = httpClient.GetStringAsync(new Uri(ApiUrl)).Result;
		//		var release = JsonConvert.DeserializeObject<GitHubRelease>(response);
		//		return release;
		//	}
		//	catch (Exception ex)
		//	{
		//		Console.WriteLine(ex.ToString());
		//		return null;
		//	}
		//}
		#endregion
	}
}