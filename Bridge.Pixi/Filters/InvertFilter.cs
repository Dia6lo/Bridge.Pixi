namespace Bridge.Pixi.Filters
{
	/// <summary>
	/// This inverts your Display Objects colors.
	/// </summary>
	[External]
	[Namespace("PIXI.filters")]
	public class InvertFilter : AbstractFilter
	{
		public extern InvertFilter();

		/// <summary>
		/// The strength of the invert. 1 will fully invert the colors,
		/// and 0 will make the object its normal color.
		/// </summary>
		[FieldProperty]
		public float Invert { get; set; }
	}
}