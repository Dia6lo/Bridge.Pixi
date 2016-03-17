namespace Bridge.Pixi
{
	/// <summary>
	/// Various webgl draw modes. These can be used to specify which GL DrawMode
	/// to use under certain situations and renderers.
	/// </summary>
	[External]
	[Name("PIXI.DRAW_MODES")]
	[Enum(Emit.Name)]
	public enum DrawMode
	{
		[Name("POINTS")]
		Points,

		[Name("LINES")]
		Lines,

		[Name("LINE_LOOP")]
		LineLopp,

		[Name("LINE_STRIP")]
		LineStrip,

		[Name("TRIANGLES")]
		Triangles,

		[Name("TRIANGLE_STRIP")]
		TriangleStrip,

		[Name("TRIANGLE_FAN")]
		TriangleFan,
	}
}