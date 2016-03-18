namespace Bridge.Pixi
{
	[External]
	[Namespace("PIXI")]
	public class GraphicsData
	{
		public extern GraphicsData(float lineWidth, int lineColor, float lineAlpha, int fillColor,
			float fillAlpha, bool fill, Any<Circle, Rectangle, Ellipse, Polygon> shape);

		[FieldProperty]
		public float LineWidth { get; set; }

		[FieldProperty]
		public int LineColor { get; set; }

		[FieldProperty]
		public float LineAlpha { get; set; }

		[FieldProperty]
		public int FillColor { get; set; }

		[FieldProperty]
		public float FillAlpha { get; set; }

		[FieldProperty]
		public bool Fill { get; set; }

		[FieldProperty]
		public Any<Circle, Rectangle, Ellipse, Polygon> Shape { get; set; }

		[FieldProperty]
		public ShapeType Type { get; set; }

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