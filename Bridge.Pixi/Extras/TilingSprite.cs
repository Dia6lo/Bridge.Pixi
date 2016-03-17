namespace Bridge.Pixi.Extras
{
	/// <summary>
	/// A tiling sprite is a fast way of rendering a tiling image.
	/// </summary>
	[External]
	[Namespace("PIXI.extras")]
	public class TilingSprite : Sprite
	{
		/// <summary>
		/// Helper function that creates a tiling sprite that will use a texture from the TextureCache
		/// based on the frameId The frame ids are created when a Texture packer file has been loaded.
		/// </summary>
		/// <param name="frameId">The frame Id of the texture in the cache.</param>
		/// <param name="width">The width of the tiling sprite.</param>
		/// <param name="height">The height of the tiling sprite.</param>
		/// <returns>A new TilingSprite using a texture from the texture cache matching the frameId.</returns>
		public static extern MovieClip FromFrame(string frameId, float width, float height);

		/// <summary>
		/// Helper function that creates a sprite that will contain a texture based on an image url.
		/// If the image is not in the texture cache it will be loaded.
		/// </summary>
		/// <param name="imageId">The image url of the texture.</param>
		/// <param name="width">The width of the tiling sprite.</param>
		/// <param name="height">The height of the tiling sprite.</param>
		/// <param name="crossorigin">If you want to specify the cross-origin parameter.</param>
		/// <param name="scaleMode">The scale mode of the texture.</param>
		/// <returns>A new TilingSprite using a texture from the texture cache matching the image id.</returns>
		public static extern MovieClip FromImage(string imageId, float width, float height,
			bool crossorigin = true, ScaleMode scaleMode = ScaleMode.Default);

		/// <summary>
		/// A short hand way of creating a movieclip from an array of image urls.
		/// </summary>
		/// <param name="images">The array of image urls the MovieClip will use as its texture frames.</param>
		public static extern MovieClip FromImages(string[] images);

		public extern TilingSprite(Texture texture, float width, float height);

		/// <summary>
		/// The offset position of the image that is being tiled.
		/// </summary>
		[FieldProperty]
		public Point TilePosition { get; set; }

		/// <summary>
		/// The scaling of the image that is being tiled.
		/// </summary>
		[FieldProperty]
		public Point TileScale { get; set; }
	}
}