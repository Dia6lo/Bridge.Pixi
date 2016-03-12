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
		public CanvasElement View = null;

		/// <summary>
		/// If the render view is transparent.
		/// </summary>
		public bool Transparent = false;

		/// <summary>
		/// Sets antialias (only applicable in Chrome at the moment).
		/// </summary>
		public bool Antialias = false;

		/// <summary>
		/// Enables drawing buffer preservation, enable this if you need to call ToDataUrl on the WebGL context.
		/// </summary>
		public bool PreserveDrawingBuffer = false;

		/// <summary>
		/// The resolution of the renderer.
		/// </summary>
		public Resolution Resolution = Resolution.Normal;

		/// <summary>
		/// The background color of the rendered area (shown if not transparent).
		/// </summary>
		public int BackgroundColor = 0x000000;

		/// <summary>
		/// If the render view is automatically resized.
		/// </summary>
		public bool AutoResize = false;

		/// <summary>
		/// This sets if the CanvasRenderer will clear the canvas or not before the new render pass.
		/// If you wish to set this to false, you must set PreserveDrawingBuffer to true.
		/// </summary>
		public bool ClearBeforeRender = true;
	}
}