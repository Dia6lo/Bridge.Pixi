using Bridge.Html5;

namespace Bridge.Pixi
{
	[External]
	[Namespace("PIXI")]
	public class Quad
	{
		public extern Quad(IWebGLRenderingContext gl);

		/// <summary>
		/// The color components of the triangles.
		/// </summary>
		[FieldProperty]
		public Float32Array Colors { get; set; }

		/// <summary>
		/// The UVs of the quad.
		/// </summary>
		[FieldProperty]
		public Float32Array UVs { get; set; }

		/// <summary>
		/// An array of vertices.
		/// </summary>
		[FieldProperty]
		public Float32Array Vertices { get; set; }

		/// <summary>
		/// Maps two Rectangle to the quad.
		/// </summary>
		public extern void Map(Rectangle rect, Rectangle rect2);

		/// <summary>
		/// Binds the buffer and uploads the data.
		/// </summary>
		public extern void Upload();
	}
}