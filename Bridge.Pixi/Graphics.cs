namespace Bridge.Pixi
{
	/// <summary>
	/// The Graphics class contains methods used to draw primitive shapes such as lines,
	/// circles and rectangles to the display, and to color and fill them.
	/// </summary>
	[External]
	[Namespace("PIXI")]
	public class Graphics: Container
	{
		/// <summary>
		/// The blend mode to be applied to the graphic shape. Apply a value of Normal to reset the blend mode.
		/// </summary>
		[FieldProperty]
		public BlendMode BlendMode { get; set; }

		/// <summary>
		/// The bounds' padding used for bounds calculation.
		/// </summary>
		[FieldProperty]
		public float BoundsPadding { get; set; }

		/// <summary>
		/// The alpha value used when filling the Graphics object.
		/// </summary>
		[FieldProperty]
		public float FillAlpha { get; set; }

		/// <summary>
		/// Whether this shape is being used as a mask.
		/// </summary>
		[FieldProperty]
		public bool IsMask { get; set; }

		/// <summary>
		/// The color of any lines drawn.
		/// </summary>
		[FieldProperty]
		public int LineColor { get; set; }

		/// <summary>
		/// The width (thickness) of any lines drawn.
		/// </summary>
		[FieldProperty]
		public float LineWidth { get; set; }

		/// <summary>
		/// The tint applied to the graphic shape. This is a hex value.
		/// A value of 0xFFFFFF will remove any tint effect.
		/// </summary>
		[FieldProperty]
		public int Tint { get; set; }

		/// <summary>
		/// Creates an arc/curve (used to create circles, or parts of circles).
		/// </summary>
		/// <param name="cx">The x-coordinate of the center of the circle.</param>
		/// <param name="cy">The y-coordinate of the center of the circle.</param>
		/// <param name="radius">The radius of the circle.</param>
		/// <param name="startAngle">
		/// The starting angle, in radians(0 is at the 3 o'clock position of the arc's circle).
		/// </param>
		/// <param name="endAngle">The ending angle, in radians.</param>
		/// <param name="antiClockwise">
		/// Specifies whether the drawing should be counterclockwise or clockwise.
		/// </param>
		/// <returns></returns>
		public extern Graphics Arc(float cx, float cy, float radius,
			float startAngle, float endAngle, bool antiClockwise = false);

		/// <summary>
		/// Creates an arc/curve between two tangents on the canvas.
		/// </summary>
		/// <param name="x1">The x-coordinate of the beginning of the arc.</param>
		/// <param name="y1">The y-coordinate of the beginning of the arc.</param>
		/// <param name="x2">The x-coordinate of the end of the arc.</param>
		/// <param name="y2">The y-coordinate of the end of the arc.</param>
		/// <param name="radius">The radius of the arc.</param>
		public extern Graphics ArcTo(float x1, float y1, float x2, float y2, float radius);

		/// <summary>
		/// Specifies a simple one-color fill that subsequent calls to other Graphics methods
		/// (such as LineTo or DrawCircle) use when drawing.
		/// </summary>
		/// <param name="color">The color of the fill.</param>
		/// <param name="alpha">The alpha of the fill.</param>
		public extern Graphics BeginFill(int color, float alpha);

		/// <summary>
		/// Calculate the points for a bezier curve and then draws it.
		/// </summary>
		/// <param name="cpX">Control point X.</param>
		/// <param name="cpY">Control point Y.</param>
		/// <param name="cpX2">Second control point X.</param>
		/// <param name="cpY2">Second control point Y.</param>
		/// <param name="toX">Destination point X.</param>
		/// <param name="toY">Destination point Y.</param>
		public extern Graphics BezierCurveTo(float cpX, float cpY, float cpX2, float cpY2,
			float toX, float toY);

		/// <summary>
		/// Clears the graphics that were drawn to this Graphics object,
		/// and resets fill and line style settings.
		/// </summary>
		public extern Graphics Clear();

		/// <summary>
		/// Creates a new Graphics object with the same values as this one.
		/// Note that the only the properties of the object are cloned,
		/// not its transform (position, scale, etc.).
		/// </summary>
		public extern Graphics Clone();

		/// <summary>
		/// Tests if a point is inside this graphics object.
		/// </summary>
		/// <param name="point">The point to test.</param>
		/// <returns>The result of the test.</returns>
		public extern bool ContainsPoint(Point point);

		/// <summary>
		/// Destroys the Graphics object.
		/// </summary>
		public extern void Destroy();

		/// <summary>
		/// Draws a circle.
		/// </summary>
		/// <param name="x">The X coordinate of the center of the circle.</param>
		/// <param name="y">The Y coordinate of the center of the circle.</param>
		/// <param name="radius">The radius of the circle.</param>
		public extern Graphics DrawCircle(float x, float y, float radius);

		/// <summary>
		/// Draws an ellipse.
		/// </summary>
		/// <param name="x">The X coordinate of the center of the ellipse.</param>
		/// <param name="y">The Y coordinate of the center of the ellipse.</param>
		/// <param name="width">The half width of the ellipse.</param>
		/// <param name="height">The half height of the ellipse.</param>
		public extern Graphics DrawEllipse(float x, float y, float width, float height);

		/// <summary>
		/// Draws a polygon using the given path.
		/// </summary>
		/// <param name="path">The path data used to construct the polygon.</param>
		public extern Graphics DrawPolygon(Any<float[], Point[]> path);

		/// <summary>
		/// Draws a rectangle.
		/// </summary>
		/// <param name="x">The X coord of the top-left of the rectangle.</param>
		/// <param name="y">The Y coord of the top-left of the rectangle.</param>
		/// <param name="width">The width of the rectangle.</param>
		/// <param name="height">The height of the rectangle.</param>
		public extern Graphics DrawRect(float x, float y, float width, float height);

		/// <summary>
		/// Draws a rounded rectangle.
		/// </summary>
		/// <param name="x">The X coord of the top-left of the rectangle.</param>
		/// <param name="y">The Y coord of the top-left of the rectangle.</param>
		/// <param name="width">The width of the rectangle.</param>
		/// <param name="height">The height of the rectangle.</param>
		/// <param name="radius">Radius of the rectangle corners.</param>
		public extern Graphics DrawRoundedRect(float x, float y, float width, float height, float radius);

		/// <summary>
		/// Draws the given shape to this Graphics object. Can be any of Circle, Rectangle,
		/// Ellipse or Polygon.
		/// </summary>
		public extern GraphicsData DrawShape(Any<Circle, Rectangle, Ellipse, Polygon> shape);

		/// <summary>
		/// Applies a fill to the lines and shapes that were added since the last call to the BeginFill method.
		/// </summary>
		public extern Graphics EndFill();

		/// <summary>
		/// Specifies the line style used for subsequent calls to Graphics methods such as the
		/// LineTo method or the DrawCircle method.
		/// </summary>
		/// <param name="lineWidth">Width of the line to draw, will update the objects stored style.</param>
		/// <param name="color">Color of the line to draw, will update the objects stored style.</param>
		/// <param name="alpha">Alpha of the line to draw, will update the objects stored style</param>
		/// <returns></returns>
		public extern Graphics LineStyle(float lineWidth, int color = 0, float alpha = 1);

		/// <summary>
		/// Draws a line using the current line style from the current drawing position to (x, y);
		/// The current drawing position is then set to (x, y).
		/// </summary>
		/// <param name="x">The X coordinate to draw to.</param>
		/// <param name="y">The Y coordinate to draw to.</param>
		public extern Graphics LineTo(float x, float y);

		/// <summary>
		/// Moves the current drawing position to x, y.
		/// </summary>
		/// <param name="x">The X coordinate to move to.</param>
		/// <param name="y">The Y coordinate to move to.</param>
		public extern Graphics MoveTo(float x, float y);

		/// <summary>
		/// Calculate the points for a quadratic bezier curve and then draws it.
		/// </summary>
		/// <param name="cpX">Control point X.</param>
		/// <param name="cpY">Control point Y.</param>
		/// <param name="toX">Destination point X.</param>
		/// <param name="toY">Destination point Y.</param>
		public extern Graphics QuadraticCurveTo(float cpX, float cpY, float toX, float toY);

		/// <summary>
		/// Update the bounds of the object.
		/// </summary>
		public extern void UpdateLocalBounds();
	}
}