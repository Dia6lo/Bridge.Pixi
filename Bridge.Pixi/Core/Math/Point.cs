namespace Bridge.Pixi
{
	/// <summary>
	/// The Point object represents a location in a two-dimensional coordinate system,
	/// where x represents the horizontal axis and y represents the vertical axis.
	/// </summary>
	[External]
	[Namespace("PIXI")]
	public class Point
	{
		public extern Point(float x = 0f, float y = 0f);

		[FieldProperty]
		public float X { get; set; }

		[FieldProperty]
		public float Y { get; set; }

		/// <summary>
		/// Creates a clone of this point.
		/// </summary>
		/// <returns>A copy of the point.</returns>
		public extern Point Clone();

		/// <summary>
		/// Copies x and y from the given point.
		/// </summary>
		public extern void Copy(Point p);

		/// <summary>
		/// Returns true if the given point is equal to this point.
		/// </summary>
		public extern void Equals(Point p);

		/// <summary>
		/// Sets the point to a new x and y position.
		/// If y is omitted, both x and y will be set to x.
		/// </summary>
		/// <param name="x">Position of the point on the x axis.</param>
		/// <param name="y">Position of the point on the y axis.</param>
		public extern void Set(float x = 0f, float y = 0f);
	}
}
