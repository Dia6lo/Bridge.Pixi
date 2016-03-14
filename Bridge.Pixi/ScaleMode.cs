namespace Bridge.Pixi
{
	/// <summary>
	/// The scale modes that are supported by Pixi.
	/// </summary>
	[External]
	[Name("PIXI.SCALE_MODES")]
	[Enum(Emit.Name)]
	public enum ScaleMode
	{
		/// <summary>
		/// Default mode. Can be set at Pixi.DefaultScaleMode.
		/// </summary>
		[Name("DEFAULT")]
		Default,

		/// <summary>
		/// Smooth scaling.
		/// </summary>
		[Name("LINEAR")]
		Linear,

		/// <summary>
		/// Pixelating scaling.
		/// </summary>
		[Name("NEAREST")]
		Nearest
	}
}