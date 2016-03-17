namespace Bridge.Pixi.Filters
{
	/// <summary>
	/// The BlurYTintFilter applies a vertical Gaussian blur to an object.
	/// </summary>
	[External]
	[Namespace("PIXI.filters")]
	public class BlurYTintFilter : AbstractFilter
	{
		public extern BlurYTintFilter();

		/// <summary>
		/// Sets the strength of blur.
		/// </summary>
		[FieldProperty]
		public float Blur { get; set; }

		/// <summary>
		/// Sets the number of passes for blur. More passes means higher quaility bluring.
		/// </summary>
		[FieldProperty]
		public int Passes { get; set; }
	}
}