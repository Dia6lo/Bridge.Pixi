namespace Bridge.Pixi.Filters
{
	/// <summary>
	/// The BlurDirFilter applies a Gaussian blur toward a direction to an object.
	/// </summary>
	[External]
	[Namespace("PIXI.filters")]
	public class BlurDirFilter : AbstractFilter
	{
		public extern BlurDirFilter(float dirX, float dirY);

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

		/// <summary>
		/// Sets the X direction of the blur.
		/// </summary>
		[FieldProperty]
		public float DirX { get; set; }

		/// <summary>
		/// Sets the Y direction of the blur.
		/// </summary>
		[FieldProperty]
		public float DirY { get; set; }
	}
}