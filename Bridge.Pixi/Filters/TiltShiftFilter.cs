namespace Bridge.Pixi.Filters
{
	/// <summary>
	/// A TiltShift Filter. Manages the pass of both a TiltShiftXFilter and TiltShiftYFilter.
	/// </summary>
	[External]
	[Namespace("PIXI.filters")]
	public class TiltShiftFilter : AbstractFilter
	{
		public extern TiltShiftFilter();

		/// <summary>
		/// The strength of the blur.
		/// </summary>
		[FieldProperty]
		public float Blur { get; set; }

		/// <summary>
		/// The X value to end the effect at.
		/// </summary>
		[FieldProperty]
		public float End { get; set; }

		/// <summary>
		/// The strength of the gradient blur.
		/// </summary>
		[FieldProperty]
		public float GradientBlur { get; set; }

		/// <summary>
		/// The X value to start the effect at.
		/// </summary>
		[FieldProperty]
		public float Start { get; set; }
	}
}