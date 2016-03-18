namespace Bridge.Pixi
{
	[External]
	[IgnoreCast]
	public interface IShape
	{

		/// <summary>
		/// Checks whether the x and y coordinates given are contained within this Shape.
		/// </summary>
		/// <param name="x">The X coordinate of the point to test.</param>
		/// <param name="y">The Y coordinate of the point to test.</param>
		/// <returns>Whether the x and y coordinates are within this Shape.</returns>
		bool Contains(float x, float y);
	}
}