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
		/// <param name="imageId">The image url of the texture.</param>
		/// <param name="crossorigin">if you want to specify the cross-origin parameter.</param>
		/// <param name="scaleMode">The scale mode of the texture.</param>
		/// <returns>A new Sprite using a texture from the texture cache matching the frameId.</returns>
		public static extern Sprite FromImage(string imageId, bool crossorigin = false,
			ScaleMode scaleMode = ScaleMode.Default);

		/// <summary>
		/// Helper function that creates a sprite that will contain a texture based on an image
		/// url If the image is not in the texture cache it will be loaded.
		/// </summary>
		/// <param name="frameId">The frame Id of the texture in the cache.</param>
		/// <returns>A new Sprite using a texture from the texture cache matching the image id.</returns>
		public static extern Sprite FromFrame(string frameId);

		/// <param name="texture">The texture for this sprite.</param>
		public extern Sprite(Texture texture = null);

		/// <summary>
		/// The anchor sets the origin point of the texture.
		/// The default is 0,0 this means the texture's origin is the top left.
		/// Setting the anchor to 0.5,0.5 means the texture's origin is centered.
		/// Setting the anchor to 1,1 would mean the texture's origin point will be the bottom right corner.
		/// </summary>
		[FieldProperty]
		public Point Anchor { get; set; }

		/// <summary>
		/// The blend mode to be applied to the sprite. Apply a value of Normal to reset the blend mode.
		/// </summary>
		[FieldProperty]
		public BlendMode BlendMode { get; set; }

		/// <summary>
		/// An internal cached value of the tint.
		/// </summary>
		[FieldProperty]
		public int CachedTint { get; set; }

		/// <summary>
		/// Gets the local bounds of the sprite object.
		/// </summary>
		public override extern Rectangle LocalBounds { get; }

		/// <summary>
		/// The shader that will be used to render the sprite.
		/// Set to null to remove a current shader.
		/// </summary>
		[FieldProperty]
		public Any<Shader, AbstractFilter> Shader { get; set; }

		/// <summary>
		/// The texture that the sprite is using.
		/// </summary>
		[FieldProperty]
		public Texture Texture { get; set; }

		/// <summary>
		/// The tint applied to the sprite. This is a hex value.
		/// A value of 0xFFFFFF will remove any tint effect.
		/// </summary>
		[FieldProperty]
		public int Tint { get; set; }

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
