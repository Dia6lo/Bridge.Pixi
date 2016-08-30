using Bridge.Html5;

namespace Bridge.Pixi
{
	[External]
	[Namespace("PIXI")]
	public class CanvasBuffer
	{
		/// <summary>
		/// Creates a Canvas element of the given size.
		/// </summary>
		/// <param name="width">The width for the newly created canvas.</param>
		/// <param name="height">The height for the newly created canvas.</param>
		public extern CanvasBuffer(float width, float height);

		/// <summary>
		/// The Canvas object that belongs to this CanvasBuffer.
		/// </summary>
		[FieldProperty]
		public HTMLCanvasElement Canvas { get; }

		/// <summary>
		/// A CanvasRenderingContext2D object representing a two-dimensional rendering context.
		/// </summary>
		[FieldProperty]
		public CanvasRenderingContext2D Context { get; }

		/// <summary>
		/// The height of the canvas buffer in pixels.
		/// </summary>
		[FieldProperty]
		public float Height { get; }

		/// <summary>
		/// The width of the canvas buffer in pixels.
		/// </summary>
		[FieldProperty]
		public float Width { get; }

		/// <summary>
		/// Destroys this canvas.
		/// </summary>
		public extern void Destroy();

		/// <summary>
		/// Resizes the canvas to the specified width and height.
		/// </summary>
		/// <param name="width">The new width of the canvas.</param>
		/// <param name="height">The new height of the canvas.</param>
		public extern void Resize(float width, float height);
	}
}