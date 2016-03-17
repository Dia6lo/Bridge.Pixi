namespace Bridge.Pixi.Filters
{
	/// <summary>
	/// This greyscales the palette of your Display Objects.
	/// </summary>
	[External]
	[Namespace("PIXI.filters")]
	public class GrayFilter : AbstractFilter
	{
		public extern GrayFilter();

		/// <summary>
		/// The strength of the gray. 1 will make the object black and white,
		/// 0 will make the object its normal color.
		/// </summary>
		[FieldProperty]
		public float Gray { get; set; }
	}
}