using Bridge.Html5;

namespace Bridge.Pixi.Filters
{
	/// <summary>
	/// The ColorMatrixFilter class lets you apply a 5x4 matrix transformation on the RGBA color
	/// and alpha values of every pixel on your displayObject to produce a result with a new set
	/// of RGBA color and alpha values. It's pretty powerful!
	/// </summary>
	[External]
	[Namespace("PIXI.filters")]
	public class ColorMatrixFilter : AbstractFilter
	{
		public extern ColorMatrixFilter();

		/// <summary>
		/// Sets the matrix of the color matrix filter.
		/// </summary>
		[FieldProperty]
		public int[] Matrix { get; set; }

		public extern void SomeMethod();

		/// <summary>
		/// Create a Float32 Array and normalize the offset component to 0-1.
		/// </summary>
		/// <param name="matrix">(mat 5x4)</param>
		/// <returns>(mat 5x4) with all values between 0-1.</returns>
		[Name("_colorMatrix")]
		public extern Float32Array ColorMatrix(float[] matrix);

		/// <summary>
		/// Transforms current matrix and set the new one.
		/// </summary>
		/// <param name="matrix">(mat 5x4)</param>
		/// <param name="multiply">
		/// If true, current matrix and matrix are multiplied.
		/// If false, just set the current matrix with provided matrix.
		/// </param>
		[Name("_loadMatrix")]
		public extern void LoadMatrix(float[] matrix, bool multiply);

		/// <summary>
		/// Multiplies two mat5's
		/// </summary>
		/// <param name="out">(mat 5x4) the receiving matrix.</param>
		/// <param name="a">(mat 5x4) the first operand.</param>
		/// <param name="b">(mat 5x4) the second operand.</param>
		/// <returns>out (mat 5x4).</returns>
		[Name("_multiply")]
		public extern Float32Array Multiply(float[] @out, float[] a, float[] b);

		/// <summary>
		/// Set the black and white matrice Multiply the current matrix.
		/// </summary>
		/// <param name="multiply">
		/// If true, current matrix and matrix are multiplied.
		/// If false, just set the current matrix with provided matrix.
		/// </param>
		public extern void BlackAndWhite(bool multiply);

		/// <summary>
		/// Adjusts brightness.
		/// </summary>
		/// <param name="brightness">Value of the brightness (0 is black)</param>
		/// <param name="multiply">
		/// If true, current matrix and matrix are multiplied.
		/// If false, just set the current matrix with provided matrix.
		/// </param>
		public extern void Brightness(float brightness, bool multiply);

		/// <summary>
		/// Brown delicious browni filter.
		/// </summary>
		/// <param name="multiply">
		/// If true, current matrix and matrix are multiplied.
		/// If false, just set the current matrix with provided matrix.
		/// </param>
		public extern void Browni(bool multiply);

		/// <summary>
		/// Set the contrast matrix, increase the separation between dark and bright.
		/// Increase contrast: shadows darker and highlights brighter.
		/// Decrease contrast: bring the shadows up and the highlights down.
		/// </summary>
		/// <param name="amount">Value of the contrast.</param>
		/// <param name="multiply">
		/// If true, current matrix and matrix are multiplied.
		/// If false, just set the current matrix with provided matrix.
		/// </param>
		public extern void Contrast(float amount, bool multiply);

		/// <summary>
		/// Desaturate image (remove color).
		/// </summary>
		/// <param name="multiply">
		/// If true, current matrix and matrix are multiplied.
		/// If false, just set the current matrix with provided matrix.
		/// </param>
		public extern void Desaturate(bool multiply);

		/// <summary>
		/// Set the matrices in grey scales.
		/// </summary>
		/// <param name="scale">Value of the grey (0 is black).</param>
		/// <param name="multiply">
		/// If true, current matrix and matrix are multiplied.
		/// If false, just set the current matrix with provided matrix.
		/// </param>
		public extern void Greyscale(float scale, bool multiply);

		/// <summary>
		/// Set the hue property of the color.
		/// </summary>
		/// <param name="scale">In degrees.</param>
		/// <param name="multiply">
		/// If true, current matrix and matrix are multiplied.
		/// If false, just set the current matrix with provided matrix.
		/// </param>
		public extern void Hue(float scale, bool multiply);

		/// <summary>
		/// Color reversal film introduced by Eastman Kodak in 1935.
		/// </summary>
		/// <param name="multiply">
		/// If true, current matrix and matrix are multiplied.
		/// If false, just set the current matrix with provided matrix.
		/// </param>
		public extern void Kodachrome(bool multiply);

		/// <summary>
		/// Negative image (inverse of classic rgb matrix).
		/// </summary>
		/// <param name="multiply">
		/// If true, current matrix and matrix are multiplied.
		/// If false, just set the current matrix with provided matrix.
		/// </param>
		public extern void Negative(bool multiply);

		/// <summary>
		/// Polaroid filter.
		/// </summary>
		/// <param name="multiply">
		/// If true, current matrix and matrix are multiplied.
		/// If false, just set the current matrix with provided matrix.
		/// </param>
		public extern void Polaroid(bool multiply);

		/// <summary>
		/// Set the saturation matrix, increase the separation between colors.
		/// Increase saturation: increase contrast, brightness, and sharpness.
		/// </summary>
		/// <param name="amount">Value of the saturation.</param>
		/// <param name="multiply">
		/// If true, current matrix and matrix are multiplied.
		/// If false, just set the current matrix with provided matrix.
		/// </param>
		public extern void Saturate(float amount, bool multiply);

		/// <summary>
		/// Sepia image.
		/// </summary>
		/// <param name="multiply">
		/// If true, current matrix and matrix are multiplied.
		/// If false, just set the current matrix with provided matrix.
		/// </param>
		public extern void Sepia(bool multiply);

		/// <summary>
		/// Color motion picture process invented in 1916.
		/// </summary>
		/// <param name="multiply">
		/// If true, current matrix and matrix are multiplied.
		/// If false, just set the current matrix with provided matrix.
		/// </param>
		public extern void Technicolor(bool multiply);

		/// <summary>
		/// Filter who transforms : Red -> Blue and Blue -> Red.
		/// </summary>
		/// <param name="multiply">
		/// If true, current matrix and matrix are multiplied.
		/// If false, just set the current matrix with provided matrix.
		/// </param>
		[Name("toBGR")]
		public extern void ToBGR(bool multiply);
	}
}