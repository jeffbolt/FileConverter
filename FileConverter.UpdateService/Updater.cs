using FileConverter.Config;

using Newtonsoft.Json;

using RestSharp;

using System.Net;

namespace FileConverter.UpdateService
{
	public static class Updater
	{
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

		public async static Task<GitHubRelease?> GetLatestReleaseAsync()
		{
			// GitHub REST API https://docs.github.com/en/rest/
			try
			{
				string ApiUrl = EnvironmentVariables.GetEnvironmentVariable("GitHubApiUrl");
				string ApiToken = EnvironmentVariables.GetEnvironmentVariable("GitHubApiToken");

				using var restClient = new RestClient();
				restClient.AcceptedContentTypes = new[] { "application/vnd.github+json" };
				restClient.AddDefaultHeader("Authorization", $"Bearer {ApiToken}");
				var response = await restClient.ExecuteAsync(new RestRequest(ApiUrl, Method.Get));
				if (response?.StatusCode == HttpStatusCode.OK && !string.IsNullOrEmpty(response?.Content))
				{
					var release = JsonConvert.DeserializeObject<GitHubRelease>(response.Content);
					return release;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}

			return null;
		}
	}

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
}