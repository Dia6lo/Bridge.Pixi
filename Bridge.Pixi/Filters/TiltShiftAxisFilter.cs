namespace Bridge.Pixi.Filters
{
	[External]
	[Namespace("PIXI.filters")]
	public class TiltShiftAxisFilter : AbstractFilter
	{
		public extern TiltShiftAxisFilter();

		/// <summary>
		/// The strength of the blur.
		/// </summary>
		[FieldProperty]
		public float Blur { get; set; }

		/// <summary>
		/// The X value to end the effect at.
		/// </summary>
		[FieldProperty]
		public Point End { get; set; }

		/// <summary>
		/// The strength of the gradient blur.
		/// </summary>
		[FieldProperty]
		public float GradientBlur { get; set; }

		/// <summary>
		/// The X value to start the effect at.
		/// </summary>
		[FieldProperty]
		public Point Start { get; set; }

		/// <summary>
		/// Updates the filter delta values. This is overridden in the X and Y filters,
		/// does nothing for this class.
		/// </summary>
		public extern void UpdateDelta();
	}
}