using Bridge.Html5;

namespace Bridge.Pixi
{
	[External]
	[ObjectLiteral]
	public class RendererOptions
	{
		/// <summary>
		/// The canvas to use as a view.
		/// </summary>
		[FieldProperty]
		public HTMLCanvasElement View { get; set; }

		/// <summary>
		/// If the render view is transparent.
		/// </summary>
		[FieldProperty]
		public bool Transparent { get; set; }

		/// <summary>
		/// Sets antialias (only applicable in Chrome at the moment).
		/// </summary>
		[FieldProperty]
		public bool Antialias { get; set; }

		/// <summary>
		/// Enables drawing buffer preservation, enable this if you need to call ToDataUrl on the WebGL context.
		/// </summary>
		[FieldProperty]
		public bool PreserveDrawingBuffer { get; set; }

		/// <summary>
		/// If true Pixi will Math.Floor() x/y values when rendering, stopping pixel interpolation.
		/// Handy for crisp pixel art and speed on legacy devices.
		/// </summary>
		[FieldProperty]
		public bool RoundPixels { get; set; }

		/// <summary>
		/// Forces FXAA antialiasing to be used over native.
		/// FXAA is faster, but may not always look as great.
		/// </summary>
		[FieldProperty]
		[Name("forceFXAA")]
		public bool ForceFXAA { get; set; }

		/// <summary>
		/// The resolution of the renderer.
		/// </summary>
		[FieldProperty]
		public Resolution Resolution { get; set; }

		/// <summary>
		/// The background color of the rendered area (shown if not transparent).
		/// </summary>
		[FieldProperty]
		public int BackgroundColor { get; set; }

		/// <summary>
		/// If the render view is automatically resized.
		/// </summary>
		[FieldProperty]
		public bool AutoResize { get; set; }

		/// <summary>
		/// This sets if the CanvasRenderer will clear the canvas or not before the new render pass.
		/// If you wish to set this to false, you must set PreserveDrawingBuffer to true.
		/// </summary>
		[FieldProperty]
		public bool ClearBeforeRender { get; set; }
	}
}