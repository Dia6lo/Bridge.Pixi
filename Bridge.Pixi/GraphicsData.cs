namespace Bridge.Pixi
{
	[External]
	[Namespace("PIXI")]
	public class GraphicsData
	{
		public extern GraphicsData(float lineWidth, int lineColor, float lineAlpha, int fillColor,
			float fillAlpha, bool fill, Any<Circle, Rectangle, Ellipse, Polygon> shape);

		/// <summary>
		/// Creates a new GraphicsData object with the same values as this one.
		/// </summary>
		public extern GraphicsData Clone();

		/// <summary>
		/// Destroys the Graphics data.
		/// </summary>
		public extern void Destroy();
	}
}