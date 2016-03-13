using Bridge.Html5;

namespace Bridge.Pixi
{
	/// <summary>
	/// The CanvasRenderer draws the scene and all its content onto a 2D canvas.
	/// This renderer should be used for browsers that do not support WebGL.
	/// Don't forget to add the CanvasRenderer.View to your DOM or you will not see anything :)
	/// </summary>
	[External]
	[Namespace("PIXI")]
	public class CanvasRenderer: SystemRenderer
	{
		public extern CanvasRenderer(float width, float height, CanvasRendererOptions options = null);

		/// <summary>
		/// The canvas 2D context that everything is drawn with.
		/// </summary>
		public CanvasRenderingContext2D Context;

		/// <summary>
		/// Instance of a CanvasMaskManager, handles masking when using the canvas renderer.
		/// </summary>
		public CanvasMaskManager MaskManager;

		/// <summary>
		/// Boolean flag controlling canvas refresh.
		/// </summary>
		public bool Refresh;

		/// <summary>
		/// If true Pixi will Math.Floor() x/y values when rendering, stopping pixel interpolation.
		/// Handy for crisp pixel art and speed on legacy devices.
		/// </summary>
		public bool RoundPixels;

		/// <summary>
		/// The canvas property used to set the canvas smoothing property.
		/// </summary>
		public string SmoothProperty;

		// TODO
		public extern void Render(object @object);
	}

	[External]
	[ObjectLiteral]
	public class CanvasRendererOptions: RendererOptions
	{
		/// <summary>
		/// If true Pixi will Math.Floor() x/y values when rendering, stopping pixel interpolation.
		/// Handy for crisp pixel art and speed on legacy devices.
		/// </summary>
		public bool RoundPixels = false;
	}
}
