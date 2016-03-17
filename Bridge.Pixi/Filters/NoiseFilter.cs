namespace Bridge.Pixi.Filters
{
	/// <summary>
	/// A Noise effect filter.
	/// </summary>
	[External]
	[Namespace("PIXI.filters")]
	public class NoiseFilter : AbstractFilter
	{
		public extern NoiseFilter();

		/// <summary>
		/// The amount of noise to apply.
		/// </summary>
		[FieldProperty]
		public float Noise { get; set; }
	}
}