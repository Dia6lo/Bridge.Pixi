namespace Bridge.Pixi.Filters
{
	/// <summary>
	/// The DropShadowFilter applies a Gaussian blur to an object.
	/// The strength of the blur can be set for x- and y-axis separately.
	/// </summary>
	[External]
	[Namespace("PIXI.filters")]
	public class DropShadowFilter : AbstractFilter
	{
		public extern DropShadowFilter();

		/// <summary>
		/// Sets the alpha of the shadow.
		/// </summary>
		[FieldProperty]
		public float Alpha { get; set; }

		/// <summary>
		/// Sets the angle of the shadow.
		/// </summary>
		[FieldProperty]
		public float Angle { get; set; }

		/// <summary>
		/// Sets the strength of both the blurX and blurY properties simultaneously.
		/// </summary>
		[FieldProperty]
		public float Blur { get; set; }

		/// <summary>
		/// Sets the strength of the blurX property.
		/// </summary>
		[FieldProperty]
		public float BlurX { get; set; }

		/// <summary>
		/// Sets the strength of the blurY property.
		/// </summary>
		[FieldProperty]
		public float BlurY { get; set; }

		/// <summary>
		/// Sets the color of the shadow.
		/// </summary>
		[FieldProperty]
		public int Color { get; set; }

		/// <summary>
		/// Sets the distance of the shadow.
		/// </summary>
		[FieldProperty]
		public float Distance { get; set; }
	}
}