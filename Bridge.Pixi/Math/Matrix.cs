namespace Bridge.Pixi
{
	/// <summary>
	/// The pixi Matrix class as an object, which makes it a lot faster,
	/// here is a representation of it:
	/// <para>| a | b | tx|</para>
	/// <para>| c | d | ty|</para>
	/// <para>| 0 | 0 | 1 |</para>
	/// </summary>
	[External]
	[Namespace("PIXI")]
	public class Matrix
	{
		/// <summary>
		/// A default (identity) matrix.
		/// </summary>
		[Name("IDENTITY")]
		public static Matrix Identity;

		/// <summary>
		/// A temp matrix.
		/// </summary>
		[Name("TEMP_MATRIX")]
		public static Matrix TempMatrix;

		public float A = 1;

		public float B = 0;

		public float C = 0;

		public float D = 1;

		public float TX = 0;

		public float TY = 0;

		/// <summary>
		/// Appends the given Matrix to this Matrix.
		/// </summary>
		/// <returns>Matrix. Good for chaining method calls.</returns>
		public extern Matrix Append(Matrix matrix);

		/// <summary>
		/// Get a new position with the current transformation applied.
		/// Can be used to go from a child's coordinate space to the world coordinate space. (e.g. rendering)
		/// </summary>
		/// <param name="pos">The origin.</param>
		/// <param name="newPos">The point that the new position is assigned to (allowed to be same as input).</param>
		/// <returns>The new point, transformed through this matrix.</returns>
		public extern Point Apply(Point pos, Point newPos = null);


		/// <summary>
		/// Get a new position with the inverse of the current transformation applied.
		/// Can be used to go from a child's coordinate space to the world coordinate space. (e.g. rendering)
		/// </summary>
		/// <param name="pos">The origin.</param>
		/// <param name="newPos">The point that the new position is assigned to (allowed to be same as input).</param>
		/// <returns>The new point, inverse-transformed through this matrix.</returns>
		public extern Point ApplyInverse(Point pos, Point newPos = null);

		/// <summary>
		/// Creates a new Matrix object with the same values as this one.
		/// </summary>
		/// <returns>A copy of this matrix. Good for chaining method calls.</returns>
		public extern Matrix Clone();

		/// <summary>
		/// Changes the values of the given matrix to be the same as the ones in this matrix.
		/// </summary>
		/// <returns>The matrix given in parameter with its values updated.</returns>
		public extern Matrix Copy(Matrix matrix);

		/// <summary>
		/// Creates a Matrix object based on the given array. The Element to Matrix mapping order is as follows:
		/// <para>a = array[0]</para>
		/// <para>b = array[1]</para>
		/// <para>tx = array[2]</para>
		/// <para>c = array[3]</para>
		/// <para>d = array[4]</para>
		/// <para>ty = array[5]</para>
		/// </summary>
		/// <param name="array">The array that the matrix will be populated from.</param>
		public extern void FromArray(float[] array);

		/// <summary>
		/// Resets this Matix to an identity (default) matrix.
		/// </summary>
		/// <returns>This matrix. Good for chaining method calls.</returns>
		[Name("identity")]
		public extern Matrix ToIdentity();

		/// <summary>
		/// Inverts this matrix.
		/// </summary>
		/// <returns>This matrix. Good for chaining method calls.</returns>
		public extern Matrix Invert();

		/// <summary>
		/// Prepends the given Matrix to this Matrix.
		/// </summary>
		/// <returns>This matrix. Good for chaining method calls.</returns>
		public extern Matrix Prepend(Matrix matrix);

		/// <summary>
		/// Applies a rotation transformation to the matrix.
		/// </summary>
		/// <param name="angle">The angle in radians.</param>
		/// <returns>This matrix. Good for chaining method calls.</returns>
		public extern Matrix Rotate(float angle);

		/// <summary>
		/// Applies a scale transformation to the matrix.
		/// </summary>
		/// <param name="x">The amount to scale horizontally.</param>
		/// <param name="y">The amount to scale vertically.</param>
		/// <returns>This matrix. Good for chaining method calls.</returns>
		public extern Matrix Scale(float x, float y);

		/// <summary>
		/// Creates an array from the current Matrix object.
		/// </summary>
		/// <param name="transpose">Whether we need to transpose the matrix or not.</param>
		/// <returns>The newly created array which contains the matrix</returns>
		public extern float[] ToArray(bool transpose);

		/// <summary>
		/// Translates the matrix on the x and y.
		/// </summary>
		/// <param name="x">The amount to translate horizontally.</param>
		/// <param name="y">The amount to translate vertically.</param>
		/// <returns>This matrix. Good for chaining method calls.</returns>
		public extern Matrix Translate(float x, float y);
	}
}