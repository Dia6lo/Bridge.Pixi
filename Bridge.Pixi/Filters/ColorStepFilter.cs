namespace Bridge.Pixi.Filters
{
	[External]
	[Namespace("PIXI.filters")]
	public class ColorStepFilter : AbstractFilter
	{
		/// <summary>
		/// The number of steps to reduce the palette by.
		/// </summary>
		[FieldProperty]
		public float Step { get; set; }
	}
}