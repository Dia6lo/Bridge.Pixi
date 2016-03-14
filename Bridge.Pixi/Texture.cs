using Bridge.Html5;

namespace Bridge.Pixi
{
	/// <summary>
	/// A texture stores the information that represents an image or part of an image.
	/// It cannot be added to the display list directly. Instead use it as the texture for a Sprite.
	/// If no frame is provided then the whole image is used.
	/// </summary>
	[External]
	[Namespace("PIXI")]
	public class Texture
	{
		/// <summary>
		/// An empty texture, used often to not have to create multiple empty textures.
		/// </summary>
		[Name("EMPTY")]
		public static readonly Texture Empty;

		// TODO.
		/// <summary>
		/// Adds a texture to the global utils.TextureCache.
		/// This cache is shared across the whole PIXI object.
		/// </summary>
		/// <param name="texture">The Texture to add to the cache.</param>
		/// <param name="id">The id that the texture will be stored against.</param>
		public static extern void AddTextureToCache(Texture texture, string id);

		/// <summary>
		/// Helper function that creates a new Texture based on the given canvas element.
		/// </summary>
		/// <param name="canvas">The canvas element source of the texture.</param>
		/// <param name="scaleMode">The scale mode of the texture.</param>
		public static extern Texture FromCanvas(CanvasElement canvas, ScaleMode scaleMode = ScaleMode.Default);

		/// <summary>
		/// Helper function that creates a sprite that will contain a texture from the TextureCache
		/// based on the frameId The frame ids are created when a Texture packer file has been loaded.
		/// </summary>
		/// <param name="frameId">The frame Id of the texture in the cache.</param>
		public static extern Texture FromFrame(string frameId);

		/// <summary>
		/// Helper function that creates a Texture object from the given image url.
		/// If the image is not in the texture cache it will be created and loaded.
		/// </summary>
		/// <param name="imageUrl">The image url of the texture.</param>
		/// <param name="crossorigin">Whether requests should be treated as crossorigin.</param>
		/// <param name="scaleMode">The scale mode of the texture.</param>
		public static extern Texture FromImage(string imageUrl, bool crossorigin = true,
			ScaleMode scaleMode = ScaleMode.Default);

		/// <summary>
		/// Helper function that creates a new Texture based on the given video element.
		/// </summary>
		public static extern Texture FromVideo(VideoElement video, ScaleMode scaleMode = ScaleMode.Default);

		/// <summary>
		/// Helper function that creates a new Texture based on the video url.
		/// </summary>
		[Name("fromVideoUrl")]
		public static extern Texture FromVideoURL(string videoUrl, ScaleMode scaleMode = ScaleMode.Default);

		// TODO
		/// <summary>
		/// Remove a texture from the global utils.TextureCache.
		/// </summary>
		/// <param name="id">The id of the texture to be removed.</param>
		/// <returns>The texture that was removed.</returns>
		public static extern Texture RemoveAddTextureFromCache(string id);

		/// <param name="baseTexture">The base texture source to create the texture from.</param>
		/// <param name="frame">The rectangle frame of the texture to show.</param>
		/// <param name="crop">The area of original texture.</param>
		/// <param name="trim">Trimmed texture rectangle.</param>
		/// <param name="rotate">
		/// Indicates whether the texture should be rotated by 90 degrees (used by texture packer).
		/// </param>
		public extern Texture(BaseTexture baseTexture, Rectangle frame = null,
			Rectangle crop = null, Rectangle trim = null, bool rotate = false);

		/// <summary>
		/// The base texture that this texture uses.
		/// </summary>
		public BaseTexture BaseTexture;

		/// <summary>
		/// This is the area of the BaseTexture image to actually copy to the
		/// Canvas/WebGL when rendering, irrespective of the actual frame size or placement
		/// (which can be influenced by trimmed texture atlases).
		/// </summary>
		public Rectangle Crop;

		/// <summary>
		/// The frame specifies the region of the base texture that this texture uses.
		/// </summary>
		public Rectangle Frame;

		/// <summary>
		/// The height of the Texture in pixels.
		/// </summary>
		public float Height;

		/// <summary>
		/// Does this Texture have any frame data assigned to it?
		/// </summary>
		public bool NoFrame;

		/// <summary>
		/// This will let a renderer know that a texture has been updated (used mainly for WebGL UV updates).
		/// </summary>
		public bool RequiresUpdate;

		/// <summary>
		/// The texture trim data.
		/// </summary>
		public Rectangle Trim;

		/// <summary>
		/// This will let the renderer know if the texture is valid.
		/// If it's not then it cannot be rendered.
		/// </summary>
		public bool Valid;

		/// <summary>
		/// The width of the Texture in pixels.
		/// </summary>
		public float Width;

		/// <summary>
		/// Creates a new texture object that acts the same as this one.
		/// </summary>
		public extern Texture Clone();

		/// <summary>
		/// Destroys this texture.
		/// </summary>
		/// <param name="destroyBase">Whether to destroy the base texture as well.</param>
		public extern void Destroy(bool destroyBase = false);

		/// <summary>
		/// Updates this texture on the GPU.
		/// </summary>
		public extern Texture Update();
	}
}
