namespace Bridge.Pixi
{
	[External]
	[Name("PIXI.SHAPES")]
	[Enum(Emit.Name)]
	public enum ShapeType
	{
		[Name("POLY")]
		Polygon,

		[Name("RECT")]
		Rectangle,

		[Name("CIRC")]
		Circle,

		[Name("ELIP")]
		Ellipse,

		[Name("RREC")]
		RoundedRectangle
	}
}
