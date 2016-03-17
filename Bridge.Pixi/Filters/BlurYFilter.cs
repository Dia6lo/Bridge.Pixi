namespace Bridge.Pixi.Filters
{
	/// <summary>
	/// The BlurYFilter applies a horizontal Gaussian blur to an object.
	/// </summary>
	[External]
	[Namespace("PIXI.filters")]
	public class BlurYFilter : AbstractFilter
	{
		public extern BlurYFilter();

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