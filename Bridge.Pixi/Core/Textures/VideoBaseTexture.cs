using Bridge.Html5;

namespace Bridge.Pixi
{
	/// <summary>
	/// A texture of a playing Video.
	/// </summary>
	[External]
	[Namespace("PIXI")]
	public class VideoBaseTexture : BaseTexture
	{
		public static extern VideoBaseTexture FromURL(Any<string, VideoInfo> videoSrc, ScaleMode scaleMode);

		public static extern VideoBaseTexture FromURLs(Any<string[], VideoInfo[]> videoSrc, ScaleMode scaleMode);

		public static extern VideoBaseTexture FromVideo(HTMLVideoElement video, ScaleMode scaleMode);

		public extern VideoBaseTexture(HTMLVideoElement source, ScaleMode scaleMode = ScaleMode.Default);

		/// <summary>
		/// Should the base texture automatically update itself, set to true by default.
		/// </summary>
		[FieldProperty]
		public bool AutoUpdate { get; set; }

		/// <summary>
		/// The image source that is used to create the texture.
		/// </summary>
		[FieldProperty]
		public new HTMLVideoElement Source { get; }
	}

	[External]
	[ObjectLiteral]
	public class VideoInfo
	{
		/// <summary>
		/// One of the source urls for the video.
		/// </summary>
		[FieldProperty]
		public string Source { get; set; }

		/// <summary>
		/// The mimetype of the video (e.g. 'video/mp4').
		/// If not specified the url's extension will be used as the second part of the mime type.
		/// </summary>
		[FieldProperty]
		public string Mime { get; set; }
	}
}