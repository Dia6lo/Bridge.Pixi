using Bridge.Html5;

namespace Bridge.Pixi
{
	/// <summary>
	/// Tinting method.
	/// </summary>
	/// <param name="texture">The texture to tint.</param>
	/// <param name="color">The color to use to tint the sprite with.</param>
	/// <param name="canvas">The current canvas.</param>
	[External]
	public delegate void TintMethod(Texture texture, int color, CanvasElement canvas);

	[External]
	[Namespace("PIXI")]
	public class CanvasTinter
	{

		/// <summary>
		/// Number of steps which will be used as a cap when rounding colors.
		/// </summary>
		[FieldProperty]
		public static int CacheStepsPerColorChannel { get; set; }

		/// <summary>
		/// Whether or not the Canvas BlendModes are supported,
		/// consequently the ability to tint using the multiply method.
		/// </summary>
		[FieldProperty]
		public static bool CanUseMultiply { get; set; }

		/// <summary>
		/// Tint cache boolean flag.
		/// </summary>
		[FieldProperty]
		public static bool ConvertTintToImage { get; set; }

		/// <summary>
		/// The tinting method that will be used.
		/// </summary>
		[FieldProperty]
		public static TintMethod TintMethod { get; set; }

		/// <summary>
		/// Basically this method just needs a sprite and a color and
		/// tints the sprite with the given color.
		/// </summary>
		/// <param name="sprite">The sprite to tint.</param>
		/// <param name="color">The color to use to tint the sprite with.</param>
		/// <returns>The tinted canvas</returns>
		public static extern CanvasElement GetTintedTexture(Sprite sprite, int color);

		/// <summary>
		/// Rounds the specified color according to the CacheStepsPerColorChannel.
		/// </summary>
		/// <param name="color">The color to round, should be a hex color.</param>
		public static extern int RoundColor(int color);

		/// <summary>
		/// Tint a texture using the 'multiply' operation.
		/// </summary>
		/// <param name="texture">The texture to tint.</param>
		/// <param name="color">The color to use to tint the sprite with.</param>
		/// <param name="canvas">The current canvas.</param>
		public static extern void TintWithMultiply(Texture texture, int color, CanvasElement canvas);

		/// <summary>
		/// Tint a texture using the 'overlay' operation.
		/// </summary>
		/// <param name="texture">The texture to tint.</param>
		/// <param name="color">The color to use to tint the sprite with.</param>
		/// <param name="canvas">The current canvas.</param>
		public static extern void TintWithOverlay(Texture texture, int color, CanvasElement canvas);

		/// <summary>
		/// Tint a texture pixel per pixel.
		/// </summary>
		/// <param name="texture">The texture to tint.</param>
		/// <param name="color">The color to use to tint the sprite with.</param>
		/// <param name="canvas">The current canvas.</param>
		public static extern void TintWithPerPixel(Texture texture, int color, CanvasElement canvas);
	}
}