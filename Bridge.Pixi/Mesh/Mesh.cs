using Bridge.Html5;

namespace Bridge.Pixi.Mesh
{
	/// <summary>
	/// Base mesh class.
	/// </summary>
	[External]
	[Namespace("PIXI.mesh")]
	public class Mesh: Container
	{
		public extern Mesh(Texture texture, Float32Array vertices = null, Float32Array uvs = null,
			Uint16Array indices = null, DrawMode? drawMode = null);

		/// <summary>
		/// The blend mode to be applied to the sprite. Apply a value of Normal to reset the blend mode.
		/// </summary>
		[FieldProperty]
		public BlendMode BlendMode { get; set; }

		/// <summary>
		/// Triangles in canvas mode are automatically antialiased,
		/// use this value to force triangles to overlap a bit with each other.
		/// </summary>
		[FieldProperty]
		public float CanvasPadding { get; set; }

		/// <summary>
		/// Whether the Mesh is dirty or not.
		/// </summary>
		[FieldProperty]
		public bool Dirty { get; set; }

		/// <summary>
		/// The way the Mesh should be drawn.
		/// </summary>
		[FieldProperty]
		public DrawMode DrawMode { get; set; }

		/// <summary>
		/// The texture that the sprite is using.
		/// </summary>
		public Texture Texture { get; set; }

		/// <summary>
		/// The UVs of the mesh.
		/// </summary>
		[FieldProperty]
		public Float32Array UVs { get; set; }

		/// <summary>
		/// An array of vertices.
		/// </summary>
		[FieldProperty]
		public Float32Array Vertices { get; set; }

		/// <summary>
		/// Tests if a point is inside this mesh. Works only for TriangleMesh.
		/// </summary>
		/// <param name="point">The point to test.</param>
		/// <returns>The result of the test.</returns>
		public extern bool ContainsPoint(Point point);
	}
}