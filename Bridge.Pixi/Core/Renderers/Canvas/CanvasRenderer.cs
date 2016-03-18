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
		public extern CanvasRenderer(float width = 800, float height = 600, RendererOptions options = null);

		/// <summary>
		/// The canvas 2D context that everything is drawn with.
		/// </summary>
		[FieldProperty]
		public CanvasRenderingContext2D Context { get; set; }

		/// <summary>
		/// Instance of a CanvasMaskManager, handles masking when using the canvas renderer.
		/// </summary>
		[FieldProperty]
		public CanvasMaskManager MaskManager { get; set; }

		/// <summary>
		/// Boolean flag controlling canvas refresh.
		/// </summary>
		[FieldProperty]
		public bool Refresh { get; set; }

		/// <summary>
		/// The canvas property used to set the canvas smoothing property.
		/// </summary>
		[FieldProperty]
		public string SmoothProperty { get; set; }
	}
}
