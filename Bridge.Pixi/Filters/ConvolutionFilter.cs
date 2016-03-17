namespace Bridge.Pixi.Filters
{
	/// <summary>
	/// The ConvolutionFilter class applies a matrix convolution filter effect.A convolution
	/// combines pixels in the input image with neighboring pixels to produce a new image.
	/// A wide variety of image effects can be achieved through convolutions, including blurring,
	/// edge detection, sharpening, embossing, and beveling. The matrix should be specified as a
	/// 9 point Array. See http://docs.gimp.org/en/plug-in-convmatrix.html for more info.
	/// </summary>
	[External]
	[Namespace("PIXI.filters")]
	public class ConvolutionFilter : AbstractFilter
	{
		/// <param name="matrix">
		/// An array of values used for matrix transformation. Specified as a 9 point Array.
		/// </param>
		/// <param name="width">Width of the object you are transforming.</param>
		/// <param name="height">Height of the object you are transforming.</param>
		public extern ConvolutionFilter(float[] matrix, float width, float height);

		/// <summary>
		/// Height of the object you are transforming.
		/// </summary>
		[FieldProperty]
		public bool Height { get; set; }

		/// <summary>
		/// An array of values used for matrix transformation. Specified as a 9 point Array.
		/// </summary>
		[FieldProperty]
		public bool Matrix { get; set; }

		/// <summary>
		/// Width of the object you are transforming.
		/// </summary>
		[FieldProperty]
		public bool Width { get; set; }

		public extern void SomeMethod();
	}
}