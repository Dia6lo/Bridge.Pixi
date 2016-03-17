namespace Bridge.Pixi.Extras
{
	[External]
	[ObjectLiteral]
	public class Font
	{
		/// <summary>
		/// The bitmap font id.
		/// </summary>
		[FieldProperty]
		public string Name { get; set; }

		/// <summary>
		/// The size of the font in pixels, e.g. 24.
		/// </summary>
		[FieldProperty]
		public int Size { get; set; }
	}
}