using Bridge.Pixi.Loaders;

namespace Bridge.Pixi
{
	[External]
	[Namespace(false)]
	[Name("PIXI")]
	public static class Pixi
	{
		/// <summary>
		/// The Default scale mode that affects the default scaling mode of future operations.
		/// It can be re-assigned to either Linear or Nearest, depending upon suitability.
		/// </summary>
		[FieldProperty]
		[Name("SCALE_MODES.DEFAULT")]
		public static ScaleMode DefaultScaleMode { get; set; }

		/// <summary>
		/// The shared ticker instance used by MovieClip and by InteractionManager.
		/// The property AutoStart is set to true for this instance.
		/// </summary>
		[FieldProperty]
		[Name("ticker.shared")]
		public static Ticker SharedTicker { get; set; }

		/// <summary>
		/// Target frames per millisecond.
		/// </summary>
		[FieldProperty]
		[Name("TARGET_FPMS")]
		public static float TargetFPMS { get; set; }

		/// <summary>
		/// The default render options if none are supplied to WebGLRenderer or CanvasRenderer.
		/// </summary>
		[FieldProperty]
		[Name("DEFAULT_RENDER_OPTIONS")]
		public static RendererOptions DefaultRendererOptions { get; }

		/// <summary>
		/// Constant conversion factor for converting degrees to radians.
		/// </summary>
		[FieldProperty]
		[Name("DEG_TO_RAD")]
		public static float DegToRad { get; }

		/// <summary>
		/// A premade instance of the loader that can be used to loader resources.
		/// </summary>
		[FieldProperty]
		public static Loader Loader { get; set; }

		/// <summary>
		/// Two Pi.
		/// </summary>
		[FieldProperty]
		[Name("PI_2")]
		public static float Pi2 { get; }

		/// <summary>
		/// Constant conversion factor for converting radians to degrees.
		/// </summary>
		[FieldProperty]
		[Name("RAD_TO_DEG")]
		public static float RadToDeg { get; }

		/// <summary>
		/// The prefix that denotes a URL is for a retina asset.
		/// </summary>
		[FieldProperty]
		[Name("RETINA_PREFIX")]
		public static string RetinaPrefix { get; }

		/// <summary>
		/// String of the current PIXI version.
		/// </summary>
		[FieldProperty]
		[Name("VERSION")]
		public static string Version { get; }

		/// <summary>
		/// This helper function will automatically detect which renderer you should be using.
		/// WebGL is the preferred renderer as it is a lot faster.
		/// If webGL is not supported by the browser then this function will return a canvas renderer.
		/// </summary>
		/// <param name="width">The width of the renderers view.</param>
		/// <param name="height">The height of the renderers view.</param>
		/// <param name="options">The optional renderer parameters.</param>
		/// <param name="noWebGL">Prevents selection of WebGL renderer, even if such is present.</param>
		/// <returns>Returns WebGL renderer if available, otherwise CanvasRenderer.</returns>
		public static extern SystemRenderer AutoDetectRenderer(float width, float height,
			RendererOptions options = null, bool noWebGL = false);
	}
}