namespace Bridge.Pixi.Filters
{
	[External]
	[Name("PIXI.filters.AsciiFilter")]
	public class ASCIIFilter : AbstractFilter
	{
		public extern ASCIIFilter();

		/// <summary>
		/// The pixel size used by the filter.
		/// </summary>
		[FieldProperty]
		public float Size { get; set; }
	}
}