namespace Bridge.Pixi.Filters
{
	/// <summary>
	/// An RGB Split Filter.
	/// </summary>
	[External]
	[Namespace("PIXI.filters")]
	public class RGBSplitFilter : AbstractFilter
	{
		public extern RGBSplitFilter();

		/// <summary>
		/// Blue offset.
		/// </summary>
		[FieldProperty]
		public Point Blue { get; set; }

		/// <summary>
		/// Green channel offset.
		/// </summary>
		[FieldProperty]
		public Point Green { get; set; }

		/// <summary>
		/// Red channel offset.
		/// </summary>
		[FieldProperty]
		public Point Red { get; set; }
	}
}