using Newtonsoft.Json;

namespace FileConverter.UpdateService
{
	public class GitHubRelease
	{
		[JsonProperty("id")]
		public int Id { get; set; }
		public Uri? Url { get; set; }
		[JsonProperty("assets_url")]
		public Uri? AssetsUrl { get; set; }
		[JsonProperty("upload_url")]
		public Uri? UploadUrl { get; set; }
		[JsonProperty("html_url")]
		public Uri? HtmlUrl { get; set; }
		[JsonProperty("node_id")]
		public string? NodeId { get; set; }
		[JsonProperty("tag_name")]
		public string? TagName { get; set; }
		[JsonProperty("target_commitish")]
		public string? TargetCommitish { get; set; }
		[JsonProperty("name")]
		public string? Name { get; set; }
		[JsonProperty("draft")]
		public bool Draft { get; set; }
		[JsonProperty("prerelease")]
		public bool Prerelease { get; set; }
		[JsonProperty("created_at")]
		public DateTime CreatedAt { get; set; }
		[JsonProperty("published_at")]
		public DateTime PublishedAt { get; set; }

		[JsonProperty("author")]
		public GitHubUser? Author { get; set; }

		[JsonProperty("assets")]
		public List<GitHubAsset>? Assets { get; set; }

		public Version Version
		{
			get
			{
				try
				{
					// Ex: "v1.2.3.4"
					var ver = Name?.Replace("v", "").Split(".");
					switch (ver?.Length)
					{
						case 2:  // {major}.{minor}
							return new Version(int.Parse(ver[0]), int.Parse(ver[1]));
						case 3:  // {major}.{minor}.{build}
							return new Version(int.Parse(ver[0]), int.Parse(ver[1]), int.Parse(ver[2]));
						case 4:  // {major}.{minor}.{build}.{revision}
							return new Version(int.Parse(ver[0]), int.Parse(ver[1]), int.Parse(ver[2]), int.Parse(ver[3]));
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.ToString());
				}

				return new Version(0, 0, 0, 0);
			}
		}
	}
}
