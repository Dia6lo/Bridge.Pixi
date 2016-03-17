namespace Bridge.Pixi.Mesh
{
	/// <summary>
	/// Different drawing buffer modes supported
	/// </summary>
	[External]
	[Name("PIXI.mesh.Mesh.DRAW_MODES")]
	[Enum(Emit.Name)]
	public enum DrawMode
	{
		[Name("TRIANGLES_MESH")]
		TrianglesMesh,

		[Name("TRIANGLES")]
		Triangles
	}
}