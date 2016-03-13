namespace Bridge.Pixi
{
	/// <summary>
	/// The Rectangle object is an area defined by its position, as indicated by its
	/// top-left corner point (x, y) and by its width and its height.
	/// </summary>
	[External]
	[Namespace("PIXI")]
	public class Rectangle
	{
		/// <summary>
		/// A constant empty rectangle.
		/// </summary>
		[Name("EMPTY")]
		public static readonly Rectangle Empty;

		public extern Rectangle(float x, float y, float width, float height);

		public float Height;

		public float Width;

		public float X;

		public float Y;

		/// <summary>
		/// The type of the object, mainly used to avoid instanceof checks.
		/// </summary>
		public ShapeType Type;

		/// <summary>
		/// Creates a clone of this Rectangle.
		/// </summary>
		/// <returns>A copy of the rectangle.</returns>
		public extern Rectangle Clone();

		/// <summary>
		/// Checks whether the x and y coordinates given are contained within this Rectangle.
		/// </summary>
		/// <param name="x">The X coordinate of the point to test.</param>
		/// <param name="y">The Y coordinate of the point to test.</param>
		/// <returns>Whether the x and y coordinates are within this Rectangle.</returns>
		public extern bool Contains(float x, float y);
	}
}
