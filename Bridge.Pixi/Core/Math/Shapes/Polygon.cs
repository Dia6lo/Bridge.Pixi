namespace Bridge.Pixi
{
	[External]
	[Namespace("PIXI")]
	public class Polygon : IShape, IHitArea
	{
		/// <param name="points">
		/// This can be an array of Points that form the polygon, a flat array of numbers that
		/// will be interpreted as [x,y, x,y, ...], or the arguments passed can be all the points
		/// of the polygon e.g. new Polygon(new Point(), new Point(), ...),
		/// or the arguments passed can be flat x,y values e.g. new Polygon(x,y, x,y, x,y, ...)
		/// where x and y are floats.
		/// </param>
		public extern Polygon(Any<Point[], float[], Point> points);

		/// <summary>
		/// An array of the points of this polygon.
		/// </summary>
		[FieldProperty]
		public float[] Points { get; set; }

		/// <summary>
		/// The type of the object, mainly used to avoid instanceof checks.
		/// </summary>
		[FieldProperty]
		public ShapeType Type { get; set; }

		/// <summary>
		/// Creates a clone of this Polygon.
		/// </summary>
		/// <returns>A copy of the Polygon.</returns>
		public extern Polygon Clone();

		/// <summary>
		/// Checks whether the x and y coordinates given are contained within this Polygon.
		/// </summary>
		/// <param name="x">The X coordinate of the point to test.</param>
		/// <param name="y">The Y coordinate of the point to test.</param>
		/// <returns>Whether the x and y coordinates are within this Polygon.</returns>
		public extern bool Contains(float x, float y);
	}
}