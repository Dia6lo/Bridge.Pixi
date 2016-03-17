namespace Bridge.Pixi.Mesh
{
	/// <summary>
	/// The rope allows you to draw a texture across several points and them manipulate these points.
	/// </summary>
	[External]
	[Namespace("PIXI.mesh")]
	public class Rope : Mesh
	{
		/// <param name="texture">The texture to use on the rope.</param>
		/// <param name="points">An array of Point objects to construct this rope.</param>
		public extern Rope(Texture texture, Point[] points);

		/// <summary>
		/// An array of points that determine the rope.
		/// </summary>
		public Point[] Points { get; set; }
	}
}