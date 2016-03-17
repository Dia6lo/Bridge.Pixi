namespace Bridge.Pixi
{
	/// <summary>
	/// The Rounded Rectangle object is an area that has nice rounded corners,
	/// as indicated by its top-left corner point (x, y) and by its width and its height and its radius.
	/// </summary>
	[External]
	[Namespace("PIXI")]
	public class RoundedRectangle
	{
		public extern RoundedRectangle(float x, float y, float width, float height);

		[FieldProperty]
		public float Height { get; set; }

		[FieldProperty]
		public float Radius { get; set; }

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
		/// Creates a clone of this RoundedRectangle.
		/// </summary>
		/// <returns>A copy of the rectangle.</returns>
		public extern RoundedRectangle Clone();

		/// <summary>
		/// Checks whether the x and y coordinates given are contained within this RoundedRectangle.
		/// </summary>
		/// <param name="x">The X coordinate of the point to test.</param>
		/// <param name="y">The Y coordinate of the point to test.</param>
		/// <returns>Whether the x and y coordinates are within this RoundedRectangle.</returns>
		public extern bool Contains(float x, float y);
	}
}