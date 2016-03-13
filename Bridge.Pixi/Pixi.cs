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
		[Name("SCALE_MODES.DEFAULT")]
		public static ScaleMode DefaultScaleMode;

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