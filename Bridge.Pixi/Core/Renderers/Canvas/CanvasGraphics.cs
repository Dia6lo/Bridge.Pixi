using Bridge.Html5;

namespace Bridge.Pixi
{
	/// <summary>
	/// A set of functions used by the canvas renderer to draw the primitive graphics data.
	/// </summary>
	[External]
	[Namespace("PIXI")]
	public class CanvasGraphics
	{
		public static extern void RenderGraphicsMask(Graphics graphics, CanvasRenderingContext2D context);

		public static extern void UpdateGraphicsTint(Graphics graphics);

		public static extern void RenderGraphics(Graphics graphics, CanvasRenderingContext2D context);
	}
}