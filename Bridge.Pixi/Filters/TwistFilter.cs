namespace Bridge.Pixi.Filters
{
	/// <summary>
	/// This filter applies a twist effect making display objects appear twisted in the given direction.
	/// </summary>
	[External]
	[Namespace("PIXI.filters")]
	public class TwistFilter : AbstractFilter
	{
		public extern TwistFilter();

		/// <summary>
		/// This angle of the twist.
		/// </summary>
		[FieldProperty]
		public float Angle { get; set; }

		/// <summary>
		/// This point describes the the offset of the twist.
		/// </summary>
		[FieldProperty]
		public Point Offset { get; set; }

		/// <summary>
		/// This radius of the twist.
		/// </summary>
		[FieldProperty]
		public float Radius { get; set; }
	}
}