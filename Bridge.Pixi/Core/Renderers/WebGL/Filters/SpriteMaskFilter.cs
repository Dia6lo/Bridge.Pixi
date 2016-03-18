namespace Bridge.Pixi
{
	[External]
	[Namespace("PIXI")]
	public abstract class SpriteMaskFilter : AbstractFilter
	{
		public extern SpriteMaskFilter(Sprite sprite);

		public Sprite MaskSprite { get; set; }

		public Matrix MaskMatrix { get; set; }

		/// <summary>
		/// The texture used for the displacement map. Must be power of 2 sized texture.
		/// </summary>
		public Texture Map { get; set; }

		/// <summary>
		/// The offset used to move the displacement map.
		/// </summary>
		public Point Offset { get; set; }

		/// <summary>
		/// Applies the filter.
		/// </summary>
		/// <param name="renderer">The renderer to retrieve the filter from.</param>
		public extern void ApplyFilter(WebGLRenderer renderer, RenderTarget input,
			RenderTarget output);
	}
}