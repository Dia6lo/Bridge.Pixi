namespace Bridge.Pixi.Filters
{
	/// <summary>
	/// This filter applies a pixelate effect making display objects appear 'blocky'.
	/// </summary>
	[External]
	[Namespace("PIXI.filters")]
	public class PixelateFilter : AbstractFilter
	{
		public extern PixelateFilter();

		/// <summary>
		/// This a point that describes the size of the blocks.
		/// x is the width of the block and y is the height.
		/// </summary>
		[FieldProperty]
		public Point Size { get; set; }
	}
}