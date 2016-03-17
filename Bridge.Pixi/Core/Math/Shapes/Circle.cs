namespace Bridge.Pixi
{
	[External]
	[Namespace("PIXI")]
	public class Circle
	{
		public extern Circle(float x, float y, float radius);

		/// <summary>
		/// Returns the framing rectangle of the circle.
		/// </summary>
		public extern Rectangle Bounds { get; }

		[FieldProperty]
		public float Radius { get; set; }

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
		/// Creates a clone of this Circle.
		/// </summary>
		/// <returns>A copy of the Circle.</returns>
		public extern Circle Clone();

		/// <summary>
		/// Checks whether the x and y coordinates given are contained within this Circle.
		/// </summary>
		/// <param name="x">The X coordinate of the point to test.</param>
		/// <param name="y">The Y coordinate of the point to test.</param>
		/// <returns>Whether the x and y coordinates are within this Circle.</returns>
		public extern bool Contains(float x, float y);
	}
}