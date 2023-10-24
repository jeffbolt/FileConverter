using Newtonsoft.Json;

namespace FileConverter.UpdateService
{
	public class GitHubAsset
	{
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("url")]
		public Uri? Url { get; set; }
		[JsonProperty("name")]
		public string? Name { get; set; }
		[JsonProperty("label")]
		public string? Label { get; set; }

		[JsonProperty("uploader")]
		public GitHubUser? Uploader { get; set; }

		[JsonProperty("content_type")]
		public string? ContentType { get; set; }
		[JsonProperty("state")]
		public string? State { get; set; }
		[JsonProperty("size")]
		public int? Size { get; set; }
		[JsonProperty("download_count")]
		public int? DownloadCount { get; set; }
		[JsonProperty("created_at")]
		public DateTime? CreatedAt { get; set; }
		[JsonProperty("updated_at")]
		public DateTime? UpdatedAt { get; set; }
		[JsonProperty("browser_download_url")]
		public Uri? BrowserDownloadUrl { get; set; }
	}
}
