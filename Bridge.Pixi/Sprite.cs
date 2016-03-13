namespace Bridge.Pixi
{
	/// <summary>
	/// The Sprite object is the base for all textured objects that are rendered to the screen.
	/// </summary>
	[External]
	[Namespace("PIXI")]
	public class Sprite : Container
	{
		/// <summary>
		/// Helper function that creates a sprite that will contain a texture from the TextureCache
		/// based on the frameId The frame ids are created when a Texture packer file has been loaded.
		/// </summary>
		/// <param name="frameId">The frame Id of the texture in the cache.</param>
		/// <param name="crossorigin">if you want to specify the cross-origin parameter.</param>
		/// <returns>A new Sprite using a texture from the texture cache matching the frameId.</returns>
		public static extern Sprite FromFrame(string frameId, bool crossorigin = true);

		/// <summary>
		/// Helper function that creates a sprite that will contain a texture from the TextureCache
		/// based on the frameId The frame ids are created when a Texture packer file has been loaded.
		/// </summary>
		/// <param name="frameId">The frame Id of the texture in the cache.</param>
		/// <param name="crossorigin">if you want to specify the cross-origin parameter.</param>
		/// <param name="scaleMode">The scale mode of the texture.</param>
		/// <returns>A new Sprite using a texture from the texture cache matching the frameId.</returns>
		public static extern Sprite FromFrame(string frameId, bool crossorigin, ScaleMode scaleMode);

		/// <summary>
		/// Helper function that creates a sprite that will contain a texture based on an image
		/// url If the image is not in the texture cache it will be loaded.
		/// </summary>
		/// <param name="imageId">The image url of the texture.</param>
		/// <returns>A new Sprite using a texture from the texture cache matching the image id.</returns>
		public static extern Sprite FromImage(string imageId);

		/// <param name="texture">The texture for this sprite.</param>
		public extern Sprite(Texture texture);

		/// <summary>
		/// The anchor sets the origin point of the texture.
		/// The default is 0,0 this means the texture's origin is the top left.
		/// Setting the anchor to 0.5,0.5 means the texture's origin is centered.
		/// Setting the anchor to 1,1 would mean the texture's origin point will be the bottom right corner.
		/// </summary>
		public Point Anchor;

		// TODO
		/// <summary>
		/// INTERFACE IS NOT IMPLEMENTED YET.
		/// </summary>
		public int BlendMode;

		/// <summary>
		/// Returns the bounds of the Sprite as a rectangle.
		/// The bounds calculation takes the WorldTransform into account.
		/// </summary>
		public override extern Rectangle Bounds { get; }

		/// <summary>
		/// An internal cached value of the tint.
		/// </summary>
		public int CachedTint = 0xFFFFFF;

		/// <summary>
		/// Gets the local bounds of the sprite object.
		/// </summary>
		public override extern Rectangle LocalBounds { get; }

		// TODO
		/// <summary>
		/// INTERFACE IS NOT IMPLEMENTED YET.
		/// </summary>
		public object Shader;

		/// <summary>
		/// The texture that the sprite is using.
		/// </summary>
		public Texture Texture;

		/// <summary>
		/// The tint applied to the sprite. This is a hex value.
		/// A value of 0xFFFFFF will remove any tint effect.
		/// </summary>
		public int Tint;

		/// <summary>
		/// Tests if a point is inside this sprite.
		/// </summary>
		/// <param name="point">The point to test.</param>
		/// <returns>The result of the test.</returns>
		public extern bool ContainsPoint(Point point);

		/// <summary>
		/// Destroys this sprite and optionally its texture.
		/// </summary>
		/// <param name="destroyChildren">Should it destroy the current texture of the sprite as well.</param>
		/// <param name="destroyTexture">Should it destroy the base texture of the sprite as well.</param>
		public extern void Destroy(bool destroyChildren = false, bool destroyTexture = false);
	}
}
