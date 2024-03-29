﻿using Newtonsoft.Json;

namespace FileConverter.UpdateService
{
	public class GitHubUser
	{
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("login")]
		public string? Login { get; set; }
		[JsonProperty("node_id")]
		public string? NodeId { get; set; }
		[JsonProperty("avatar_url")]
		public string? AvatarUrl { get; set; }
		[JsonProperty("gravatar_id")]
		public string? GravatarId { get; set; }
		[JsonProperty("url")]
		public Uri? Url { get; set; }
		[JsonProperty("html_url")]
		public Uri? HtmlUrl { get; set; }
		[JsonProperty("followers_url")]
		public Uri? FollowersUrl { get; set; }
		[JsonProperty("following_url")]
		public Uri? FollowingUrl { get; set; }
		[JsonProperty("gists_url")]
		public Uri? GistsUrl { get; set; }
		[JsonProperty("starred_url")]
		public Uri? StarredUrl { get; set; }
		[JsonProperty("subscriptions_url")]
		public Uri? SubscriptionsUrl { get; set; }
		[JsonProperty("organizations_url")]
		public Uri? OrganizationsUrl { get; set; }
		[JsonProperty("repos_url")]
		public Uri? ReposUrl { get; set; }
		[JsonProperty("events_url")]
		public Uri? EventsUrl { get; set; }
		[JsonProperty("received_events_url")]
		public Uri? ReceivedEventsUrl { get; set; }
		[JsonProperty("type")]
		public string? Type { get; set; }
		[JsonProperty("site_admin")]
		public bool? SiteAdmin { get; set; }
	}
}
