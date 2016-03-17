namespace Bridge.Pixi.Filters
{
	/// <summary>
	/// This filter applies a dotscreen effect making display objects appear to be made
	/// out of black and white halftone dots like an old printer.
	/// </summary>
	[External]
	[Namespace("PIXI.filters")]
	public class DotScreenFilter : AbstractFilter
	{
		public extern DotScreenFilter();

		/// <summary>
		/// The radius of the effect.
		/// </summary>
		[FieldProperty]
		public float Angle { get; set; }

		/// <summary>
		/// The scale of the effect.
		/// </summary>
		[FieldProperty]
		public float Scale { get; set; }
	}
}