namespace Bridge.Pixi.Filters
{
	/// <summary>
	/// This applies a sepia effect to your Display Objects.
	/// </summary>
	[External]
	[Namespace("PIXI.filters")]
	public class SepiaFilter : AbstractFilter
	{
		public extern SepiaFilter();

		/// <summary>
		/// The strength of the sepia. 1 will apply the full sepia effect,
		/// and 0 will make the object its normal color.
		/// </summary>
		[FieldProperty]
		public float Sepia { get; set; }
	}
}