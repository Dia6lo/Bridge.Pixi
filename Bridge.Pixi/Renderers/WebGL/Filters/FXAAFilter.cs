namespace Bridge.Pixi
{
	/// <summary>
	/// Basic FXAA implementation based on the code on geeks3d.com with the modification that the
	/// texture2DLod stuff was removed since it's unsupported by WebGL.
	/// </summary>
	[External]
	[Name("PIXI.FXAAFilter")]
	public abstract class FXAAFilter : AbstractFilter
	{
		public extern FXAAFilter();

		/// <summary>
		/// Applies the filter.
		/// </summary>
		/// <param name="renderer">The renderer to retrieve the filter from.</param>
		public extern void ApplyFilter(WebGLRenderer renderer, RenderTarget input,
			RenderTarget output);
	}
}