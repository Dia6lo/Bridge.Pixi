namespace Bridge.Pixi
{
	/// <summary>
	/// Various blend modes supported by PIXI.
	/// IMPORTANT - The WebGL renderer only supports the Normal, Add, Multiply and Screen blend modes.
	/// Anything else will silently act like Normal.
	/// </summary>
	[External]
	[Name("PIXI.BLEND_MODES")]
	[Enum(Emit.Name)]
	public enum BlendMode
	{
		[Name("NORMAL")]
		Normal,

		[Name("ADD")]
		Add,

		[Name("MULTIPLY")]
		Multiply,

		[Name("SCREEN")]
		Screen,

		[Name("OVERLAY")]
		Overlay,

		[Name("DARKEN")]
		Darken,

		[Name("LIGHTEN")]
		Lighten,

		[Name("COLOR_DODGE")]
		ColorDodge,

		[Name("COLOR_BURN")]
		ColorBurn,

		[Name("HARD_LIGHT")]
		HardLight,

		[Name("SOFT_LIGHT")]
		SoftLight,

		[Name("DIFFERENCE")]
		Difference,

		[Name("EXCLUSION")]
		Exclusion,

		[Name("HUE")]
		Hue,

		[Name("SATURATION")]
		Saturation,

		[Name("COLOR")]
		Color,

		[Name("LUMINOSITY")]
		Luminosity
	}
}