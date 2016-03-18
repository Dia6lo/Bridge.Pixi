namespace Bridge.Pixi
{
	/// <summary>
	/// The Ellipse object can be used to specify a hit area for DisplayObjects.
	/// </summary>
	[External]
	[Namespace("PIXI")]
	public class Ellipse : IShape, IHitArea
	{
		public extern Ellipse(float x, float y, float width, float height);

		/// <summary>
		/// Returns the framing rectangle of the ellipse.
		/// </summary>
		public extern Rectangle Bounds { get; }

		[FieldProperty]
		public float Height { get; set; }

		[FieldProperty]
		public float Width { get; set; }

		[FieldProperty]
		public float X { get; set; }

		[FieldProperty]
		public float Y { get; set; }

		/// <summary>
		/// The type of the object, mainly used to avoid instanceof checks.
		/// </summary>
		[FieldProperty]
		public ShapeType Type { get; set; }

		/// <summary>
		/// Creates a clone of this Ellipse.
		/// </summary>
		/// <returns>A copy of the rectangle.</returns>
		public extern Ellipse Clone();

		/// <summary>
		/// Checks whether the x and y coordinates given are contained within this Ellipse.
		/// </summary>
		/// <param name="x">The X coordinate of the point to test.</param>
		/// <param name="y">The Y coordinate of the point to test.</param>
		/// <returns>Whether the x and y coordinates are within this Ellipse.</returns>
		public extern bool Contains(float x, float y);
	}
}